using MySql.Data.MySqlClient;
using Panel_Glowny;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Panele_Glowne
{
    public partial class Lista_Wszystkich_Pokojow : Form
    {
        private HotelContext db = new HotelContext();

        public Lista_Wszystkich_Pokojow()
        {
            InitializeComponent();
        }

        private void EkranPokoje_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZaladujOdpowiedniaZakladke();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ZaladujOdpowiedniaZakladke();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ZaladujOdpowiedniaZakladke();
        }

        private void ZaladujOdpowiedniaZakladke()
        {
            int wybranyIndeks = tabControl1.SelectedIndex;
            DataGridView aktywneGrid = PobierzAktywneGrid(wybranyIndeks);

            if (aktywneGrid == null) return;

            // Zaktualizowane zapytanie - używamy nowych nazw (CenaPodstawowa, Pojemnosc) 
            // i aliasów (AS), aby dopasować je do Twojej tabeli w programie
            string query = "SELECT IdPokoju, NumerPokoju, TypPokoju, CenaPodstawowa AS CenaZaNoc, Pojemnosc AS IloscOsob FROM Pokoje WHERE 1=1";
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (wybranyIndeks > 0)
            {
                // Zmiana filtrowania na nową kolumnę 'Pojemnosc'
                query += " AND Pojemnosc = @iloscOsob";
                parameters.Add(new MySqlParameter("@iloscOsob", wybranyIndeks));
            }

            if (checkBox1.Checked && !checkBox2.Checked)
            {
                query += " AND TypPokoju = 'Standard'";
            }
            else if (!checkBox1.Checked && checkBox2.Checked)
            {
                query += " AND TypPokoju = 'Deluxe'";
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                query += " AND (TypPokoju = 'Standard' OR TypPokoju = 'Deluxe')";
            }
            else if (!checkBox1.Checked && !checkBox2.Checked)
            {
                query += " AND 1=0";
            }

            LadujDaneZHotelu(query, aktywneGrid, parameters);
        }

        private void LadujDaneZHotelu(string query, DataGridView targetGrid, List<MySqlParameter> parameters)
        {
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null && parameters.Count > 0)
                        {
                            cmd.Parameters.AddRange(parameters.ToArray());
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            targetGrid.DataSource = dt;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Błąd bazy danych przy pobieraniu pokoi: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił nieoczekiwany błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DataGridView PobierzAktywneGrid(int indeksZakladki)
        {
            switch (indeksZakladki)
            {
                case 0: return dataGridView1;
                case 1: return dataGridView6;
                case 2: return dataGridView2;
                case 3: return dataGridView5;
                case 4: return dataGridView3;
                case 5: return dataGridView4;
                default: return dataGridView1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView aktywneGrid = PobierzAktywneGrid(tabControl1.SelectedIndex);

            if (aktywneGrid != null && aktywneGrid.CurrentRow != null && aktywneGrid.CurrentRow.Index >= 0)
            {
                if (aktywneGrid.CurrentRow.Cells["IdPokoju"].Value != null && aktywneGrid.CurrentRow.Cells["IdPokoju"].Value != DBNull.Value)
                {
                    int idPokoju = Convert.ToInt32(aktywneGrid.CurrentRow.Cells["IdPokoju"].Value);

                    Okno_Szczegolowych_Informacji_Pokoju OknoSzczegolow = new Okno_Szczegolowych_Informacji_Pokoju(idPokoju);
                    OknoSzczegolow.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wybrany wiersz jest pusty. Zaznacz prawidłowy pokój.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Wybierz pokój z tabeli.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}