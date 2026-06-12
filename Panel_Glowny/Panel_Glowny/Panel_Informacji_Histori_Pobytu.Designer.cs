namespace Panele_Glowne
{
    partial class Panel_Informacji_Histori_Pobytu
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
            panel1 = new Panel();
            button1 = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            IdRezerwacji = new DataGridViewTextBoxColumn();
            Pokoj = new DataGridViewTextBoxColumn();
            DataPrzyjazdu = new DataGridViewTextBoxColumn();
            DataOdjazdu = new DataGridViewTextBoxColumn();
            LiczbaNocy = new DataGridViewTextBoxColumn();
            KwotaLaczna = new DataGridViewTextBoxColumn();
            StatusRezerwacji = new DataGridViewTextBoxColumn();
            Uwagi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(41, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 522);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(16, 469);
            button1.Name = "button1";
            button1.Size = new Size(128, 37);
            button1.TabIndex = 12;
            button1.Text = "Powrot";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 407);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 11;
            label12.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 328);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 10;
            label11.Text = "label11";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 257);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 9;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 185);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 8;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 108);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(16, 369);
            label7.Name = "label7";
            label7.Size = new Size(65, 18);
            label7.TabIndex = 6;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(16, 291);
            label6.Name = "label6";
            label6.Size = new Size(62, 18);
            label6.TabIndex = 5;
            label6.Text = "NrTel:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(16, 220);
            label5.Name = "label5";
            label5.Size = new Size(95, 18);
            label5.TabIndex = 4;
            label5.Text = "Nazwisko:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(16, 148);
            label4.Name = "label4";
            label4.Size = new Size(53, 18);
            label4.TabIndex = 3;
            label4.Text = "Imie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            label3.Location = new Point(16, 72);
            label3.Name = "label3";
            label3.Size = new Size(33, 18);
            label3.TabIndex = 2;
            label3.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(82, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 1;
            label2.Text = "Dane";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(232, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1020, 522);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdRezerwacji, Pokoj, DataPrzyjazdu, DataOdjazdu, LiczbaNocy, KwotaLaczna, StatusRezerwacji, Uwagi });
            dataGridView1.Location = new Point(-1, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1020, 522);
            dataGridView1.TabIndex = 0;
            // 
            // IdRezerwacji
            // 
            IdRezerwacji.HeaderText = "IdRezerwacji";
            IdRezerwacji.Name = "IdRezerwacji";
            IdRezerwacji.Width = 122;
            // 
            // Pokoj
            // 
            Pokoj.HeaderText = "Pokoj";
            Pokoj.Name = "Pokoj";
            Pokoj.Width = 122;
            // 
            // DataPrzyjazdu
            // 
            DataPrzyjazdu.HeaderText = "DataPrzyjazdu";
            DataPrzyjazdu.Name = "DataPrzyjazdu";
            DataPrzyjazdu.Width = 122;
            // 
            // DataOdjazdu
            // 
            DataOdjazdu.HeaderText = "DataOdjazdu";
            DataOdjazdu.Name = "DataOdjazdu";
            DataOdjazdu.Width = 122;
            // 
            // LiczbaNocy
            // 
            LiczbaNocy.HeaderText = "LiczbaNocy";
            LiczbaNocy.Name = "LiczbaNocy";
            LiczbaNocy.Width = 122;
            // 
            // KwotaLaczna
            // 
            KwotaLaczna.HeaderText = "KwotaLaczna";
            KwotaLaczna.Name = "KwotaLaczna";
            KwotaLaczna.Width = 122;
            // 
            // StatusRezerwacji
            // 
            StatusRezerwacji.HeaderText = "StatusRezerwacji";
            StatusRezerwacji.Name = "StatusRezerwacji";
            StatusRezerwacji.Width = 122;
            // 
            // Uwagi
            // 
            Uwagi.HeaderText = "Uwagi";
            Uwagi.Name = "Uwagi";
            Uwagi.Width = 122;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 26.25F, FontStyle.Bold);
            label1.Location = new Point(485, 15);
            label1.Name = "label1";
            label1.Size = new Size(330, 41);
            label1.TabIndex = 1;
            label1.Text = "Historia pobytów";
            label1.Click += label1_Click;
            // 
            // Panel_Informacji_Histori_Pobytu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1327, 615);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Panel_Informacji_Histori_Pobytu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdRezerwacji;
        private DataGridViewTextBoxColumn Pokoj;
        private DataGridViewTextBoxColumn DataPrzyjazdu;
        private DataGridViewTextBoxColumn DataOdjazdu;
        private DataGridViewTextBoxColumn LiczbaNocy;
        private DataGridViewTextBoxColumn KwotaLaczna;
        private DataGridViewTextBoxColumn StatusRezerwacji;
        private DataGridViewTextBoxColumn Uwagi;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button1;
    }
}