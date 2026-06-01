using MySql.Data.MySqlClient;

namespace Panele_Glowne
{
    partial class EkranAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Id_pracownika = new DataGridViewTextBoxColumn();
            Imie = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            rola = new DataGridViewTextBoxColumn();
            Data_Zatrudnienia = new DataGridViewTextBoxColumn();
            pensja = new DataGridViewTextBoxColumn();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(9, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 442);
            panel2.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(34, 376);
            button4.Name = "button4";
            button4.Size = new Size(111, 42);
            button4.TabIndex = 3;
            button4.Text = "Powrót";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 108);
            button3.Name = "button3";
            button3.Size = new Size(125, 60);
            button3.TabIndex = 5;
            button3.Text = "Usuń Pracownika";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(34, 26);
            button2.Name = "button2";
            button2.Size = new Size(125, 63);
            button2.TabIndex = 4;
            button2.Text = "Dodaj Pracownika";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(9, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 36);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(12, 8);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 5;
            label3.Text = "Witamy Administracje";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(198, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(951, 484);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(560, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 57);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 10;
            label4.Text = "Ustaw date zatrudnienia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 57);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 16);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 7;
            label2.Text = "Stworz pracownika";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_pracownika, Imie, Nazwisko, rola, Data_Zatrudnienia, pensja });
            dataGridView1.Location = new Point(34, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(894, 245);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(799, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 14;
            // 
            // Id_pracownika
            // 
            Id_pracownika.HeaderText = "ID_Pracownika";
            Id_pracownika.Name = "Id_pracownika";
            Id_pracownika.Width = 90;
            // 
            // Imie
            // 
            Imie.DataPropertyName = "Imie";
            Imie.HeaderText = "Imie";
            Imie.Name = "Imie";
            Imie.Width = 160;
            // 
            // Nazwisko
            // 
            Nazwisko.DataPropertyName = "Nazwisko";
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Width = 160;
            // 
            // rola
            // 
            rola.DataPropertyName = "rola";
            rola.HeaderText = "rola";
            rola.Name = "rola";
            rola.Width = 150;
            // 
            // Data_Zatrudnienia
            // 
            Data_Zatrudnienia.HeaderText = "Data_Zatrudnienia";
            Data_Zatrudnienia.Name = "Data_Zatrudnienia";
            Data_Zatrudnienia.Width = 160;
            // 
            // pensja
            // 
            pensja.HeaderText = "Pensja";
            pensja.Name = "pensja";
            pensja.Width = 160;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adminitrator", "Recepcjonista" });
            comboBox1.Location = new Point(376, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 57);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 16;
            label5.Text = "Imie";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 58);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 17;
            label6.Text = "Stanowisko/rola";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(241, 57);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 18;
            label7.Text = "Nazwisko";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(828, 57);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 19;
            label8.Text = "Pensja";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(45, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 23);
            textBox4.TabIndex = 20;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(203, 136);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(142, 23);
            textBox5.TabIndex = 21;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(88, 121);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 22;
            label9.Text = "Login";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(241, 121);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 23;
            label10.Text = "Haslo";
            // 
            // EkranAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1174, 520);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "EkranAdmin";
            Text = "Admin";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznaczyć pracownika do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPracownika = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Pracownika"].Value);

            DialogResult confirm = MessageBox.Show(
                $"Czy na pewno chcesz usunąć pracownika o ID {idPracownika}?",
                "Potwierdzenie",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            string query = "DELETE FROM Pracownicy WHERE Id_pracownika = @idPracownika";

            using (MySqlConnection connection = db.GetConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idPracownika", idPracownika);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Pracownik został pomyslnie usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OdswiezTabelePracownikow();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Błąd bazy danych: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Wystąpił nieoczekiwany błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #endregion

        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button4;
        private Panel panel1;
        private Panel panel3;
        private Label label3;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Id_pracownika;
        private DataGridViewTextBoxColumn Imie;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn rola;
        private DataGridViewTextBoxColumn Data_Zatrudnienia;
        private DataGridViewTextBoxColumn pensja;
        private Label label5;
        private ComboBox comboBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label9;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label10;
    }
}