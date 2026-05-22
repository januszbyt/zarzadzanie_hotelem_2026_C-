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
    public partial class EkranAdmin : Form
    {
        public EkranAdmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EkranAdmin EkranAdminPowrot = new EkranAdmin();
            EkranAdminPowrot.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
