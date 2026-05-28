namespace Panele_Glowne
{
    partial class EkranGoscie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Imie = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            NrTelefonu = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Liczba_rezerwacji = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button7 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(564, -1);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(164, 41);
            label1.TabIndex = 0;
            label1.Text = "GOŚCIE";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(85, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1118, 529);
            panel1.TabIndex = 1;
            // 
            // button6
            // 
            button6.Location = new Point(983, 230);
            button6.Name = "button6";
            button6.Size = new Size(85, 43);
            button6.TabIndex = 17;
            button6.Text = "Edytuj";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1009, 472);
            button5.Name = "button5";
            button5.Size = new Size(85, 47);
            button5.TabIndex = 16;
            button5.Text = "Powrot";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(983, 177);
            button4.Name = "button4";
            button4.Size = new Size(85, 47);
            button4.TabIndex = 15;
            button4.Text = "Anuluj";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(983, 124);
            button3.Name = "button3";
            button3.Size = new Size(85, 47);
            button3.TabIndex = 14;
            button3.Text = "Usun";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(87, 484);
            button2.Name = "button2";
            button2.Size = new Size(167, 23);
            button2.TabIndex = 13;
            button2.Text = "Sprawdz historie pobytow";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(87, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 407);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Imie, Nazwisko, NrTelefonu, Email, Liczba_rezerwacji });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(845, 407);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Imie
            // 
            Imie.HeaderText = "Imie";
            Imie.Name = "Imie";
            Imie.Width = 150;
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Width = 150;
            // 
            // NrTelefonu
            // 
            NrTelefonu.HeaderText = "NrTelefonu";
            NrTelefonu.Name = "NrTelefonu";
            NrTelefonu.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Liczba_rezerwacji
            // 
            Liczba_rezerwacji.HeaderText = "Liczba_rezerwacji";
            Liczba_rezerwacji.Name = "Liczba_rezerwacji";
            Liczba_rezerwacji.Width = 156;
            // 
            // button1
            // 
            button1.Location = new Point(983, 71);
            button1.Name = "button1";
            button1.Size = new Size(85, 47);
            button1.TabIndex = 11;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(833, 32);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(167, 23);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label7.Location = new Point(852, 9);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 9;
            label7.Text = "Liczba rezerwacji";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label6.Location = new Point(677, 9);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 8;
            label6.Text = "Adres e-mail";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(640, 32);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label5.Location = new Point(478, 9);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 6;
            label5.Text = "Numer telefonu";
            label5.Click += label5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(449, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label4.Location = new Point(330, 9);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 4;
            label4.Text = "Nazwisko";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label3.Location = new Point(206, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 2;
            label3.Text = "Imie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label2.Location = new Point(18, 32);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 0;
            label2.Text = "Dodaj gościa:";
            // 
            // button7
            // 
            button7.Location = new Point(1009, 18);
            button7.Name = "button7";
            button7.Size = new Size(85, 47);
            button7.TabIndex = 18;
            button7.Text = "Zatwierdz";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // EkranGoscie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1266, 607);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "EkranGoscie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ekran Goscie";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private Label label6;
        private TextBox textBox4;
        private Panel panel2;
        private Button button1;
        private TextBox textBox5;
        private Label label7;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Imie;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn NrTelefonu;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Liczba_rezerwacji;
        private Button button7;
    }
}