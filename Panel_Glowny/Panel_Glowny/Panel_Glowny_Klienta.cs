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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ekran_Logowania_Klienta ekranLogowania2 = new Ekran_Logowania_Klienta();
            ekranLogowania2.Show();
            this.Hide();
        }
    }
}
