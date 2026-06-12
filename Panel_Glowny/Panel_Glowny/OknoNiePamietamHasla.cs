using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Panel_Glowny;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Panele_Glowne
{
    public partial class OknoNiePamietamHasla : Form
    {
        public OknoNiePamietamHasla()
        {
            InitializeComponent();
        }

        private void OknoNiePamietamHasla_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            Ekran_Logowania_Klienta powrotDoOknaLogowania = new Ekran_Logowania_Klienta();
            powrotDoOknaLogowania.Show();
            this.Hide();
        }

        private void btnZresetuj_Click(object sender, EventArgs e)
        {
            HotelContext db = new HotelContext();

            using (var conn = db.GetConnection())
            {
                try
                {
                    string login = tboxLogin.Text.Trim();
                    string haslo = tboxHaslo.Text;
                    string powtorzHaslo = tboxPowtorzHaslo.Text;
                    string PIN = tboxPinPomocniczy.Text.Trim();

                    if (string.IsNullOrWhiteSpace(login) ||
                        string.IsNullOrWhiteSpace(haslo) ||
                        string.IsNullOrWhiteSpace(powtorzHaslo) ||
                        string.IsNullOrWhiteSpace(PIN))
                    {
                        MessageBox.Show("Wszystkie pola muszą zostać wypełnione");
                        return;
                    }

                    if (haslo != powtorzHaslo)
                    {
                        MessageBox.Show("Hasła muszą być identyczne");
                        return;
                    }

                    conn.Open();

                    string query = @"SELECT Login FROM Konta WHERE Login = @login AND PIN = @PIN";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@PIN", PIN);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();

                        string updateQuery = @"UPDATE Konta SET HasloHash = @haslo WHERE Login = @login";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@haslo", haslo);
                        updateCmd.Parameters.AddWithValue("@login", login);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Hasło zostało zmienione");

                        Ekran_Logowania_Klienta logowanie = new Ekran_Logowania_Klienta();
                        logowanie.Show();

                        this.Hide();
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Nieprawidlowy login lub PIN");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad polaczenia z baza");  
                    MessageBox.Show(ex.Message);
                }

            }

        }
    }
}
