using MySql.Data.MySqlClient;

namespace Panele_Glowne;


public partial class EkranLogowania : Form
{
    public EkranLogowania()
    {
        InitializeComponent();
    }
    private void button3_Click(object sender, EventArgs e)
    {
        EkranRejestracji przejscieDoRejestracji = new EkranRejestracji();
        przejscieDoRejestracji.Show();

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

                string query = "SELECT Haslo FROM Uzytkownicy WHERE Login = @login LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@login", login);

                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string hasloZBazy = result.ToString();

                    if (haslo == hasloZBazy)
                    {
                        label5.Text = "Zalogowano poprawnie";
                        label5.ForeColor = Color.Green;

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

