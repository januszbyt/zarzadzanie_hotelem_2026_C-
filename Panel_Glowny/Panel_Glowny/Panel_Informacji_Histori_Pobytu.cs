using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Panele_Glowne
{
    public partial class Panel_Informacji_Histori_Pobytu : Form
    {
        private int _wybraneIdGoscia;

        public Panel_Informacji_Histori_Pobytu(int idGoscia)
        {
            InitializeComponent();
            _wybraneIdGoscia = idGoscia;

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = true;

            WczytajHistoriePobytow();
        }

        private void WczytajHistoriePobytow()
        {
            string query = @"
                SELECT 
                    r.IdRezerwacji AS 'IdRezerwacji', 
                    p.NumerPokoju AS 'Pokoj', 
                    r.DataPrzyjazdu AS 'DataPrzyjazdu', 
                    r.DataWyjazdu AS 'DataOdjazdu', 
                    DATEDIFF(r.DataWyjazdu, r.DataPrzyjazdu) AS 'Liczba Nocy',
                    r.KwotaCalkowita AS 'Kwota',
                    r.StatusRezerwacji AS 'Status',
                    r.Uwagi AS 'Uwagi',
                    g.IdGoscia AS 'IdOsoby', 
                    g.Imie AS 'Imie', 
                    g.Nazwisko AS 'Nazwisko', 
                    g.Telefon AS 'Telefon', 
                    g.Email AS 'Email'
                FROM Rezerwacje r
                JOIN Goscie g ON r.IdGoscia = g.IdGoscia
                JOIN Pokoje p ON r.IdPokoju = p.IdPokoju
                WHERE g.IdGoscia = @IdGoscia
                ORDER BY r.DataPrzyjazdu DESC";

            HotelContext db = new HotelContext();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdGoscia", _wybraneIdGoscia);

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