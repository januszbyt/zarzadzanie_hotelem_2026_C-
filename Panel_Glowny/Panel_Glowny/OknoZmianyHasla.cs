using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
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
    public partial class OknoZmianyHasla : Form
    {
        public OknoZmianyHasla()
        {
            InitializeComponent();
        }
        public OknoZmianyHasla(string ZalogowanyUzytkownik)
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
                    string stareHaslo = txtStareHaslo.Text;
                    string noweHaslo = txtNoweHaslo.Text;
                    string powtorzHaslo = txtPowtorzHaslo.Text;

                    if (string.IsNullOrWhiteSpace(stareHaslo) ||
                        string.IsNullOrWhiteSpace(noweHaslo) ||
                        string.IsNullOrWhiteSpace(powtorzHaslo))
                    {
                        MessageBox.Show("Wszystkie pola muszą zostać wypełnione");
                        return;
                    }

                    if (noweHaslo != powtorzHaslo)
                    {
                        MessageBox.Show("Hasła muszą być identyczne");
                        return;
                    }

                    conn.Open();


                    string query = @"SELECT Login FROM Uzytkownicy WHERE Login = @login AND Haslo = @stareHaslo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@stareHaslo", stareHaslo);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();

                        string updateQuery = @"UPDATE Uzytkownicy
                           SET Haslo = @noweHaslo
                           WHERE Login = @login";

                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@noweHaslo", txtNoweHaslo.Text);
                        updateCmd.Parameters.AddWithValue("@login", ZalogowanyUzytkownik.Login);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Hasło zostało zmienione.");
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Nieprawidłowe stare hasło.");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad polaczenia z baza");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            OknoZarzadzanieKontem powrotDoZarzadzania = new OknoZarzadzanieKontem(ZalogowanyUzytkownik.Login);
            powrotDoZarzadzania.Show();
            this.Close();
        }
    }
}



