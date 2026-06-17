namespace Panele_Glowne
{
    partial class Panel_Glowny_Klienta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Glowny_Klienta));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnZarzadzajKontem = new Button();
            button4 = new Button();
            edytuj = new Button();
            stworz = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 133);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(74, 73);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(64, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 2;
            label1.Text = "Witaj ! ";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(230, 16);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1147, 600);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(27, 155);
            label4.Name = "label4";
            label4.Size = new Size(243, 25);
            label4.TabIndex = 7;
            label4.Text = "Oto lista twoich rezerwacji:";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 183);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1083, 389);
            dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(433, 28);
            label3.Name = "label3";
            label3.Size = new Size(257, 25);
            label3.TabIndex = 5;
            label3.Text = "Witamy w hotelu Paradise !!!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(902, 21);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(btnZarzadzajKontem);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(edytuj);
            panel2.Controls.Add(stworz);
            panel2.Location = new Point(14, 157);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 459);
            panel2.TabIndex = 1;
            // 
            // btnZarzadzajKontem
            // 
            btnZarzadzajKontem.Location = new Point(33, 188);
            btnZarzadzajKontem.Margin = new Padding(3, 4, 3, 4);
            btnZarzadzajKontem.Name = "btnZarzadzajKontem";
            btnZarzadzajKontem.Size = new Size(127, 56);
            btnZarzadzajKontem.TabIndex = 4;
            btnZarzadzajKontem.Text = "Zarzadzaj kontem";
            btnZarzadzajKontem.UseVisualStyleBackColor = true;
            btnZarzadzajKontem.Click += btnZarzadzajKontem_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(33, 301);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(127, 56);
            button4.TabIndex = 3;
            button4.Text = "Wyloguj sie";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // edytuj
            // 
            edytuj.Location = new Point(33, 104);
            edytuj.Margin = new Padding(3, 4, 3, 4);
            edytuj.Name = "edytuj";
            edytuj.Size = new Size(127, 56);
            edytuj.TabIndex = 2;
            edytuj.Text = "Edytuj rezerwacje";
            edytuj.UseVisualStyleBackColor = true;
            edytuj.Click += edytuj_Click;
            // 
            // stworz
            // 
            stworz.Location = new Point(33, 28);
            stworz.Margin = new Padding(3, 4, 3, 4);
            stworz.Name = "stworz";
            stworz.Size = new Size(127, 56);
            stworz.TabIndex = 1;
            stworz.Text = "Stworz rezerwacje";
            stworz.UseVisualStyleBackColor = true;
            stworz.Click += stworz_Click;
            // 
            // Panel_Glowny_Klienta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1405, 631);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Panel_Glowny_Klienta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Klient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label3;
        private DataGridView dataGridView1;
        private Label label4;
        private Button btnZarzadzajKontem;
        private Button edytuj;
        private Button stworz;
    }
}
