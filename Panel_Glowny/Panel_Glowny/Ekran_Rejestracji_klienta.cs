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
    public partial class Ekran_Rejestracji_klienta : Form
    {
        private HotelContext db = new HotelContext();

        public Ekran_Rejestracji_klienta()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ekran_Logowania_Klienta powrotDoLogowania = new Ekran_Logowania_Klienta();
            powrotDoLogowania.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text.Trim();
            string haslo = textBox2.Text;
            string powtorzHaslo = textBox3.Text;
            string pin = textBox4.Text.Trim();

            int przypisaneIdOsoby = 1;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(haslo) ||
                string.IsNullOrWhiteSpace(powtorzHaslo) || string.IsNullOrWhiteSpace(pin))
            {
                MessageBox.Show("Proszę uzupełnić wszystkie pola, w tym PIN pomocniczy.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (haslo != powtorzHaslo)
            {
                MessageBox.Show("Wprowadzone hasła nie są identyczne", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (login.Length < 3 || haslo.Length < 4)
            {
                MessageBox.Show("Login musi mieć min. 3 znaki, a hasło min. 4 znaki.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pin.Length != 4 || !int.TryParse(pin, out _))
            {
                MessageBox.Show("PIN pomocniczy musi składać się dokładnie z 4 cyfr (np. 1234).", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Uzytkownicy WHERE Login = @login";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@login", login);
                        int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (userExists > 0)
                        {
                            MessageBox.Show("Ten login jest już zajęty", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO Uzytkownicy (Login, Haslo, Rola, Id_osoby, Pin) VALUES (@login, @haslo, 'Klient', @idOsoby, @pin)";

                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@login", login);
                        insertCmd.Parameters.AddWithValue("@haslo", haslo);
                        insertCmd.Parameters.AddWithValue("@idOsoby", przypisaneIdOsoby);
                        insertCmd.Parameters.AddWithValue("@pin", pin);

                        int wynik = insertCmd.ExecuteNonQuery();

                        if (wynik > 0)
                        {
                            MessageBox.Show("Konto zostało utworzone pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Ekran_Logowania_Klienta powrotDoLogowania = new Ekran_Logowania_Klienta();
                            powrotDoLogowania.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd bazy danych podczas rejestracji: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
    }
}