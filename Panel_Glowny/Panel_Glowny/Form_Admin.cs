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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EkranAdmin ekranAdmin2 = new EkranAdmin();
            ekranAdmin2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EkranPokoje ekranPokoje2 = new EkranPokoje();
            ekranPokoje2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EkranGoscie ekranGoscie2 = new EkranGoscie();
            ekranGoscie2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EkranLogowania ekranLogowania2 = new EkranLogowania();
            ekranLogowania2.Show();
            this.Hide();
        }
    }
}
