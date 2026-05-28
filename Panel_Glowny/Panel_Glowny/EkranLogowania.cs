using MySql.Data.MySqlClient;
using Panel_Glowny;

namespace Panele_Glowne;

public partial class EkranLogowania : Form
{
    public EkranLogowania()
    {
        InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        EkranRejestracji rejestracja = new EkranRejestracji();
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
                            Form1 recepcja = new Form1();
                            recepcja.Show();
                        }
                        else if (rola == "klient")
                        {
                            Form_Klient klient = new Form_Klient();
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
}