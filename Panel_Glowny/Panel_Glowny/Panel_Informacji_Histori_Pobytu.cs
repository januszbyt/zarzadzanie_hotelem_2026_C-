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
    public partial class Panel_Informacji_Histori_Pobytu : Form
    {
        public Panel_Informacji_Histori_Pobytu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel_Przypisania_Goscia_DoRezerwacji EkranGosciePowrot = new Panel_Przypisania_Goscia_DoRezerwacji();
            EkranGosciePowrot.Show();

            this.Hide();
        }
    }
}
