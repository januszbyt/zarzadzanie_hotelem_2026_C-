using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panele_Glowne
{
    public partial class OknoZmianyPinu : Form
    {
        public OknoZmianyPinu()
        {
            InitializeComponent();
        }
        public OknoZmianyPinu(string ZalogowanyUzytkownik)
        {
            InitializeComponent();
        }
        private void btnZmien_Click(object sender, EventArgs e)
        {
            HotelContext db = new HotelContext();

            using (var conn = db.GetConnection())
            {
                try
                {
                    string login = ZalogowanyUzytkownik.Login;

                    string staryPin = txtStaryPin.Text;
                    string nowyPin = txtNowyPin.Text;
                    string powtorzPin = txtPowtorzPin.Text;

                    if (string.IsNullOrWhiteSpace(staryPin) ||
                        string.IsNullOrWhiteSpace(nowyPin) ||
                        string.IsNullOrWhiteSpace(powtorzPin))
                    {
                        MessageBox.Show("Wszystkie pola muszą zostać wypełnione.");
                        return;
                    }

                    if (nowyPin != powtorzPin)
                    {
                        MessageBox.Show("Nowe PIN-y muszą być identyczne.");
                        return;
                    }

                    conn.Open();

                    string query = @"SELECT Login
                             FROM Konta
                             WHERE Login = @login
                             AND PIN = @staryPin";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@staryPin", staryPin);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();

                        string updateQuery = @"UPDATE Konta
                                       SET PIN = @nowyPin
                                       WHERE Login = @login";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@nowyPin", nowyPin);
                        updateCmd.Parameters.AddWithValue("@login", login);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("PIN został zmieniony.");

                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Nieprawidłowy stary PIN.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas zmiany PIN-u.");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            OknoZarzadzanieKontem powrotDoZarzadzania2 = new OknoZarzadzanieKontem(ZalogowanyUzytkownik.Login);
            powrotDoZarzadzania2.Show();
            this.Close();
        }
    }
}
