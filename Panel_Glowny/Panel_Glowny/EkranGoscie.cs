using Panel_Glowny;
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
    public partial class EkranGoscie : Form
    {
        private DataGridViewRow? _edytowanyWiersz = null;
        public EkranGoscie()
        {
            InitializeComponent();
            button7.Location = button1.Location; // Ustawia "Zatwierdź" dokładnie w miejscu "Dodaj"
            button7.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            HistoriaGoscia HistoriaGoscia2 = new HistoriaGoscia();
            HistoriaGoscia2.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Zaznacz wiersz do edycji!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            textBox1.Text = row.Cells[1].Value?.ToString() ?? ""; // Imię
            textBox2.Text = row.Cells[2].Value?.ToString() ?? ""; // Nazwisko
            textBox3.Text = row.Cells[3].Value?.ToString() ?? ""; // NrTelefonu
            textBox4.Text = row.Cells[4].Value?.ToString() ?? ""; // Email
            textBox5.Text = row.Cells[5].Value?.ToString() ?? ""; // Liczba rezerwacji

            _edytowanyWiersz = row;
            button7.Visible = true;  // ← POKAŻ ZATWIERDŹ
            button1.Visible = false; // ← UKRYJ DODAJ
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            _edytowanyWiersz = null;
            button7.Visible = false;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Zaznacz wiersz do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult wynik = MessageBox.Show("Czy na pewno chcesz usunąć tego gościa?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (wynik == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Wypełnij przynajmniej imię i nazwisko!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            dataGridView1.Rows.Add("", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_edytowanyWiersz != null)
            {
                _edytowanyWiersz.Cells[1].Value = textBox1.Text;
                _edytowanyWiersz.Cells[2].Value = textBox2.Text;
                _edytowanyWiersz.Cells[3].Value = textBox3.Text;
                _edytowanyWiersz.Cells[4].Value = textBox4.Text;
                _edytowanyWiersz.Cells[5].Value = textBox5.Text;
                _edytowanyWiersz = null;
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            button7.Visible = false;
            button1.Visible = true; 
        }
    }
}
