using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panele_Glowne
{
    public partial class Panel_Glowny_Klienta : Form
    {
        public Panel_Glowny_Klienta()
        {
            InitializeComponent();
            this.Load += Panel_Glowny_Klienta_Load;

        }
        private void WczytajRezerwacje()
        {
            HotelContext db = new HotelContext();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT
            r.IdRezerwacji,
            p.NumerPokoju,
            r.DataPrzyjazdu,
            r.DataWyjazdu,
            r.LiczbaNocy,
            r.KwotaLaczna,
            r.StatusRezerwacji
            FROM Rezerwacje r
            JOIN Pokoje p ON r.IdPokoju = p.IdPokoju
            WHERE r.IdKlienta = @idKlienta";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idKlienta", ZalogowanyUzytkownik.IdKlienta);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Witaj");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dodaj_rezerwacje dodaj_Rezerwacje2 = new Dodaj_rezerwacje();
            dodaj_Rezerwacje2.Show();
        }
        private void fun2()
        {
            Console.WriteLine("FUN2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edytuj_rezerwacje edytuj_Rezerwacje2 = new Edytuj_rezerwacje();
            edytuj_Rezerwacje2.Show();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Ekran_Logowania_Klienta ekranLogowania2 = new Ekran_Logowania_Klienta();
            ekranLogowania2.Show();
            this.Hide();
        }
        private void Panel_Glowny_Klienta_Load(object sender, EventArgs e)
        {
            label2.Text = ZalogowanyUzytkownik.Imie + "!";
            WczytajRezerwacje();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
