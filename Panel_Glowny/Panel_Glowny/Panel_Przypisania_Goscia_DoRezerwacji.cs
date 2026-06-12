using Panel_Glowny;
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
    public partial class Panel_Przypisania_Goscia_DoRezerwacji : Form
    {
        private DataGridViewRow? _edytowanyWiersz = null;

        public Panel_Przypisania_Goscia_DoRezerwacji()
        {
            InitializeComponent();
            button7.Location = button1.Location;
            button7.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            WczytajGosci();
        }


        private void WczytajGosci()
        {
            dataGridView1.Rows.Clear(); 

            HotelContext db = new HotelContext();

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

  
                    string query = @"
                        SELECT 
                            g.IdGoscia, 
                            g.Imie, 
                            g.Nazwisko, 
                            g.Telefon, 
                            g.Email,
                            COUNT(r.IdRezerwacji) AS LiczbaRezerwacji
                        FROM Goscie g
                        LEFT JOIN Rezerwacje r ON g.IdGoscia = r.IdGoscia
                        GROUP BY g.IdGoscia, g.Imie, g.Nazwisko, g.Telefon, g.Email";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader["IdGoscia"].ToString();
                        string imie = reader["Imie"].ToString();
                        string nazwisko = reader["Nazwisko"].ToString();
                        string telefon = reader["Telefon"].ToString();
                        string email = reader["Email"].ToString();
                        string liczbaRezerwacji = reader["LiczbaRezerwacji"].ToString();

                        dataGridView1.Rows.Add(id, imie, nazwisko, telefon, email, liczbaRezerwacji);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych z bazy: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Zaznacz gościa, aby zobaczyć historię pobytów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idGoscia = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            Panel_Informacji_Histori_Pobytu HistoriaGoscia2 = new Panel_Informacji_Histori_Pobytu(idGoscia);
            HistoriaGoscia2.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Zaznacz wiersz do edycji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            textBox1.Text = row.Cells[1].Value?.ToString() ?? ""; 
            textBox2.Text = row.Cells[2].Value?.ToString() ?? "";
            textBox3.Text = row.Cells[3].Value?.ToString() ?? ""; 
            textBox4.Text = row.Cells[4].Value?.ToString() ?? ""; 
            textBox5.Text = row.Cells[5].Value?.ToString() ?? ""; 

            _edytowanyWiersz = row;
            button7.Visible = true;
            button1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            _edytowanyWiersz = null;
            button7.Visible = false;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Zaznacz wiersz do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult wynik = MessageBox.Show("Czy na pewno chcesz usunąć tego gościa?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (wynik == DialogResult.Yes)
            {
                string idGoscia = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                HotelContext db = new HotelContext();
                using (var conn = db.GetConnection())
                {
                    try
                    {
                        conn.Open();


                        string queryDelGoscie = "DELETE FROM Goscie WHERE IdGoscia = @idGoscia";
                        MySqlCommand cmdDel = new MySqlCommand(queryDelGoscie, conn);
                        cmdDel.Parameters.AddWithValue("@idGoscia", idGoscia);
                        cmdDel.ExecuteNonQuery();

                        WczytajGosci();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas usuwania: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Wypełnij przynajmniej imię i nazwisko!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HotelContext db = new HotelContext();
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"INSERT INTO Goscie (Imie, Nazwisko, Telefon, Email, DokumentTozsamosci) 
                                     VALUES (@imie, @nazwisko, @telefon, @email, '')";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@imie", textBox1.Text);
                    cmd.Parameters.AddWithValue("@nazwisko", textBox2.Text);
                    cmd.Parameters.AddWithValue("@telefon", textBox3.Text);
                    cmd.Parameters.AddWithValue("@email", textBox4.Text);

                    cmd.ExecuteNonQuery();

                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();

                    WczytajGosci();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas dodawania: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (_edytowanyWiersz != null)
            {
                string idGoscia = _edytowanyWiersz.Cells[0].Value.ToString();

                HotelContext db = new HotelContext();
                using (var conn = db.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        string query = @"
                            UPDATE Goscie 
                            SET Imie = @imie, 
                                Nazwisko = @nazwisko, 
                                Telefon = @telefon, 
                                Email = @email
                            WHERE IdGoscia = @idGoscia";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@imie", textBox1.Text);
                        cmd.Parameters.AddWithValue("@nazwisko", textBox2.Text);
                        cmd.Parameters.AddWithValue("@telefon", textBox3.Text);
                        cmd.Parameters.AddWithValue("@email", textBox4.Text);
                        cmd.Parameters.AddWithValue("@idGoscia", idGoscia);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas aktualizacji: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                _edytowanyWiersz = null;
            }

            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();
            button7.Visible = false;
            button1.Visible = true;

            WczytajGosci();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}