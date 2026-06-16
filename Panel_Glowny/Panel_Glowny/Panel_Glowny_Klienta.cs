using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panele_Glowne
{
    public partial class Panel_Glowny_Klienta : Form
    {
        public Panel_Glowny_Klienta(string ZalogowanyUzytkownik)
        {
            InitializeComponent();
            WczytajRezerwacje();
            this.Load += Panel_Glowny_Klienta_Load;
        }

        public Panel_Glowny_Klienta()
        {
            InitializeComponent();
            this.Load += Panel_Glowny_Klienta_Load;
        }

        private void WczytajRezerwacje()
        {
            HotelContext db = new HotelContext();

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    int idGoscia = ZalogowanyUzytkownik.IdGoscia ?? 0;

                    string query = @"
                SELECT 
                    r.IdRezerwacji,
                    p.NumerPokoju,
                    r.DataPrzyjazdu,
                    r.DataWyjazdu,
                    DATEDIFF(r.DataWyjazdu, r.DataPrzyjazdu) AS LiczbaNocy,
                    r.KwotaCalkowita,
                    CASE
                        WHEN r.StatusRezerwacji = 'Anulowana' THEN 'Anulowana'
                        WHEN r.DataWyjazdu < CURDATE() THEN 'Zakończona'
                        WHEN r.DataWyjazdu = CURDATE() THEN 'Wymeldowanie dzisiaj'
                        WHEN r.DataPrzyjazdu <= CURDATE() AND r.DataWyjazdu > CURDATE() THEN 'Aktywna'
                        WHEN r.DataPrzyjazdu > CURDATE() THEN 'Oczekująca'
                        ELSE 'Błąd daty'
                    END AS StatusRezerwacji
                FROM Rezerwacje r
                LEFT JOIN Pokoje p ON r.IdPokoju = p.IdPokoju
                WHERE r.IdGoscia = @idGoscia";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idGoscia", idGoscia);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView1.DataSource = dt;

                            if (dataGridView1.Columns.Count > 0)
                            {
                                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                dataGridView1.Columns["IdRezerwacji"].Visible = false; 
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd SQL: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Witaj");
        }

        // TWORZENIE REZERWACJI
        private void stworz_Click(object sender, EventArgs e)
        {
            if (ZalogowanyUzytkownik.IdGoscia.HasValue)
            {
                Dodaj_rezerwacje dodaj_Rezerwacje2 = new Dodaj_rezerwacje(ZalogowanyUzytkownik.IdGoscia.Value);
                dodaj_Rezerwacje2.ShowDialog();

                WczytajRezerwacje();
            }
            else
            {
                MessageBox.Show("Błąd: Nie można zidentyfikować zalogowanego gościa.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EDYCJA REZERWACJI
        private void edytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Proszę zaznaczyć rezerwację do edycji.", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = dataGridView1.CurrentRow.Cells["StatusRezerwacji"].Value.ToString();
            DateTime dataPrzyjazdu = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["DataPrzyjazdu"].Value);

            if (status == "Anulowana")
            {
                MessageBox.Show("Nie można edytować anulowanej rezerwacji.", "Blokada edycji", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dataPrzyjazdu <= DateTime.Today)
            {
                MessageBox.Show("Edycja jest możliwa tylko dla rezerwacji, które jeszcze się nie rozpoczęły.", "Brak możliwości edycji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRezerwacji = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdRezerwacji"].Value);

            Edytuj_rezerwacje edytuj_Rezerwacje2 = new Edytuj_rezerwacje(idRezerwacji);
            edytuj_Rezerwacje2.ShowDialog();

            WczytajRezerwacje();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ekran_Logowania_Klienta ekranLogowania2 = new Ekran_Logowania_Klienta();
            ekranLogowania2.Show();
            this.Close();
        }

        private void Panel_Glowny_Klienta_Load(object sender, EventArgs e)
        {
            label2.Text = ZalogowanyUzytkownik.Login + "!";
            WczytajRezerwacje();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnZarzadzajKontem_Click(object sender, EventArgs e)
        {
            OknoZarzadzanieKontem doOknaZarzadzaniaKontem = new OknoZarzadzanieKontem();
            doOknaZarzadzaniaKontem.Show();
            this.Close();
        }
    }
}