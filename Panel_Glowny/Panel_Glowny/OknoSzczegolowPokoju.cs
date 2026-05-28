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
    public partial class OknoSzczegolowPokoju : Form
    {
        private HotelContext db = new HotelContext();
        private int idPokoju2;

        public OknoSzczegolowPokoju()
        {
            InitializeComponent();
        }
        public OknoSzczegolowPokoju(int idPokoju)
        {
            InitializeComponent();
            this.idPokoju2 = idPokoju;
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
            EkranPokoje powrotDoEkranuPokoje = new EkranPokoje();
            powrotDoEkranuPokoje.Show();

            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
