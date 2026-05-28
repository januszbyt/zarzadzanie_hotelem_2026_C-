using MySql.Data.MySqlClient;
using Panele_Glowne;
using System.Data;
namespace Panele_Glowne
{
    public partial class EkranAdmin : Form
    {
        HotelContext db = new HotelContext();

        public EkranAdmin()
        {
            InitializeComponent();
            OdswiezTabelePracownikow();
        }
        private void OdswiezTabelePracownikow()
        {
            string query = "SELECT Id_pracownika, Data_zatrudnienia, Id_osoby, Pensja FROM Pracownicy";

            using (MySqlConnection connection = db.GetConnection())
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        connection.Open();
                        adapter.Fill(dt);

                        dataGridView1.AutoGenerateColumns = false;

                        dataGridView1.Columns["ID_Pracownika"].DataPropertyName = "Id_pracownika";
                        dataGridView1.Columns["Data_Zatrudnienia"].DataPropertyName = "Data_zatrudnienia";
                        dataGridView1.Columns["ID_Osoby"].DataPropertyName = "Id_osoby";
                        dataGridView1.Columns["Pensja"].DataPropertyName = "Pensja";

                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd podczas ładowania danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola (ID Osoby oraz Pensję).", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out int idOsoby))
            {
                MessageBox.Show("ID Osoby musi być liczbą całkowitą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox2.Text, out decimal pensja))
            {
                MessageBox.Show("Pensja musi być poprawną liczbą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dataZatrudnienia = dateTimePicker1.Value;
            string query = "INSERT INTO Pracownicy (Id_osoby, Data_zatrudnienia, Pensja) VALUES (@idOsoby, @dataZatrudnienia, @pensja)";

            using (MySqlConnection connection = db.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idOsoby", idOsoby);
                    command.Parameters.AddWithValue("@dataZatrudnienia", dataZatrudnienia.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@pensja", pensja);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Pracownik został pomyślnie dodany do bazy!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            textBox2.Clear();
                            dateTimePicker1.Value = DateTime.Now;

                            OdswiezTabelePracownikow();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Błąd bazy danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił nieoczekiwany błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form_Admin formAdmin = new Form_Admin();
            formAdmin.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}
