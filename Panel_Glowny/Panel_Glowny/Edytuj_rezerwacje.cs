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
    public partial class Edytuj_rezerwacje : Form
    {
        public Edytuj_rezerwacje()
        {
            InitializeComponent();
        }

        private void powrot_Click(object sender, EventArgs e)
        {
            Rezerwacje powrot = new Rezerwacje();
            powrot.Show();

            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
