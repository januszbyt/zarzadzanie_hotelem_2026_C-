namespace Panele_Glowne
{
    partial class EkranRejestracji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkranRejestracji));
            panel1 = new Panel();
            wroc_button = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            rejestruj_button = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(wroc_button);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(rejestruj_button);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(137, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 488);
            panel1.TabIndex = 0;
            // 
            // wroc_button
            // 
            wroc_button.BackColor = SystemColors.ControlLight;
            wroc_button.FlatAppearance.MouseDownBackColor = SystemColors.GradientInactiveCaption;
            wroc_button.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
            wroc_button.FlatStyle = FlatStyle.Flat;
            wroc_button.Location = new Point(79, 366);
            wroc_button.Name = "wroc_button";
            wroc_button.Size = new Size(98, 35);
            wroc_button.TabIndex = 11;
            wroc_button.Text = "Wróć";
            wroc_button.UseVisualStyleBackColor = false;
            wroc_button.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold);
            label5.Location = new Point(79, 216);
            label5.Name = "label5";
            label5.Size = new Size(187, 28);
            label5.TabIndex = 9;
            label5.Text = "System Hotelowy";
            label5.Click += label5_Click;
            // 
            // rejestruj_button
            // 
            rejestruj_button.BackColor = SystemColors.ControlLight;
            rejestruj_button.FlatAppearance.MouseDownBackColor = SystemColors.GradientInactiveCaption;
            rejestruj_button.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
            rejestruj_button.FlatStyle = FlatStyle.Flat;
            rejestruj_button.Location = new Point(200, 366);
            rejestruj_button.Name = "rejestruj_button";
            rejestruj_button.Size = new Size(101, 35);
            rejestruj_button.TabIndex = 8;
            rejestruj_button.Text = "Zarejestruj się";
            rejestruj_button.UseVisualStyleBackColor = false;
            rejestruj_button.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 325);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(13, 328);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 6;
            label4.Text = "POWTORZ HASLO:";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 290);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(77, 293);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "HASLO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(79, 259);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "LOGIN:";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 441);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.GradientInactiveCaption;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(326, 434);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 0;
            button1.Text = "Zamknij";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EkranRejestracji
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(727, 568);
            Controls.Add(panel1);
            Name = "EkranRejestracji";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EkranRejestracji";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Button rejestruj_button;
        private Label label5;
        private PictureBox pictureBox1;
        private Button wroc_button;
    }
}