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
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Id_pracownika = new DataGridViewTextBoxColumn();
            Imie = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            rola = new DataGridViewTextBoxColumn();
            Data_Zatrudnienia = new DataGridViewTextBoxColumn();
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
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(10, 88);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 589);
            panel2.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(39, 501);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(127, 56);
            button4.TabIndex = 3;
            button4.Text = "Powrót";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(39, 35);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(143, 84);
            button2.TabIndex = 4;
            button2.Text = "Dodaj Pracownika";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(39, 144);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(143, 80);
            button3.TabIndex = 5;
            button3.Text = "Usuń Pracownika";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(10, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 48);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(14, 11);
            label3.Name = "label3";
            label3.Size = new Size(202, 25);
            label3.TabIndex = 5;
            label3.Text = "Witamy Administracje";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox6);
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
            panel3.Location = new Point(226, 32);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1087, 645);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(489, 161);
            label11.Name = "label11";
            label11.Size = new Size(32, 20);
            label11.TabIndex = 25;
            label11.Text = "PIN";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(430, 181);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(162, 27);
            textBox6.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(275, 161);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 23;
            label10.Text = "Haslo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(101, 161);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 22;
            label9.Text = "Login";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(232, 181);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(162, 27);
            textBox5.TabIndex = 21;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(51, 181);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 27);
            textBox4.TabIndex = 20;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(946, 76);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 19;
            label8.Text = "Pensja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 76);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 18;
            label7.Text = "Nazwisko";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 77);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 17;
            label6.Text = "Stanowisko/rola";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 76);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 16;
            label5.Text = "Imie";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrator", "Recepcjonista" });
            comboBox1.Location = new Point(430, 101);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 28);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(913, 101);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(232, 101);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 101);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 27);
            textBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(640, 100);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(686, 76);
            label4.Name = "label4";
            label4.Size = new Size(169, 20);
            label4.TabIndex = 10;
            label4.Text = "Ustaw date zatrudnienia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 76);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 21);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 7;
            label2.Text = "Stworz pracownika";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id_pracownika, Imie, Nazwisko, rola, Data_Zatrudnienia, pensja });
            dataGridView1.Location = new Point(39, 300);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1022, 327);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Id_pracownika
            // 
            Id_pracownika.HeaderText = "ID_Pracownika";
            Id_pracownika.MinimumWidth = 6;
            Id_pracownika.Name = "Id_pracownika";
            Id_pracownika.Width = 90;
            // 
            // Imie
            // 
            Imie.DataPropertyName = "Imie";
            Imie.HeaderText = "Imie";
            Imie.MinimumWidth = 6;
            Imie.Name = "Imie";
            Imie.Width = 160;
            // 
            // Nazwisko
            // 
            Nazwisko.DataPropertyName = "Nazwisko";
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.MinimumWidth = 6;
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Width = 160;
            // 
            // rola
            // 
            rola.DataPropertyName = "rola";
            rola.HeaderText = "rola";
            rola.MinimumWidth = 6;
            rola.Name = "rola";
            rola.Width = 150;
            // 
            // Data_Zatrudnienia
            // 
            Data_Zatrudnienia.HeaderText = "Data_Zatrudnienia";
            Data_Zatrudnienia.MinimumWidth = 6;
            Data_Zatrudnienia.Name = "Data_Zatrudnienia";
            Data_Zatrudnienia.Width = 160;
            // 
            // pensja
            // 
            pensja.HeaderText = "Pensja";
            pensja.MinimumWidth = 6;
            pensja.Name = "pensja";
            pensja.Width = 160;
            // 
            // EkranAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1342, 693);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EkranAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
        private Label label11;
        private TextBox textBox6;
    }
}