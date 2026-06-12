using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Panele_Glowne
{
    public partial class Edytuj_rezerwacje : Form
    {
        int idEdytowanejRezerwacji;

        int noc;
        int cena;

        public Edytuj_rezerwacje(int idRezerwacji)
        {
            InitializeComponent();
            idEdytowanejRezerwacji = idRezerwacji;

            przyjazdNew.MinDate = DateTime.MinValue;
            przyjazdNew.MaxDate = DateTime.MaxValue;
            wyjazdNew.MinDate = DateTime.MinValue;
            wyjazdNew.MaxDate = DateTime.MaxValue;

            przyjazdNew.Value = DateTime.Today;
            wyjazdNew.Value = DateTime.Today.AddDays(1);
            przyjazdNew.MinDate = DateTime.Today;

            WczytajStareDane();

            przyjazdNew.ValueChanged += przyjazdNew_ValueChanged;
            wyjazdNew.ValueChanged += wyjazdNew_ValueChanged;

            osobowy.SelectedIndexChanged += kwotaPokoi;
            Standard.CheckedChanged += kwotaPokoi;
            Deluxe.CheckedChanged += kwotaPokoi;

            przyjazdNew_ValueChanged(null, null);
        }

        public Edytuj_rezerwacje()
        {
            InitializeComponent();
        }

        // PRZELICZANIE KWOT

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

            kwotaNew.Text = cena.ToString();
        }

        private void przyjazdNew_ValueChanged(object sender, EventArgs e)
        {
            DateTime nowaMinimalnaDataOdjazdu = przyjazdNew.Value.AddDays(1);

            if (wyjazdNew.Value < nowaMinimalnaDataOdjazdu)
            {
                wyjazdNew.Value = nowaMinimalnaDataOdjazdu;
            }
            wyjazdNew.MinDate = nowaMinimalnaDataOdjazdu;

            noc = (wyjazdNew.Value - przyjazdNew.Value).Days;
            noce.Text = noc.ToString();
            kwotaPokoi(sender, e);
        }

        private void wyjazdNew_ValueChanged(object sender, EventArgs e)
        {
            noc = (wyjazdNew.Value - przyjazdNew.Value).Days;
            noce.Text = noc.ToString();
            kwotaPokoi(sender, e);
        }

        // BAZA DANYCH 

        private void WczytajStareDane()
        {
            HotelContext dbContext = new HotelContext();
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    g.Imie, g.Nazwisko, g.Email, g.Telefon, g.DokumentTozsamosci, 
                    r.DataPrzyjazdu, r.DataWyjazdu, r.KwotaCalkowita, r.Uwagi, 
                    p.TypPokoju, p.Pojemnosc
                FROM Rezerwacje r
                JOIN Goscie g ON r.IdGoscia = g.IdGoscia
                JOIN Pokoje p ON r.IdPokoju = p.IdPokoju
                WHERE r.IdRezerwacji = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idEdytowanejRezerwacji);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 1. Wypełnienie lewej strony (Stare wartości - tylko do odczytu)
                                ImieOld.Text = reader["Imie"].ToString();
                                NazwiskoOld.Text = reader["Nazwisko"].ToString();
                                emailOld.Text = reader["Email"].ToString();
                                telefonOld.Text = reader["Telefon"].ToString();
                                dokumentOld.Text = reader["DokumentTozsamosci"] != DBNull.Value ? reader["DokumentTozsamosci"].ToString() : "";
                                uwagiOld.Text = reader["Uwagi"] != DBNull.Value ? reader["Uwagi"].ToString() : "";

                                PrzyjazdOld.Value = Convert.ToDateTime(reader["DataPrzyjazdu"]);
                                WyjazdOld.Value = Convert.ToDateTime(reader["DataWyjazdu"]);

                                int stareNoce = (WyjazdOld.Value - PrzyjazdOld.Value).Days;
                                NoceOld.Text = stareNoce.ToString();
                                KwotaOld.Text = reader["KwotaCalkowita"].ToString();
                                osobyOld.Text = reader["Pojemnosc"].ToString();
                                typPokojuOld.Text = reader["TypPokoju"].ToString();

                                // 2. Wypełnienie prawej strony (Nowe wartości - kopia startowa)
                                imieNew.Text = ImieOld.Text;
                                nazwiskoNew.Text = NazwiskoOld.Text;
                                emailNew.Text = emailOld.Text;
                                telefonNew.Text = telefonOld.Text;
                                dokumentNew.Text = dokumentOld.Text;
                                uwagiNew.Text = uwagiOld.Text;

                                przyjazdNew.Value = PrzyjazdOld.Value;
                                wyjazdNew.Value = WyjazdOld.Value;
                                noce.Text = NoceOld.Text;
                                osobowy.Text = osobyOld.Text;
                                kwotaNew.Text = KwotaOld.Text;

                                // Ustawienie typu pokoju
                                if (typPokojuOld.Text == "Standard") Standard.Checked = true;
                                else Deluxe.Checked = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }
        private void powrot_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            // Zmodyfikowana walidacja o dodane pola
            if (string.IsNullOrWhiteSpace(imieNew.Text) || string.IsNullOrWhiteSpace(nazwiskoNew.Text) || string.IsNullOrWhiteSpace(emailNew.Text) || string.IsNullOrWhiteSpace(telefonNew.Text))
            {
                MessageBox.Show("Proszę wypełnić wymagane pola w sekcji 'Nowe wartości' (imię, nazwisko, email, telefon).", "Braki w formularzu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(osobowy.Text, out int iloscOsob))
            {
                iloscOsob = 1;
            }
            string typPokoju = Standard.Checked ? "Standard" : "Deluxe";
            string dataPrzyjazduSQL = przyjazdNew.Value.ToString("yyyy-MM-dd");
            string dataOdjazduSQL = wyjazdNew.Value.ToString("yyyy-MM-dd");

            HotelContext dbContext = new HotelContext();
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                try
                {
                    conn.Open();

                    // KROK 1: Sprawdzenie dostępności pokoju (z użyciem Pojemnosc)
                    string findPokoj = @"
                        SELECT IdPokoju 
                        FROM Pokoje 
                        WHERE TypPokoju = @typ 
                          AND Pojemnosc >= @osoby 
                          AND IdPokoju NOT IN (
                              SELECT IdPokoju 
                              FROM Rezerwacje 
                              WHERE StatusRezerwacji != 'Anulowana'
                                AND IdRezerwacji != @idAktualnejRezerwacji
                                AND DataPrzyjazdu < @wyjazd 
                                AND DataWyjazdu > @przyjazd
                          )
                        ORDER BY Pojemnosc ASC 
                        LIMIT 1;";

                    MySqlCommand cmdPokoj = new MySqlCommand(findPokoj, conn);
                    cmdPokoj.Parameters.AddWithValue("@typ", typPokoju);
                    cmdPokoj.Parameters.AddWithValue("@osoby", iloscOsob);
                    cmdPokoj.Parameters.AddWithValue("@przyjazd", dataPrzyjazduSQL);
                    cmdPokoj.Parameters.AddWithValue("@wyjazd", dataOdjazduSQL);
                    cmdPokoj.Parameters.AddWithValue("@idAktualnejRezerwacji", idEdytowanejRezerwacji);

                    object wynikPokoj = cmdPokoj.ExecuteScalar();

                    if (wynikPokoj == null)
                    {
                        MessageBox.Show($"Niestety w wybranym nowym terminie nie ma wolnego pokoju {typPokoju} dla {iloscOsob} osób.", "Brak wolnych pokoi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int noweIdPokoju = Convert.ToInt32(wynikPokoj);

                    // KROK 2: Pobranie IdGoscia dla tej rezerwacji
                    string getIdGosciaQuery = "SELECT IdGoscia FROM Rezerwacje WHERE IdRezerwacji = @idRez;";
                    MySqlCommand cmdIds = new MySqlCommand(getIdGosciaQuery, conn);
                    cmdIds.Parameters.AddWithValue("@idRez", idEdytowanejRezerwacji);

                    int idGoscia = Convert.ToInt32(cmdIds.ExecuteScalar());

                    // KROK 3: Aktualizacja danych w tabeli Goscie
                    string updateGosc = "UPDATE Goscie SET Imie = @imie, Nazwisko = @nazwisko, Email = @email, Telefon = @telefon, DokumentTozsamosci = @dokument WHERE IdGoscia = @idGoscia;";
                    MySqlCommand cmdGosc = new MySqlCommand(updateGosc, conn);
                    cmdGosc.Parameters.AddWithValue("@imie", imieNew.Text);
                    cmdGosc.Parameters.AddWithValue("@nazwisko", nazwiskoNew.Text);
                    cmdGosc.Parameters.AddWithValue("@email", emailNew.Text);
                    cmdGosc.Parameters.AddWithValue("@telefon", telefonNew.Text);
                    cmdGosc.Parameters.AddWithValue("@dokument", string.IsNullOrWhiteSpace(dokumentNew.Text) ? DBNull.Value : (object)dokumentNew.Text);
                    cmdGosc.Parameters.AddWithValue("@idGoscia", idGoscia);
                    cmdGosc.ExecuteNonQuery();

                    // KROK 4: Aktualizacja danych w tabeli Rezerwacje
                    string updateRezerwacja = @"
                        UPDATE Rezerwacje 
                        SET IdPokoju = @idPokoj, DataPrzyjazdu = @przyjazd, DataWyjazdu = @wyjazd, KwotaCalkowita = @kwota, Uwagi = @uwagi 
                        WHERE IdRezerwacji = @idRez;";
                    MySqlCommand cmdRez = new MySqlCommand(updateRezerwacja, conn);
                    cmdRez.Parameters.AddWithValue("@idPokoj", noweIdPokoju);
                    cmdRez.Parameters.AddWithValue("@przyjazd", dataPrzyjazduSQL);
                    cmdRez.Parameters.AddWithValue("@wyjazd", dataOdjazduSQL);
                    cmdRez.Parameters.AddWithValue("@kwota", cena);
                    cmdRez.Parameters.AddWithValue("@uwagi", string.IsNullOrWhiteSpace(uwagiNew.Text) ? DBNull.Value : (object)uwagiNew.Text);
                    cmdRez.Parameters.AddWithValue("@idRez", idEdytowanejRezerwacji);
                    cmdRez.ExecuteNonQuery();

                    MessageBox.Show("Rezerwacja została pomyślnie zaktualizowana!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    powrot_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas aktualizacji: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}