using MySql.Data.MySqlClient;
using Panel_Glowny;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Panele_Glowne;

public partial class Ekran_Logowania_Klienta : Form
{
    bool pokazHaslo = false;

    public Ekran_Logowania_Klienta()
    {
        InitializeComponent();
        this.AcceptButton = button1;
        textBox2.PasswordChar = '*';
        pictureBox2.Image = Image.FromFile("Zdjecia/okowidac.png");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        Ekran_Rejestracji_klienta rejestracja = new Ekran_Rejestracji_klienta();
        rejestracja.Show();
        this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string login = textBox1.Text;
        string haslo = textBox2.Text;

        HotelContext db = new HotelContext();

        using (var conn = db.GetConnection())
        {
            try
            {
                conn.Open();

                string query = @"
                SELECT 
                    k.Login, 
                    k.HasloHash AS Haslo, 
                    k.Rola,
                    k.IdKonta,
                    g.IdGoscia,
                    g.Imie AS ImieGoscia,
                    p.IdPracownika,
                    p.Imie AS ImiePracownika
                FROM Konta k
                LEFT JOIN Goscie g ON k.IdKonta = g.IdKonta
                LEFT JOIN Pracownicy p ON k.IdKonta = p.IdKonta
                WHERE k.Login = @login AND k.Aktywne = 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string hasloZBazy = reader["Haslo"].ToString();
                    string rola = reader["Rola"].ToString();

                    if (haslo == hasloZBazy)
                    {
                        ZalogowanyUzytkownik.Login = reader["Login"].ToString();
                        ZalogowanyUzytkownik.Rola = rola;

                        if (rola == "Administrator")
                        {
                            ZalogowanyUzytkownik.Imie = reader["ImiePracownika"] != DBNull.Value ? reader["ImiePracownika"].ToString() : "Admin";
                            Form_Admin admin = new Form_Admin(ZalogowanyUzytkownik.Login);
                            admin.Show();
                        }
                        else if (rola == "Recepcjonista")
                        {
                            ZalogowanyUzytkownik.Imie = reader["ImiePracownika"].ToString();

                            if (reader["IdPracownika"] != DBNull.Value)
                            {
                                ZalogowanyUzytkownik.IdPracownika = Convert.ToInt32(reader["IdPracownika"]);
                            }

                            Ekran_Glowny_Pracownika recepcja = new Ekran_Glowny_Pracownika(login);
                            recepcja.Show();
                        }
                        else if (rola == "Gosc")
                        {
                            ZalogowanyUzytkownik.Imie = reader["ImieGoscia"].ToString();

                            if (reader["IdGoscia"] != DBNull.Value)
                            {
                                ZalogowanyUzytkownik.IdGoscia = Convert.ToInt32(reader["IdGoscia"]);
                            }

                            Panel_Glowny_Klienta klient = new Panel_Glowny_Klienta();
                            klient.Show();
                        }

                        this.Hide();
                    }
                    else
                    {
                        label5.Text = "Błędne hasło";
                        label5.ForeColor = Color.Red;
                    }
                }
                else
                {
                    label5.Text = "Nie ma takiego użytkownika lub konto nieaktywne";
                    label5.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                label5.Text = "Błąd połączenia z bazą";
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void pictureBox2_Click(object sender, EventArgs e)
    {
        if (!pokazHaslo)
        {
            textBox2.PasswordChar = '\0';
            pictureBox2.Image = Image.FromFile("Zdjecia/okoniewidac.png");
            pokazHaslo = true;
        }
        else
        {
            textBox2.PasswordChar = '*';
            pictureBox2.Image = Image.FromFile("Zdjecia/okowidac.png");
            pokazHaslo = false;
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void linkLabNiePamietam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        OknoNiePamietamHasla DoOknaNiePamietamHasla = new OknoNiePamietamHasla();
        DoOknaNiePamietamHasla.Show();
        this.Hide();
    }
}