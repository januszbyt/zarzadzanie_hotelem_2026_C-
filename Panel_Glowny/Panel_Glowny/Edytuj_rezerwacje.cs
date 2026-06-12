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

        //PRZELICZANIE KWOT

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
                            o.Imie, o.Nazwisko, k.Email, 
                            r.DataPrzyjazdu, r.DataWyjazdu, r.LiczbaNocy, r.KwotaLaczna, 
                            p.TypPokoju, p.IloscOsob
                        FROM Rezerwacje r
                        JOIN Klienci k ON r.IdKlienta = k.IdKlienta
                        JOIN osoby o ON k.Id_osoby = o.Id
                        JOIN Pokoje p ON r.IdPokoju = p.IdPokoju
                        WHERE r.IdRezerwacji = @id;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idEdytowanejRezerwacji);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ImieOld.Text = reader["Imie"].ToString();
                                NazwiskoOld.Text = reader["Nazwisko"].ToString();
                                emailOld.Text = reader["Email"].ToString();

                                PrzyjazdOld.Value = Convert.ToDateTime(reader["DataPrzyjazdu"]);
                                WyjazdOld.Value = Convert.ToDateTime(reader["DataWyjazdu"]);

                                NoceOld.Text = reader["LiczbaNocy"].ToString();
                                KwotaOld.Text = reader["KwotaLaczna"].ToString();
                                osobyOld.Text = reader["IloscOsob"].ToString();
                                typPokojuOld.Text = reader["TypPokoju"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych rezerwacji:\n" + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        

        private void powrot_Click(object sender, EventArgs e)
        {
            Okno_Rezerwacji_Obslugiwane_Przez_Pracownika powrotOkna = new Okno_Rezerwacji_Obslugiwane_Przez_Pracownika();
            powrotOkna.Show();
            this.Hide();
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imieNew.Text) || string.IsNullOrWhiteSpace(nazwiskoNew.Text) || string.IsNullOrWhiteSpace(emailNew.Text))
            {
                MessageBox.Show("Proszę wypełnić sekcję 'Nowe wartości' (imię, nazwisko, email).", "Braki w formularzu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    string findPokoj = @"
                        SELECT IdPokoju 
                        FROM Pokoje 
                        WHERE TypPokoju = @typ 
                          AND IloscOsob >= @osoby 
                          AND IdPokoju NOT IN (
                              SELECT IdPokoju 
                              FROM Rezerwacje 
                              WHERE StatusRezerwacji = 'Aktywna'
                                AND IdRezerwacji != @idAktualnejRezerwacji
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
                    cmdPokoj.Parameters.AddWithValue("@idAktualnejRezerwacji", idEdytowanejRezerwacji);

                    object wynikPokoj = cmdPokoj.ExecuteScalar();

                    if (wynikPokoj == null)
                    {
                        MessageBox.Show($"Niestety w wybranym nowym terminie nie ma wolnego pokoju {typPokoju} dla {iloscOsob} osób.", "Brak wolnych pokoi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int noweIdPokoju = Convert.ToInt32(wynikPokoj);

                    string getIdsQuery = "SELECT k.IdKlienta, k.Id_osoby FROM Rezerwacje r JOIN Klienci k ON r.IdKlienta = k.IdKlienta WHERE r.IdRezerwacji = @idRez;";
                    MySqlCommand cmdIds = new MySqlCommand(getIdsQuery, conn);
                    cmdIds.Parameters.AddWithValue("@idRez", idEdytowanejRezerwacji);

                    int idKlienta = 0;
                    int idOsoby = 0;
                    using (MySqlDataReader reader = cmdIds.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idKlienta = Convert.ToInt32(reader["IdKlienta"]);
                            idOsoby = Convert.ToInt32(reader["Id_osoby"]);
                        }
                    }

                    string updateOsoba = "UPDATE osoby SET Imie = @imie, Nazwisko = @nazwisko WHERE Id = @idOsoba;";
                    MySqlCommand cmdOsoba = new MySqlCommand(updateOsoba, conn);
                    cmdOsoba.Parameters.AddWithValue("@imie", imieNew.Text);
                    cmdOsoba.Parameters.AddWithValue("@nazwisko", nazwiskoNew.Text);
                    cmdOsoba.Parameters.AddWithValue("@idOsoba", idOsoby);
                    cmdOsoba.ExecuteNonQuery();

                    string updateKlient = "UPDATE Klienci SET Email = @email WHERE IdKlienta = @idKlienta;";
                    MySqlCommand cmdKlient = new MySqlCommand(updateKlient, conn);
                    cmdKlient.Parameters.AddWithValue("@email", emailNew.Text);
                    cmdKlient.Parameters.AddWithValue("@idKlienta", idKlienta);
                    cmdKlient.ExecuteNonQuery();

                    string updateRezerwacja = @"
                        UPDATE Rezerwacje 
                        SET IdPokoju = @idPokoj, DataPrzyjazdu = @przyjazd, DataWyjazdu = @wyjazd, LiczbaNocy = @noce, KwotaLaczna = @kwota 
                        WHERE IdRezerwacji = @idRez;";
                    MySqlCommand cmdRez = new MySqlCommand(updateRezerwacja, conn);
                    cmdRez.Parameters.AddWithValue("@idPokoj", noweIdPokoju);
                    cmdRez.Parameters.AddWithValue("@przyjazd", dataPrzyjazduSQL);
                    cmdRez.Parameters.AddWithValue("@wyjazd", dataOdjazduSQL);
                    cmdRez.Parameters.AddWithValue("@noce", noc);
                    cmdRez.Parameters.AddWithValue("@kwota", cena);
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