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
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Id_pracownika = new DataGridViewTextBoxColumn();
            Data_Zatrudnienia = new DataGridViewTextBoxColumn();
            Id_Osoby = new DataGridViewTextBoxColumn();
            pensja = new DataGridViewTextBoxColumn();
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
            button4.Text = "Powrót na ekran głowny";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(552, 29);
            button3.Name = "button3";
            button3.Size = new Size(111, 35);
            button3.TabIndex = 5;
            button3.Text = "Usuń Pracownika";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(552, 70);
            button2.Name = "button2";
            button2.Size = new Size(111, 31);
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
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(198, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(766, 484);
            panel3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(364, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(364, 57);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 12;
            label5.Text = "Ustal Pensje pracownika";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(145, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 57);
            label4.Name = "label4";
            label4.Size = new Size(133, 15);
            label4.TabIndex = 10;
            label4.Text = "Ustaw date zatrudnienia";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 57);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 8;
            label1.Text = "Podaj Id_Osoby";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 7;
            label2.Text = "Stworz pracownika";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_pracownika, Data_Zatrudnienia, Id_Osoby, pensja });
            dataGridView1.Location = new Point(3, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(700, 245);
            dataGridView1.TabIndex = 0;
            // 
            // Id_pracownika
            // 
            Id_pracownika.HeaderText = "ID_Pracownika";
            Id_pracownika.Name = "Id_pracownika";
            Id_pracownika.Width = 160;
            // 
            // Data_Zatrudnienia
            // 
            Data_Zatrudnienia.HeaderText = "Data_Zatrudnienia";
            Data_Zatrudnienia.Name = "Data_Zatrudnienia";
            Data_Zatrudnienia.Width = 160;
            // 
            // Id_Osoby
            // 
            Id_Osoby.HeaderText = "ID_Osoby";
            Id_Osoby.Name = "Id_Osoby";
            Id_Osoby.Width = 160;
            // 
            // pensja
            // 
            pensja.HeaderText = "Pensja";
            pensja.Name = "pensja";
            pensja.Width = 160;
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
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn Id_pracownika;
        private DataGridViewTextBoxColumn Data_Zatrudnienia;
        private DataGridViewTextBoxColumn Id_Osoby;
        private DataGridViewTextBoxColumn pensja;
    }
}