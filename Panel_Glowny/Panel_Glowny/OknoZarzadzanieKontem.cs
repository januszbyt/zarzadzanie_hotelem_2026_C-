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
using Panel_Glowny;

namespace Panele_Glowne
{
    public partial class OknoZarzadzanieKontem : Form
    {
        public OknoZarzadzanieKontem()
        {
            InitializeComponent();
            this.Load += OknoZarzadzanieKontem_Load;
        }
        public OknoZarzadzanieKontem(string ZalogowanyUzytkownik)
        {
            InitializeComponent();
            this.Load += OknoZarzadzanieKontem_Load;
        }
        private void OknoZarzadzanieKontem_Load(object sender, EventArgs e)
        {
            lblwitajnazwa.Text = ZalogowanyUzytkownik.Imie + "!";
            PobierzDaneUzytkownika();

        }

        private void PobierzDaneUzytkownika()
        {
            HotelContext db = new HotelContext();
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Login, Haslo, Pin FROM Uzytkownicy WHERE Login = @login";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", ZalogowanyUzytkownik.Login);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblpobieranaNazwa.Text = reader["Login"].ToString();
                        lblPobieraneHaslo.Text = reader["Haslo"].ToString();
                        lblPobieranyPin.Text = reader["Pin"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych: " + ex.Message);
                }
            }
        }
        private void btnPowrot_Click(object sender, EventArgs e)
        {

            string rola = ZalogowanyUzytkownik.Rola;
            if (rola == "Administrator")
            {
                Form_Admin admin = new Form_Admin(ZalogowanyUzytkownik.Login);
                admin.Show();
                this.Close();
            }
            if (rola == "Recepcjonista")
            {
                Ekran_Glowny_Pracownika pracownik = new Ekran_Glowny_Pracownika(ZalogowanyUzytkownik.Login);
                pracownik.Show();
                this.Close();
            }

            if (rola == "Klient")
            {
                Panel_Glowny_Klienta klient = new Panel_Glowny_Klienta(ZalogowanyUzytkownik.Login);
                klient.Show();
                this.Close();
            }
        }

        private void btnZmienHaslo_Click(object sender, EventArgs e)
        {
            OknoZmianyHasla oknoZmianyHasla = new OknoZmianyHasla(ZalogowanyUzytkownik.Login);
            oknoZmianyHasla.Show();
            this.Close();
        }

        private void btnZmianaPin_Click(object sender, EventArgs e)
        {
            OknoZmianyPinu oknoZmianyPinu = new OknoZmianyPinu(ZalogowanyUzytkownik.Login);
            oknoZmianyPinu.Show();
            this.Close();
        }
    }
}
