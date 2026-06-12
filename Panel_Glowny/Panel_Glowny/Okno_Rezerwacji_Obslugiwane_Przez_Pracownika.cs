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
        public Okno_Rezerwacji_Obslugiwane_Przez_Pracownika()
        {
            InitializeComponent();
            this.Load += Okno_Rezerwacji_Obslugiwane_Przez_Pracownika_Load;
        }

        private void Okno_Rezerwacji_Obslugiwane_Przez_Pracownika_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            // Mapowanie kolumn z zapytania SQL na kolumny w DataGridView (wg nowych nazw z Designera)
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

        private void WczytajDane()
        {
            try
            {
                HotelContext dbContext = new HotelContext();

                using (MySqlConnection conn = dbContext.GetConnection())
                {
                    conn.Open();

                    // Nowe zapytanie dopasowane do struktury bazy HotelParadisev2
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

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj_rezerwacje dodajRezerwacje = new Dodaj_rezerwacje();
            dodajRezerwacje.Show();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Proszę zaznaczyć rezerwację do edycji.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pobieramy ID rezerwacji z zaznaczonego wiersza "z tła"
            DataRowView zaznaczonyWiersz = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            int idRezerwacji = Convert.ToInt32(zaznaczonyWiersz["IdRezerwacjiDb"]);

            Edytuj_rezerwacje edytujRezerwacje = new Edytuj_rezerwacje(idRezerwacji);
            edytujRezerwacje.Show();
        }

        private void powrótToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Proszę zaznaczyć rezerwację do anulowania.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView zaznaczonyWiersz = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
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
    }
}