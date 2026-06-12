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
                cena = 300 * noc + (iloscOsob - 1) * 50;
            }
            else if (Deluxe.Checked)
            {
                cena = 600 * noc + (iloscOsob - 1) * 100;
            }

            kwota.Text = cena.ToString();
            osobowy.Text = "1";

            this.email.Leave += new System.EventHandler(this.email_Leave);
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email.Text)) return;

            HotelContext dbContext = new HotelContext();
            using (MySqlConnection conn = dbContext.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Imie, Nazwisko, Telefon, DokumentTozsamosci FROM Goscie WHERE Email = @email LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email.Text.Trim());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                imie.Text = reader["Imie"].ToString();
                                nazwisko.Text = reader["Nazwisko"].ToString();
                                telefon.Text = reader["Telefon"].ToString();

                                dokument.Text = reader["DokumentTozsamosci"] != DBNull.Value ? reader["DokumentTozsamosci"].ToString() : "";
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
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
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imie.Text) || string.IsNullOrWhiteSpace(nazwisko.Text) || string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(telefon.Text))
            {
                MessageBox.Show("Proszę wypełnić imię, nazwisko, e-mail oraz telefon gościa.", "Braki w formularzu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string imieGo = imie.Text.Trim();
            string nazwiskoGo = nazwisko.Text.Trim();
            string emailGo = email.Text.Trim();
            string telefonGo = telefon.Text.Trim();
            string dokumentGo = dokument.Text.Trim();
            string uwagiGo = uwagi.Text.Trim();

            if (!int.TryParse(osobowy.Text, out int iloscOsob))
            {
                iloscOsob = 1;
            }

            string typPokoju = Standard.Checked ? "Standard" : "Deluxe";
            string dataPrzyjazduSQL = przyjazd.Value.ToString("yyyy-MM-dd");
            string dataOdjazduSQL = odjazd.Value.ToString("yyyy-MM-dd");

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
                  AND Pojemnosc >= @osoby 
                  AND IdPokoju NOT IN (
                      SELECT IdPokoju 
                      FROM Rezerwacje 
                      WHERE StatusRezerwacji != 'Anulowana'
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

                    object wynikPokoj = cmdPokoj.ExecuteScalar();

                    if (wynikPokoj == null)
                    {
                        MessageBox.Show($"Niestety w podanym terminie nie ma wolnego pokoju typu {typPokoju} dla {iloscOsob} (lub więcej) osób.", "Brak wolnych pokoi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    int idPokoju = Convert.ToInt32(wynikPokoj);

                    int idGoscia = -1;
                    string checkGosc = "SELECT IdGoscia FROM Goscie WHERE Email = @email LIMIT 1;";
                    using (MySqlCommand cmdCheck = new MySqlCommand(checkGosc, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@email", emailGo);
                        object wynikGosc = cmdCheck.ExecuteScalar();

                        if (wynikGosc != null)
                        {
                            idGoscia = Convert.ToInt32(wynikGosc);

                            string updateGosc = "UPDATE Goscie SET Imie = @imie, Nazwisko = @nazwisko, Telefon = @telefon, DokumentTozsamosci = @dokument WHERE IdGoscia = @id;";
                            using (MySqlCommand cmdUpdate = new MySqlCommand(updateGosc, conn))
                            {
                                cmdUpdate.Parameters.AddWithValue("@imie", imieGo);
                                cmdUpdate.Parameters.AddWithValue("@nazwisko", nazwiskoGo);
                                cmdUpdate.Parameters.AddWithValue("@telefon", telefonGo);
                                cmdUpdate.Parameters.AddWithValue("@dokument", string.IsNullOrWhiteSpace(dokumentGo) ? DBNull.Value : (object)dokumentGo);
                                cmdUpdate.Parameters.AddWithValue("@id", idGoscia);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertGosc = "INSERT INTO Goscie (Imie, Nazwisko, Email, Telefon, DokumentTozsamosci) VALUES (@imie, @nazwisko, @email, @telefon, @dokument); SELECT LAST_INSERT_ID();";
                            using (MySqlCommand cmdGosc = new MySqlCommand(insertGosc, conn))
                            {
                                cmdGosc.Parameters.AddWithValue("@imie", imieGo);
                                cmdGosc.Parameters.AddWithValue("@nazwisko", nazwiskoGo);
                                cmdGosc.Parameters.AddWithValue("@email", emailGo);
                                cmdGosc.Parameters.AddWithValue("@telefon", telefonGo);
                                cmdGosc.Parameters.AddWithValue("@dokument", string.IsNullOrWhiteSpace(dokumentGo) ? DBNull.Value : (object)dokumentGo);

                                idGoscia = Convert.ToInt32(cmdGosc.ExecuteScalar());
                            }
                        }
                    }

                    string insertRezerwacja = @"INSERT INTO Rezerwacje (IdGoscia, IdPokoju, IdPracownika, DataPrzyjazdu, DataWyjazdu, KwotaCalkowita, StatusRezerwacji, Uwagi) 
                                        VALUES (@idGosc, @idPokoj, @idPracownika, @przyjazd, @wyjazd, @kwota, 'Oczekujaca', @uwagi);";
                    using (MySqlCommand cmdRez = new MySqlCommand(insertRezerwacja, conn))
                    {
                        cmdRez.Parameters.AddWithValue("@idGosc", idGoscia);
                        cmdRez.Parameters.AddWithValue("@idPokoj", idPokoju);
                        cmdRez.Parameters.AddWithValue("@idPracownika", DBNull.Value);
                        cmdRez.Parameters.AddWithValue("@przyjazd", dataPrzyjazduSQL);
                        cmdRez.Parameters.AddWithValue("@wyjazd", dataOdjazduSQL);
                        cmdRez.Parameters.AddWithValue("@kwota", cena);
                        cmdRez.Parameters.AddWithValue("@uwagi", string.IsNullOrWhiteSpace(uwagiGo) ? DBNull.Value : (object)uwagiGo);

                        cmdRez.ExecuteNonQuery();
                    }

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