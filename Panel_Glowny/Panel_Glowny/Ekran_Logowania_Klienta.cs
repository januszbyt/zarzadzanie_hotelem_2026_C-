using MySql.Data.MySqlClient;
using Panel_Glowny;

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

                string query = "SELECT Haslo, Rola FROM Uzytkownicy WHERE Login = @login";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string hasloZBazy = reader["Haslo"].ToString();
                    string rola = reader["Rola"].ToString();

                    if (haslo == hasloZBazy)
                    {
                        if (rola == "Administrator")
                        {
                            Form_Admin admin = new Form_Admin();
                            admin.Show();
                        }
                        else if (rola == "Recepcjonista")
                        {
                            Ekran_Glowny_Pracownika recepcja = new Ekran_Glowny_Pracownika();
                            recepcja.Show();
                        }
                        else if (rola == "klient")
                        {
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
                    label5.Text = "Nie ma takiego użytkownika";
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

    private void linkForgotPassword_MouseEnter(object sender, EventArgs e)
    {
        linkLabel1.LinkColor = Color.CornflowerBlue;
    }

    private void linkForgotPassword_MouseLeave(object sender, EventArgs e)
    {
        linkLabel1.LinkColor = SystemColors.ControlDarkDark;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Ekran_Zapomnialem_Hasla zapomnialem = new Ekran_Zapomnialem_Hasla();
        zapomnialem.Show();

        this.Hide();
    }
}