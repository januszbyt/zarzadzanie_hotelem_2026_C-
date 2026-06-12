using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Panele_Glowne
{
    public partial class Panel_Informacji_Histori_Pobytu : Form
    {
        private int _wybraneIdKlienta; // Zmienna, która trzyma ID przysłane z pierwszego okna

        // Konstruktor teraz przyjmuje ID klienta
        public Panel_Informacji_Histori_Pobytu(int idKlienta)
        {
            InitializeComponent();
            _wybraneIdKlienta = idKlienta;

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;

            WczytajHistoriePobytow();
        }

        private void WczytajHistoriePobytow()
        {
            // Zapytanie filtrujące konkretnie pod wybranego gościa (WHERE k.IdKlienta = @IdKlienta)
            string query = @"
                SELECT 
                    r.IdRezerwacji AS 'IdRezerwacji', 
                    p.NumerPokoju AS 'Pokoj', 
                    r.DataPrzyjazdu AS 'DataPrzyjazdu', 
                    r.DataWyjazdu AS 'DataOdjazdu', 
                    r.LiczbaNocy AS 'Liczba Nocy',
                    r.KwotaLaczna AS 'Kwota',
                    r.StatusRezerwacji AS 'Status',
                    r.Uwagi AS 'Uwagi',
                    o.Id AS 'IdOsoby', 
                    o.Imie AS 'Imie', 
                    o.Nazwisko AS 'Nazwisko', 
                    k.NumerTelefonu AS 'Telefon', 
                    k.Email AS 'Email'
                FROM Rezerwacje r
                JOIN Klienci k ON r.IdKlienta = k.IdKlienta
                JOIN osoby o ON k.Id_osoby = o.Id
                JOIN Pokoje p ON r.IdPokoju = p.IdPokoju
                WHERE k.IdKlienta = @IdKlienta
                ORDER BY r.DataPrzyjazdu DESC";

            HotelContext db = new HotelContext();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdKlienta", _wybraneIdKlienta); // Podpinamy przysłane ID

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dataGridView1.Columns.Contains("IdOsoby")) dataGridView1.Columns["IdOsoby"].Visible = false;
                    if (dataGridView1.Columns.Contains("Imie")) dataGridView1.Columns["Imie"].Visible = false;
                    if (dataGridView1.Columns.Contains("Nazwisko")) dataGridView1.Columns["Nazwisko"].Visible = false;
                    if (dataGridView1.Columns.Contains("Telefon")) dataGridView1.Columns["Telefon"].Visible = false;
                    if (dataGridView1.Columns.Contains("Email")) dataGridView1.Columns["Email"].Visible = false;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // Jeżeli są jakieś wyniki, od razu wypełnij labele z pierwszego wiersza
                    if (dataGridView1.Rows.Count > 0 && dataGridView1.Rows[0].Cells["IdOsoby"].Value != null)
                    {
                        WypelnijLabele(dataGridView1.Rows[0]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem z bazą:\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                WypelnijLabele(dataGridView1.Rows[e.RowIndex]);
            }
        }

        // Zrobiłem to jako osobną metodę, żeby kod nie był nasrany w dwóch miejscach
        private void WypelnijLabele(DataGridViewRow row)
        {
            label8.Text = row.Cells["IdOsoby"].Value.ToString();
            label9.Text = row.Cells["Imie"].Value.ToString();
            label10.Text = row.Cells["Nazwisko"].Value.ToString();
            label11.Text = row.Cells["Telefon"].Value.ToString();
            label12.Text = row.Cells["Email"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_Przypisania_Goscia_DoRezerwacji EkranGosciePowrot = new Panel_Przypisania_Goscia_DoRezerwacji();
            EkranGosciePowrot.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
    }
}