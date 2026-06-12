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
            button3 = new Button();
            button2 = new Button();
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 100);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(65, 55);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(56, 16);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
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
            panel3.Location = new Point(201, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1004, 450);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(24, 116);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 7;
            label4.Text = "Oto lista twoich rezerwacji:";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 137);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(948, 292);
            dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(379, 21);
            label3.Name = "label3";
            label3.Size = new Size(205, 20);
            label3.TabIndex = 5;
            label3.Text = "Witamy w hotelu Paradise !!!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(789, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(btnZarzadzajKontem);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(12, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 344);
            panel2.TabIndex = 1;
            // 
            // btnZarzadzajKontem
            // 
            btnZarzadzajKontem.Location = new Point(29, 141);
            btnZarzadzajKontem.Name = "btnZarzadzajKontem";
            btnZarzadzajKontem.Size = new Size(111, 42);
            btnZarzadzajKontem.TabIndex = 4;
            btnZarzadzajKontem.Text = "Zarzadzaj kontem";
            btnZarzadzajKontem.UseVisualStyleBackColor = true;
            btnZarzadzajKontem.Click += btnZarzadzajKontem_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(29, 226);
            button4.Name = "button4";
            button4.Size = new Size(111, 42);
            button4.TabIndex = 3;
            button4.Text = "Wyloguj sie";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(29, 78);
            button3.Name = "button3";
            button3.Size = new Size(111, 42);
            button3.TabIndex = 2;
            button3.Text = "Edytuj rezerwacje";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(29, 21);
            button2.Name = "button2";
            button2.Size = new Size(111, 42);
            button2.TabIndex = 1;
            button2.Text = "Stworz rezerwacje";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Panel_Glowny_Klienta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1376, 461);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Panel_Glowny_Klienta";
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
    }
}
