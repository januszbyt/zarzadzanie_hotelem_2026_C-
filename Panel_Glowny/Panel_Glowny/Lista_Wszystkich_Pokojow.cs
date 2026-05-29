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
using Panel_Glowny;

namespace Panele_Glowne
{
    public partial class Lista_Wszystkich_Pokojow : Form
    {
        private HotelContext db = new HotelContext();
        public Lista_Wszystkich_Pokojow()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void EkranPokoje_Load(object sender, EventArgs e)
        {
            ZaladujOdpowiedniaZakladke();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZaladujOdpowiedniaZakladke();
        }
        private void ZaladujOdpowiedniaZakladke()
        {
            int wybranyIndeks = tabControl1.SelectedIndex;
            string query = "";

            if (wybranyIndeks == 0)
            {
                query = "SELECT IdPokoju, NumerPokoju, TypPokoju, CenaZaNoc, Status FROM Pokoje";
                LadujDaneZHotelu(query, dataGridView1);
            }
            else if (wybranyIndeks == 1)
            {
                query = "SELECT IdPokoju, NumerPokoju, TypPokoju, CenaZaNoc, Status FROM Pokoje WHERE Status = 'Wolny'";
                LadujDaneZHotelu(query, dataGridView2);
            }
            else if (wybranyIndeks == 2)
            {
                query = "SELECT IdPokoju, NumerPokoju, TypPokoju, CenaZaNoc, Status FROM Pokoje WHERE Status = 'Zajety'";
                LadujDaneZHotelu(query, dataGridView3);
            }
        }

        private void LadujDaneZHotelu(string query, DataGridView targetGrid)
        {
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            targetGrid.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania pokoi - " + ex.Message, "Blad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekran_Glowny_Pracownika powrotDoOknaPracownika = new Ekran_Glowny_Pracownika();
            powrotDoOknaPracownika.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView aktywneGrid = dataGridView1;

            if (tabControl1.SelectedIndex == 1)
            {
                aktywneGrid = dataGridView2;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                aktywneGrid = dataGridView3;
            }
            if (aktywneGrid.CurrentRow != null && aktywneGrid.CurrentRow.Index >= 0)
            {
                int idPokoju = Convert.ToInt32(aktywneGrid.CurrentRow.Cells[0].Value);
                Okno_Szczegolowych_Informacji_Pokoju OknoSzczegolow = new Okno_Szczegolowych_Informacji_Pokoju(idPokoju);
                OknoSzczegolow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wybierz pokoj z tabeli");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}