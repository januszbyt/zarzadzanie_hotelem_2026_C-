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
    public partial class EkranRejestracji : Form
    {
        public EkranRejestracji()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            EkranLogowania powrotDoLogowania = new EkranLogowania();
            powrotDoLogowania.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string email = textBox2.Text;
            string haslo = textBox3.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(haslo))
            {
                MessageBox.Show("Prosze uzupełnic wszystkie pola", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            bool sukces = true;

            if (sukces)
            {
                MessageBox.Show("Konto zostało założone pomyslnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}