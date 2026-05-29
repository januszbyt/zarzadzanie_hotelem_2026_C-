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

            Imie.DataPropertyName = "ImieDb";
            Nazwisko.DataPropertyName = "NazwiskoDb";
            email.DataPropertyName = "EmailDb";
            osoby.DataPropertyName = "LiczbaOsobDb";
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

                    string query = @"
                        SELECT 
                            o.Imie AS ImieDb, 
                            o.Nazwisko AS NazwiskoDb, 
                            k.Email AS EmailDb, 
                            1 AS LiczbaOsobDb, 
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
                            r.KwotaLaczna AS KwotaDb
                        FROM Rezerwacje r
                        JOIN Klienci k ON r.IdKlienta = k.IdKlienta
                        JOIN osoby o ON k.Id_osoby = o.Id";

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
            this.Hide();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edytuj_rezerwacje edytujRezerwacje = new Edytuj_rezerwacje();
            edytujRezerwacje.Show();
            this.Hide();
        }

        private void powrótToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}