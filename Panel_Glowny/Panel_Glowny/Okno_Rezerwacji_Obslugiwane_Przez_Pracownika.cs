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
    public partial class Okno_Rezerwacji_Obslugiwane_Przez_Pracownika : Form
    {
        public Okno_Rezerwacji_Obslugiwane_Przez_Pracownika()
        {
            InitializeComponent();
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj_rezerwacje dodajRezerwacje = new Dodaj_rezerwacje();
            dodajRezerwacje.Show();

            this.Hide();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edytuj_rezerwacje edytujRezerwacje = new Edytuj_rezerwacje();
            edytujRezerwacje.Show();

            this.Hide();
        }
    }
}
