using MySql.Data.MySqlClient;
using Panele_Glowne;
using System;
using System.Data;
using System.Windows.Forms;

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
            string query = @"
                SELECT p.Id_pracownika, o.Imie, o.Nazwisko, u.Rola, p.Data_zatrudnienia, p.Pensja 
                FROM Pracownicy p
                JOIN osoby o ON p.Id_osoby = o.Id
                LEFT JOIN Uzytkownicy u ON o.Id = u.Id_osoby";

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
                        dataGridView1.Columns["Imie"].DataPropertyName = "Imie";
                        dataGridView1.Columns["Nazwisko"].DataPropertyName = "Nazwisko";
                        dataGridView1.Columns["rola"].DataPropertyName = "Rola";
                        dataGridView1.Columns["Data_Zatrudnienia"].DataPropertyName = "Data_zatrudnienia";
                        dataGridView1.Columns["Pensja"].DataPropertyName = "Pensja";

                        dataGridView1.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Błąd podczas ładowania danych do tabeli: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imie = textBox1.Text.Trim();
            string nazwisko = textBox2.Text.Trim();
            string rola = comboBox1.SelectedItem?.ToString() ?? "";
            string login = textBox4.Text.Trim();
            string haslo = textBox5.Text.Trim();
            string pensjaRaw = textBox3.Text.Trim();

            // POBRANIE PINU (Upewnij się, że Twoje pole to textBox6)
            string pin = textBox6.Text.Trim();

            // Sprawdzenie, czy żadne pole nie jest puste
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) ||
                string.IsNullOrWhiteSpace(rola) || string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(haslo) || string.IsNullOrWhiteSpace(pensjaRaw) ||
                string.IsNullOrWhiteSpace(pin))
            {
                MessageBox.Show("Uzupełnij wszystkie pola, zanim dodasz pracownika!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Walidacja Pensji
            if (!decimal.TryParse(pensjaRaw, out decimal pensja))
            {
                MessageBox.Show("Pensja musi być liczbą!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Walidacja PIN-u (Dokładnie 4 cyfry)
            int parsedPin;
            if (pin.Length != 4 || !int.TryParse(pin, out parsedPin))
            {
                MessageBox.Show("PIN musi składać się dokładnie z 4 cyfr!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dataZatrudnienia = dateTimePicker1.Value;

            string insertOsoba = "INSERT INTO osoby (Imie, Nazwisko) VALUES (@imie, @nazwisko); SELECT LAST_INSERT_ID();";
            string insertPracownik = "INSERT INTO Pracownicy (Id_osoby, Data_zatrudnienia, Pensja) VALUES (@idOsoby, @dataZatrudnienia, @pensja);";

            // Dodano kolumnę PIN do zapytania Uzytkownicy (dostosuj nazwę kolumny 'PIN' jeśli w bazie nazywa się inaczej)
            string insertUzytkownik = "INSERT INTO Uzytkownicy (Login, Haslo, Rola, Id_osoby, PIN) VALUES (@login, @haslo, @rola, @idOsoby, @pin);";

            using (MySqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        int idOsoby = 0;

                        using (MySqlCommand cmdOsoba = new MySqlCommand(insertOsoba, connection, transaction))
                        {
                            cmdOsoba.Parameters.AddWithValue("@imie", imie);
                            cmdOsoba.Parameters.AddWithValue("@nazwisko", nazwisko);
                            idOsoby = Convert.ToInt32(cmdOsoba.ExecuteScalar());
                        }

                        using (MySqlCommand cmdPracownik = new MySqlCommand(insertPracownik, connection, transaction))
                        {
                            cmdPracownik.Parameters.AddWithValue("@idOsoby", idOsoby);
                            cmdPracownik.Parameters.AddWithValue("@dataZatrudnienia", dataZatrudnienia.ToString("yyyy-MM-dd"));
                            cmdPracownik.Parameters.AddWithValue("@pensja", pensja);
                            cmdPracownik.ExecuteNonQuery();
                        }

                        using (MySqlCommand cmdUzytkownik = new MySqlCommand(insertUzytkownik, connection, transaction))
                        {
                            cmdUzytkownik.Parameters.AddWithValue("@login", login);
                            cmdUzytkownik.Parameters.AddWithValue("@haslo", haslo);
                            cmdUzytkownik.Parameters.AddWithValue("@rola", rola);
                            cmdUzytkownik.Parameters.AddWithValue("@idOsoby", idOsoby);

                            // Dodanie parametru PIN do zapytania
                            cmdUzytkownik.Parameters.AddWithValue("@pin", pin);

                            cmdUzytkownik.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Pracownik oraz jego konto zostały pomyślnie dodane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();

                        // Czyszczenie pola PIN po dodaniu
                        textBox6.Clear();

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
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}