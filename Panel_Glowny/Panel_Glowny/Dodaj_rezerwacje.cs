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
    public partial class Dodaj_rezerwacje : Form
    {
        int noc;
        int cena;
        

        public Dodaj_rezerwacje()
        {

            InitializeComponent();
            przyjazd.MinDate = DateTime.Today;

            noc = (odjazd.Value - przyjazd.Value).Days;
            noce.Text = noc.ToString();

            int.TryParse(osobowy.Text, out int iloscOsob);

            if (Standard.Checked)
            {
                cena = 300 * noc + (iloscOsob-1)*50;
            }
            else if (Deluxe.Checked)
            {
                cena = 600 * noc + (iloscOsob - 1) * 100;
            }

            kwota.Text = cena.ToString();


        }

        private void kwotaPokoi(object sender, EventArgs e)
        {
            int.TryParse(osobowy.Text, out int iloscOsob);

            if (Standard.Checked)
            {
                cena = 300 * noc + (iloscOsob - 1) * 50;
            }
            else if (Deluxe.Checked)
            {
                cena = 600 * noc + (iloscOsob - 1) * 100;
            }

            kwota.Text = cena.ToString();
        }
        private void przyjazd_ValueChanged(object sender, EventArgs e)
        {

            DateTime nowaMinimalnaDataOdjazdu = przyjazd.Value.AddDays(1);

            if (odjazd.Value < nowaMinimalnaDataOdjazdu)
            {
                odjazd.Value = nowaMinimalnaDataOdjazdu;
            }
            odjazd.MinDate = nowaMinimalnaDataOdjazdu;

            noc = (odjazd.Value - przyjazd.Value).Days;
            noce.Text = noc.ToString();
            kwotaPokoi(sender, e);
        }

        private void Odjazd_noce_ValueChanged(object sender, EventArgs e)
        {
            noc = (odjazd.Value - przyjazd.Value).Days;
            noce.Text = noc.ToString();
            kwotaPokoi(sender, e);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Okno_Rezerwacji_Obslugiwane_Przez_Pracownika powrot = new Okno_Rezerwacji_Obslugiwane_Przez_Pracownika();
            powrot.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            // 1. Prosta walidacja - sprawdzamy, czy użytkownik wypełnił najważniejsze pola
            if (string.IsNullOrWhiteSpace(imie.Text) || string.IsNullOrWhiteSpace(nazwisko.Text) || string.IsNullOrWhiteSpace(email.Text))
            {
                MessageBox.Show("Proszę wypełnić imię, nazwisko i e-mail gościa.", "Braki w formularzu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Pobranie danych z kontrolek
            string imieGo = imie.Text;
            string nazwiskoGo = nazwisko.Text;
            string emailGo = email.Text;

            if (!int.TryParse(osobowy.Text, out int iloscOsob))
            {
                iloscOsob = 1;
            }

            string typPokoju = Standard.Checked ? "Standard" : "Deluxe";
            string dataPrzyjazduSQL = przyjazd.Value.ToString("yyyy-MM-dd");
            string dataOdjazduSQL = odjazd.Value.ToString("yyyy-MM-dd");

            // 3. POŁĄCZENIE Z WYKORZYSTANIEM TWOJEJ KLASY HotelContext
            HotelContext dbContext = new HotelContext();

            // Pobieramy gotowe połączenie z Twojego pliku konfiguracyjnego
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                try
                {
                    conn.Open();

                    // KROK 1: Szukamy WOLNEGO pokoju 
                    string findPokoj = @"
                SELECT IdPokoju 
                FROM Pokoje 
                WHERE TypPokoju = @typ 
                  AND IloscOsob >= @osoby 
                  AND IdPokoju NOT IN (
                      SELECT IdPokoju 
                      FROM Rezerwacje 
                      WHERE StatusRezerwacji = 'Aktywna'
                        AND DataPrzyjazdu < @wyjazd 
                        AND DataWyjazdu > @przyjazd
                  )
                ORDER BY IloscOsob ASC 
                LIMIT 1;";

                    MySqlCommand cmdPokoj = new MySqlCommand(findPokoj, conn);
                    cmdPokoj.Parameters.AddWithValue("@typ", typPokoju);
                    cmdPokoj.Parameters.AddWithValue("@osoby", iloscOsob);
                    cmdPokoj.Parameters.AddWithValue("@przyjazd", dataPrzyjazduSQL);
                    cmdPokoj.Parameters.AddWithValue("@wyjazd", dataOdjazduSQL);

                    object wynikPokoj = cmdPokoj.ExecuteScalar();

                    if (wynikPokoj == null)
                    {
                        MessageBox.Show($"Niestety w podanym terminie nie ma wolnego pokoju typu {typPokoju} dla {iloscOsob} (lub więcej) osób.", "Brak wolnych pokoi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int idPokoju = Convert.ToInt32(wynikPokoj);

                    // KROK 2: Zapisanie nowej Osoby w bazie
                    string insertOsoba = "INSERT INTO osoby (Imie, Nazwisko) VALUES (@imie, @nazwisko); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdOsoba = new MySqlCommand(insertOsoba, conn);
                    cmdOsoba.Parameters.AddWithValue("@imie", imieGo);
                    cmdOsoba.Parameters.AddWithValue("@nazwisko", nazwiskoGo);
                    int idOsoby = Convert.ToInt32(cmdOsoba.ExecuteScalar());

                    // KROK 3: Zapisanie Klienta (telefon jako NULL)
                    string insertKlient = "INSERT INTO Klienci (NumerTelefonu, Email, Id_osoby) VALUES (@telefon, @email, @idOsoby); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdKlient = new MySqlCommand(insertKlient, conn);
                    cmdKlient.Parameters.AddWithValue("@telefon", DBNull.Value);
                    cmdKlient.Parameters.AddWithValue("@email", emailGo);
                    cmdKlient.Parameters.AddWithValue("@idOsoby", idOsoby);
                    int idKlienta = Convert.ToInt32(cmdKlient.ExecuteScalar());

                    // KROK 4: Zapisanie Rezerwacji 
                    string insertRezerwacja = @"INSERT INTO Rezerwacje (IdKlienta, IdPokoju, DataPrzyjazdu, DataWyjazdu, LiczbaNocy, KwotaLaczna, StatusRezerwacji) 
                                        VALUES (@idKlient, @idPokoj, @przyjazd, @wyjazd, @noce, @kwota, 'Aktywna');";
                    MySqlCommand cmdRez = new MySqlCommand(insertRezerwacja, conn);
                    cmdRez.Parameters.AddWithValue("@idKlient", idKlienta);
                    cmdRez.Parameters.AddWithValue("@idPokoj", idPokoju);
                    cmdRez.Parameters.AddWithValue("@przyjazd", dataPrzyjazduSQL);
                    cmdRez.Parameters.AddWithValue("@wyjazd", dataOdjazduSQL);

                    // Używamy zmiennych z klasy, które same się przeliczają po kliknięciu kontrolek
                    cmdRez.Parameters.AddWithValue("@noce", noc);
                    cmdRez.Parameters.AddWithValue("@kwota", cena);

                    cmdRez.ExecuteNonQuery();

                    MessageBox.Show("Rezerwacja została pomyślnie dodana do bazy!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas łączenia z bazą danych:\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
