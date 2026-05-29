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
            Lista_Wszystkich_Pokojow ekranPokoje2 = new Lista_Wszystkich_Pokojow();
            ekranPokoje2.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Panel_Przypisania_Goscia_DoRezerwacji ekranGoscie2 = new Panel_Przypisania_Goscia_DoRezerwacji();
            ekranGoscie2.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ekran_Logowania_Klienta ekranLogowania2 = new Ekran_Logowania_Klienta();
            ekranLogowania2.Show();
            this.Hide();
        }
    }
}
