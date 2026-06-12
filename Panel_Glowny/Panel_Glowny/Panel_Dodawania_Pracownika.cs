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
                SELECT p.IdPracownika, p.Imie, p.Nazwisko, k.Rola, p.DataZatrudnienia, p.Pensja 
                FROM Pracownicy p
                LEFT JOIN Konta k ON p.IdKonta = k.IdKonta";

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

                        dataGridView1.Columns["ID_Pracownika"].DataPropertyName = "IdPracownika";
                        dataGridView1.Columns["Imie"].DataPropertyName = "Imie";
                        dataGridView1.Columns["Nazwisko"].DataPropertyName = "Nazwisko";
                        dataGridView1.Columns["rola"].DataPropertyName = "Rola";
                        dataGridView1.Columns["Data_Zatrudnienia"].DataPropertyName = "DataZatrudnienia";
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
            string pin = textBox6.Text.Trim();

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko) ||
                string.IsNullOrWhiteSpace(rola) || string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(haslo) || string.IsNullOrWhiteSpace(pensjaRaw) ||
                string.IsNullOrWhiteSpace(pin))
            {
                MessageBox.Show("Uzupełnij wszystkie pola, zanim dodasz pracownika!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(pensjaRaw, out decimal pensja))
            {
                MessageBox.Show("Pensja musi być liczbą!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int parsedPin;
            if (pin.Length != 4 || !int.TryParse(pin, out parsedPin))
            {
                MessageBox.Show("PIN musi składać się dokładnie z 4 cyfr!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime dataZatrudnienia = dateTimePicker1.Value;

            string insertKonto = "INSERT INTO Konta (Login, HasloHash, Rola, Aktywne, PIN) VALUES (@login, @haslo, @rola, 1, @pin); SELECT LAST_INSERT_ID();";
            string insertPracownik = "INSERT INTO Pracownicy (IdKonta, Imie, Nazwisko, DataZatrudnienia, Pensja) VALUES (@idKonta, @imie, @nazwisko, @dataZatrudnienia, @pensja);";

            using (MySqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        int idKonta = 0;

                        using (MySqlCommand cmdKonto = new MySqlCommand(insertKonto, connection, transaction))
                        {
                            cmdKonto.Parameters.AddWithValue("@login", login);
                            cmdKonto.Parameters.AddWithValue("@haslo", haslo);
                            cmdKonto.Parameters.AddWithValue("@rola", rola);
                            cmdKonto.Parameters.AddWithValue("@pin", pin);

                            idKonta = Convert.ToInt32(cmdKonto.ExecuteScalar());
                        }

                        using (MySqlCommand cmdPracownik = new MySqlCommand(insertPracownik, connection, transaction))
                        {
                            cmdPracownik.Parameters.AddWithValue("@idKonta", idKonta);
                            cmdPracownik.Parameters.AddWithValue("@imie", imie);
                            cmdPracownik.Parameters.AddWithValue("@nazwisko", nazwisko);
                            cmdPracownik.Parameters.AddWithValue("@dataZatrudnienia", dataZatrudnienia.ToString("yyyy-MM-dd"));
                            cmdPracownik.Parameters.AddWithValue("@pensja", pensja);

                            cmdPracownik.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Pracownik oraz jego konto zostały pomyślnie dodane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć pracownika do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPracownika = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Pracownika"].Value);

            DialogResult confirm = MessageBox.Show(
                $"Czy na pewno chcesz usunąć pracownika o ID {idPracownika} oraz jego konto?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            using (MySqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        int idKonta = 0;
                        string selectIdKonta = "SELECT IdKonta FROM Pracownicy WHERE IdPracownika = @idPracownika";
                        using (MySqlCommand cmdSelect = new MySqlCommand(selectIdKonta, connection, transaction))
                        {
                            cmdSelect.Parameters.AddWithValue("@idPracownika", idPracownika);
                            var result = cmdSelect.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                idKonta = Convert.ToInt32(result);
                            }
                        }

                        string deletePracownik = "DELETE FROM Pracownicy WHERE IdPracownika = @idPracownika";
                        using (MySqlCommand cmdPracownik = new MySqlCommand(deletePracownik, connection, transaction))
                        {
                            cmdPracownik.Parameters.AddWithValue("@idPracownika", idPracownika);
                            cmdPracownik.ExecuteNonQuery();
                        }

                        if (idKonta > 0)
                        {
                            string deleteKonto = "DELETE FROM Konta WHERE IdKonta = @idKonta";
                            using (MySqlCommand cmdKonto = new MySqlCommand(deleteKonto, connection, transaction))
                            {
                                cmdKonto.Parameters.AddWithValue("@idKonta", idKonta);
                                cmdKonto.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Pracownik został pomyślnie usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OdswiezTabelePracownikow();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Błąd bazy danych przy usuwaniu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void textBox5_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Sprawdzenie, czy użytkownik zaznaczył jakikolwiek wiersz w tabeli
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć pracownika do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pobranie IdPracownika z zaznaczonego wiersza
            int idPracownika = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Pracownika"].Value);

            DialogResult confirm = MessageBox.Show(
                $"Czy na pewno chcesz usunąć pracownika o ID {idPracownika} oraz jego konto?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            using (MySqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        int idKonta = 0;

                        // 1. Pobieramy IdKonta z tabeli Pracownicy, aby usunąć powiązane konto
                        string selectIdKonta = "SELECT IdKonta FROM Pracownicy WHERE IdPracownika = @idPracownika";
                        using (MySqlCommand cmdSelect = new MySqlCommand(selectIdKonta, connection, transaction))
                        {
                            cmdSelect.Parameters.AddWithValue("@idPracownika", idPracownika);
                            var result = cmdSelect.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                idKonta = Convert.ToInt32(result);
                            }
                        }

                        // 2. Usunięcie wpisu z tabeli Pracownicy
                        string deletePracownik = "DELETE FROM Pracownicy WHERE IdPracownika = @idPracownika";
                        using (MySqlCommand cmdPracownik = new MySqlCommand(deletePracownik, connection, transaction))
                        {
                            cmdPracownik.Parameters.AddWithValue("@idPracownika", idPracownika);
                            cmdPracownik.ExecuteNonQuery();
                        }

                        // 3. Usunięcie powiązanego konta z tabeli Konta
                        if (idKonta > 0)
                        {
                            string deleteKonto = "DELETE FROM Konta WHERE IdKonta = @idKonta";
                            using (MySqlCommand cmdKonto = new MySqlCommand(deleteKonto, connection, transaction))
                            {
                                cmdKonto.Parameters.AddWithValue("@idKonta", idKonta);
                                cmdKonto.ExecuteNonQuery();
                            }
                        }

                        // Zatwierdzenie zmian
                        transaction.Commit();
                        MessageBox.Show("Pracownik oraz jego konto zostali pomyślnie usunięci.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Odświeżenie tabeli, aby usunięty pracownik zniknął z ekranu
                        OdswiezTabelePracownikow();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Błąd bazy danych przy usuwaniu: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}