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
using MySql.Data.MySqlClient; // Dodana biblioteka do obsługi MySQL

namespace Panele_Glowne
{
    public partial class Panel_Przypisania_Goscia_DoRezerwacji : Form
    {
        private DataGridViewRow? _edytowanyWiersz = null;

        public Panel_Przypisania_Goscia_DoRezerwacji()
        {
            InitializeComponent();
            button7.Location = button1.Location; // Ustawia "Zatwierdź" dokładnie w miejscu "Dodaj"
            button7.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Wywołanie metody pobierającej dane z bazy przy starcie okna
            WczytajGosci();
        }

        // --- NOWA METODA DO POBIERANIA DANYCH ---
        private void WczytajGosci()
        {
            dataGridView1.Rows.Clear(); // Czyszczenie tabeli przed załadowaniem

            HotelContext db = new HotelContext();

            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Zapytanie SQL łączące tabele Klienci i osoby
                    string query = @"
                        SELECT 
                            k.IdKlienta, 
                            o.Imie, 
                            o.Nazwisko, 
                            k.NumerTelefonu, 
                            k.Email
                        FROM Klienci k
                        INNER JOIN osoby o ON k.Id_osoby = o.Id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader["IdKlienta"].ToString();
                        string imie = reader["Imie"].ToString();
                        string nazwisko = reader["Nazwisko"].ToString();
                        string telefon = reader["NumerTelefonu"].ToString();
                        string email = reader["Email"].ToString();

                        // Zmienna na liczbę rezerwacji - na razie sztywne 0
                        string liczbaRezerwacji = "0";

                        // Dodawanie wiersza do tabeli
                        dataGridView1.Rows.Add(id, imie, nazwisko, telefon, email, liczbaRezerwacji);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd pobierania danych z bazy: " + ex.Message);
                }
            }
        }
        // -----------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sprawdzamy, czy w ogóle kogoś zaznaczyłeś
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Zaznacz najpierw gościa, żeby sprawdzić jego historię!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pobieramy ID gościa z pierwszej kolumny zaznaczonego wiersza
            int wybraneIdKlienta = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            // Przekazujemy to ID do drugiego okna
            Panel_Informacji_Histori_Pobytu HistoriaGoscia2 = new Panel_Informacji_Histori_Pobytu(wybraneIdKlienta);
            HistoriaGoscia2.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e) // PRZYCISK EDYTUJ
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Zaznacz wiersz do edycji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            textBox1.Text = row.Cells[1].Value?.ToString() ?? ""; // Imię
            textBox2.Text = row.Cells[2].Value?.ToString() ?? ""; // Nazwisko
            textBox3.Text = row.Cells[3].Value?.ToString() ?? ""; // NrTelefonu
            textBox4.Text = row.Cells[4].Value?.ToString() ?? ""; // Email
            textBox5.Text = row.Cells[5].Value?.ToString() ?? ""; // Liczba rezerwacji

            _edytowanyWiersz = row;
            button7.Visible = true;  // ← POKAŻ ZATWIERDŹ
            button1.Visible = false; // ← UKRYJ DODAJ
        }

        private void button4_Click(object sender, EventArgs e) // PRZYCISK WYCZYŚĆ
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

        private void button3_Click(object sender, EventArgs e) // PRZYCISK USUŃ
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Zaznacz wiersz do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult wynik = MessageBox.Show("Czy na pewno chcesz usunąć tego gościa?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (wynik == DialogResult.Yes)
            {
                // Pobieramy ID Klienta z pierwszej kolumny (indeks 0)
                string idKlienta = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                HotelContext db = new HotelContext();
                using (var conn = db.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // Najpierw pobieramy Id_osoby, żeby wiedzieć kogo usunąć
                        string querySelect = "SELECT Id_osoby FROM Klienci WHERE IdKlienta = @idKlienta";
                        MySqlCommand cmdSelect = new MySqlCommand(querySelect, conn);
                        cmdSelect.Parameters.AddWithValue("@idKlienta", idKlienta);
                        object result = cmdSelect.ExecuteScalar();

                        if (result != null)
                        {
                            int idOsoby = Convert.ToInt32(result);

                            // Usuwamy rekord z tabeli Klienci
                            string queryDelKlienci = "DELETE FROM Klienci WHERE IdKlienta = @idKlienta";
                            MySqlCommand cmdDelK = new MySqlCommand(queryDelKlienci, conn);
                            cmdDelK.Parameters.AddWithValue("@idKlienta", idKlienta);
                            cmdDelK.ExecuteNonQuery();

                            // Usuwamy powiązany rekord z tabeli osoby
                            string queryDelOsoby = "DELETE FROM osoby WHERE Id = @idOsoby";
                            MySqlCommand cmdDelO = new MySqlCommand(queryDelOsoby, conn);
                            cmdDelO.Parameters.AddWithValue("@idOsoby", idOsoby);
                            cmdDelO.ExecuteNonQuery();
                        }

                        // Odświeżamy tabelę na ekranie po pomyślnym usunięciu
                        WczytajGosci();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas usuwania: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) // PRZYCISK DODAJ
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

                    // 1. Dodajemy do tabeli 'osoby' i od razu pobieramy wygenerowane ID
                    string queryOsoby = "INSERT INTO osoby (Imie, Nazwisko) VALUES (@imie, @nazwisko); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdOsoby = new MySqlCommand(queryOsoby, conn);
                    cmdOsoby.Parameters.AddWithValue("@imie", textBox1.Text);
                    cmdOsoby.Parameters.AddWithValue("@nazwisko", textBox2.Text);

                    // ExecuteScalar zwraca pobrane ID
                    int idOsoby = Convert.ToInt32(cmdOsoby.ExecuteScalar());

                    // 2. Mając idOsoby, dodajemy wpis do tabeli 'Klienci'
                    string queryKlienci = "INSERT INTO Klienci (NumerTelefonu, Email, Id_osoby) VALUES (@telefon, @email, @idOsoby)";
                    MySqlCommand cmdKlienci = new MySqlCommand(queryKlienci, conn);
                    cmdKlienci.Parameters.AddWithValue("@telefon", textBox3.Text);
                    cmdKlienci.Parameters.AddWithValue("@email", textBox4.Text);
                    cmdKlienci.Parameters.AddWithValue("@idOsoby", idOsoby);

                    cmdKlienci.ExecuteNonQuery();

                    // Czyścimy pola tekstowe
                    textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear();

                    // Odświeżamy tabelę na ekranie, żeby pokazała nowego gościa
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

        private void button7_Click(object sender, EventArgs e) // PRZYCISK ZATWIERDŹ (AKTUALIZACJA)
        {
            if (_edytowanyWiersz != null)
            {
                // Pobieramy ID edytowanego klienta
                string idKlienta = _edytowanyWiersz.Cells[0].Value.ToString();

                HotelContext db = new HotelContext();
                using (var conn = db.GetConnection())
                {
                    try
                    {
                        conn.Open();

                        // Zapytanie aktualizujące jednocześnie tabele Klienci i osoby
                        string query = @"
                            UPDATE Klienci k
                            JOIN osoby o ON k.Id_osoby = o.Id
                            SET o.Imie = @imie, 
                                o.Nazwisko = @nazwisko, 
                                k.NumerTelefonu = @telefon, 
                                k.Email = @email
                            WHERE k.IdKlienta = @idKlienta";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@imie", textBox1.Text);
                        cmd.Parameters.AddWithValue("@nazwisko", textBox2.Text);
                        cmd.Parameters.AddWithValue("@telefon", textBox3.Text);
                        cmd.Parameters.AddWithValue("@email", textBox4.Text);
                        cmd.Parameters.AddWithValue("@idKlienta", idKlienta);

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas aktualizacji: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                _edytowanyWiersz = null;
            }

            // Resetowanie interfejsu
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            button7.Visible = false;
            button1.Visible = true;

            // Odświeżamy dane z bazy po aktualizacji
            WczytajGosci();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}