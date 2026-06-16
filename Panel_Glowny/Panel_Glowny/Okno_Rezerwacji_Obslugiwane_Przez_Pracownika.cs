using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Panele_Glowne
{
    public partial class Okno_Rezerwacji_Obslugiwane_Przez_Pracownika : Form
    {
        // Inicjalizacja okna, podpięcie zdarzeń oraz tworzenie menu pod prawym przyciskiem myszy
        public Okno_Rezerwacji_Obslugiwane_Przez_Pracownika()
        {
            InitializeComponent();
            this.Load += Okno_Rezerwacji_Obslugiwane_Przez_Pracownika_Load;

            // Tworzymy menu kontekstowe z poziomu kodu (nadpisuje to z Designera dla pełnej pewności)
            ContextMenuStrip menuKontekstowe = new ContextMenuStrip();

            ToolStripMenuItem edytujOpcja = new ToolStripMenuItem("Edytuj rezerwację");
            edytujOpcja.Click += edytujToolStripMenuItem_Click;

            ToolStripMenuItem usunOpcja = new ToolStripMenuItem("Anuluj rezerwację");
            usunOpcja.Click += usuńToolStripMenuItem_Click;

            menuKontekstowe.Items.Add(edytujOpcja);
            menuKontekstowe.Items.Add(usunOpcja);

            // Podpięcie zdarzenia, które decyduje, czy menu może się pokazać
            menuKontekstowe.Opening += MenuKontekstowe_Opening;

            // Przypisanie do siatki
            dataGridView1.ContextMenuStrip = menuKontekstowe;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
        }

        // Blokowanie wyświetlania menu PPM dla trwających, zakończonych i anulowanych rezerwacji
        private void MenuKontekstowe_Opening(object sender, CancelEventArgs e)
        {
            // Zabezpieczenie przed kliknięciem w puste pole
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                e.Cancel = true;
                return;
            }

            DataRowView zaznaczonyWiersz = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            string statusRezerwacji = zaznaczonyWiersz["StatusDb"].ToString().Trim();
            DateTime dataPrzyjazdu = Convert.ToDateTime(zaznaczonyWiersz["OdDb"]);

            // Anulowana rezerwacja -> blokujemy menu
            if (statusRezerwacji == "Anulowana")
            {
                e.Cancel = true;
                return;
            }

            // Jeśli rezerwacja zaczyna się dzisiaj lub już trwała -> blokujemy menu
            if (dataPrzyjazdu <= DateTime.Today)
            {
                e.Cancel = true;
                return;
            }
        }

        // Konfiguracja przypisania kolumn i pierwsze załadowanie danych przy uruchomieniu okna
        private void Okno_Rezerwacji_Obslugiwane_Przez_Pracownika_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            idRezerwacji.DataPropertyName = "IdRezerwacjiDb";
            Imie.DataPropertyName = "ImieDb";
            Nazwisko.DataPropertyName = "NazwiskoDb";
            telefon.DataPropertyName = "TelefonDb";
            email.DataPropertyName = "EmailDb";
            numerPokoju.DataPropertyName = "NumerPokojuDb";
            status.DataPropertyName = "StatusDb";
            od.DataPropertyName = "OdDb";
            doKiedy.DataPropertyName = "DoKiedyDb";
            kwota.DataPropertyName = "KwotaDb";

            WczytajDane();
        }

        // Pobranie aktualnych danych o rezerwacjach z bazy danych i wyświetlenie ich w tabeli
        private void WczytajDane()
        {
            try
            {
                HotelContext dbContext = new HotelContext();

                using (MySqlConnection conn = dbContext.GetConnection())
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    r.IdRezerwacji AS IdRezerwacjiDb, 
                    g.Imie AS ImieDb, 
                    g.Nazwisko AS NazwiskoDb, 
                    g.Telefon AS TelefonDb,
                    g.Email AS EmailDb, 
                    p.NumerPokoju AS NumerPokojuDb, 
                    CASE
                        WHEN r.StatusRezerwacji = 'Anulowana' THEN 'Anulowana'
                        WHEN r.DataWyjazdu < CURDATE() THEN 'Zakończona'
                        WHEN r.DataWyjazdu = CURDATE() THEN 'Wymeldowanie dzisiaj'
                        WHEN r.DataPrzyjazdu <= CURDATE() AND r.DataWyjazdu > CURDATE() THEN 'Aktywna'
                        WHEN r.DataPrzyjazdu > CURDATE() THEN 'Oczekująca'
                        ELSE 'Błąd daty'
                    END AS StatusDb,
                    r.DataPrzyjazdu AS OdDb, 
                    r.DataWyjazdu AS DoKiedyDb, 
                    r.KwotaCalkowita AS KwotaDb
                FROM Rezerwacje r
                JOIN Goscie g ON r.IdGoscia = g.IdGoscia
                JOIN Pokoje p ON r.IdPokoju = p.IdPokoju";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas ładowania danych z bazy: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {
        }

        // Otwarcie nowego okna formularza do dodawania rezerwacji
        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj_rezerwacje dodajRezerwacje = new Dodaj_rezerwacje();
            dodajRezerwacje.ShowDialog();
            WczytajDane();
        }

        // Walidacja możliwości edycji i otwarcie okna edycji dla wybranego wiersza
        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Proszę zaznaczyć rezerwację do edycji.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView zaznaczonyWiersz = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;

            string statusRezerwacji = zaznaczonyWiersz["StatusDb"].ToString().Trim();
            DateTime dataPrzyjazdu = Convert.ToDateTime(zaznaczonyWiersz["OdDb"]);

            if (statusRezerwacji == "Anulowana")
            {
                MessageBox.Show("Nie można edytować anulowanej rezerwacji.", "Brak możliwości edycji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataPrzyjazdu <= DateTime.Today)
            {
                MessageBox.Show("Edycja jest możliwa tylko dla rezerwacji, które jeszcze się nie rozpoczęły.", "Brak możliwości edycji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRezerwacji = Convert.ToInt32(zaznaczonyWiersz["IdRezerwacjiDb"]);

            Edytuj_rezerwacje edytujRezerwacje = new Edytuj_rezerwacje(idRezerwacji);
            edytujRezerwacje.ShowDialog();
            WczytajDane();
        }

        // Ukrycie aktualnego okna 
        private void powrótToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Walidacja statusu i zmiana statusu wybranej rezerwacji w bazie na anulowaną
        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Proszę zaznaczyć rezerwację do anulowania.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView zaznaczonyWiersz = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            string statusRezerwacji = zaznaczonyWiersz["StatusDb"].ToString().Trim();
            DateTime dataPrzyjazdu = Convert.ToDateTime(zaznaczonyWiersz["OdDb"]);

            if (statusRezerwacji == "Anulowana")
            {
                MessageBox.Show("Ta rezerwacja została już anulowana.", "Brak możliwości anulowania", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dataPrzyjazdu <= DateTime.Today)
            {
                MessageBox.Show("Można anulować jedynie rezerwacje, które jeszcze się nie rozpoczęły (oczekujące).", "Brak możliwości anulowania", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRezerwacji = Convert.ToInt32(zaznaczonyWiersz["IdRezerwacjiDb"]);

            DialogResult potwierdzenie = MessageBox.Show("Czy na pewno chcesz anulować tę rezerwację?", "Potwierdzenie anulowania", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (potwierdzenie == DialogResult.No)
            {
                return;
            }

            try
            {
                HotelContext dbContext = new HotelContext();
                using (MySqlConnection conn = dbContext.GetConnection())
                {
                    conn.Open();

                    string updateQuery = "UPDATE Rezerwacje SET StatusRezerwacji = 'Anulowana' WHERE IdRezerwacji = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idRezerwacji);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Rezerwacja została pomyślnie anulowana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                WczytajDane();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas anulowania rezerwacji:\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Obsługa kliknięcia prawym przyciskiem myszy (wymuszenie zaznaczenia najechanego wiersza przed otwarciem menu)
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
            }
        }
    }
}