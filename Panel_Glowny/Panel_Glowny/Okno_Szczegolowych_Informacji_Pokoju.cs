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
    public partial class Okno_Szczegolowych_Informacji_Pokoju : Form
    {
        private HotelContext db = new HotelContext();
        private int idPokoju2;

        public Okno_Szczegolowych_Informacji_Pokoju()
        {
            InitializeComponent();
        }
        public Okno_Szczegolowych_Informacji_Pokoju(int idPokoju)
        {
            InitializeComponent();
            this.idPokoju2 = idPokoju;
        }
        private void Okno_Szczegolowych_Informacji_Pokoju_Load(object sender, EventArgs e)
        {
            LadujSzczegolyPokoju();
        }
        private void LadujSzczegolyPokoju()
        {
            using (var conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string zapytanie = @"SELECT P.NumerPokoju, P.Pojemnosc, R.IdRezerwacji, R.DataPrzyjazdu, R.DataWyjazdu, R.KwotaCalkowita,
                    G.Imie, G.Nazwisko, G.Email, G.Telefon from Pokoje P left join Rezerwacje R on P.IdPokoju = R.IdPokoju left join 
                    Goscie G on R.IdGoscia = G.IdGoscia
                    where P.IdPokoju = @idPokoju order by R.IdRezerwacji desc limit 1";
                    using (MySqlCommand cmd = new MySqlCommand(zapytanie, conn))
                    {
                        cmd.Parameters.AddWithValue("@idPokoju", idPokoju2);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                label3.Text = reader["NumerPokoju"].ToString();
                                label22.Text = reader["Pojemnosc"].ToString();
                                if (reader["Imie"] != DBNull.Value)
                                {
                                    label14.Text = reader["Imie"].ToString();
                                }
                                else
                                {
                                    label14.Text = "brak informacji";
                                }
                                if (reader["Nazwisko"] != DBNull.Value)
                                {
                                    label15.Text = reader["Nazwisko"].ToString();
                                }
                                else
                                {
                                    label15.Text = "brak informacji";
                                }
                                if (reader["Email"] != DBNull.Value)
                                {
                                    label16.Text = reader["Email"].ToString();
                                }
                                else
                                {
                                    label16.Text = "brak informacji";
                                }
                                if (reader["Telefon"] != DBNull.Value)
                                {
                                    label17.Text = reader["Telefon"].ToString();
                                }
                                else
                                {
                                    label17.Text = "brak informacji";
                                }
                                if (reader["IdRezerwacji"] != DBNull.Value)
                                {
                                    label18.Text = reader["IdRezerwacji"].ToString();
                                }
                                else
                                {
                                    label18.Text = "brak informacji";
                                }
                                if (reader["DataPrzyjazdu"] != DBNull.Value)
                                {
                                    DateTime dataPrzyjazdu = Convert.ToDateTime(reader["DataPrzyjazdu"]);
                                    label19.Text = dataPrzyjazdu.ToString("dd.MM.yyyy");

                                }
                                else
                                {
                                    label19.Text = "brak informacji";
                                }
                                if (reader["DataWyjazdu"] != DBNull.Value)
                                {
                                    DateTime dataWyjazdu = Convert.ToDateTime(reader["DataWyjazdu"]);
                                    label20.Text = dataWyjazdu.ToString("dd.MM.yyyy");

                                }
                                else
                                {
                                    label20.Text = "brak informacji";
                                }
                                if (reader["KwotaCalkowita"] != DBNull.Value)
                                {
                                    label21.Text = reader["KwotaCalkowita"].ToString() + " zł";
                                }
                                else
                                {
                                    label21.Text = "brak informacji";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Dane pokoju nie zostaly znalezione");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Blad" + ex.Message);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lista_Wszystkich_Pokojow powrotDoEkranuPokoje = new Lista_Wszystkich_Pokojow();
            powrotDoEkranuPokoje.Show();

            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}