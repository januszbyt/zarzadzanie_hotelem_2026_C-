using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Panel_Glowny;

namespace Panele_Glowne
{
    public partial class EkranPokoje : Form
    {
        public EkranPokoje()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 powrotDoOknaPracownika = new Form1();
            powrotDoOknaPracownika.Show();

            this.Hide();
        }

        private void EkranPokoje_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OknoSzczegolowPokoju OknoSzczegolow = new OknoSzczegolowPokoju();
            OknoSzczegolow.Show();

            this.Hide();
        }
    }
}
