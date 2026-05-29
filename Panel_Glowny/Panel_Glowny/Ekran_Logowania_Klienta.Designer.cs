using System.Windows.Forms;
using System.Xml.Linq;


namespace Panele_Glowne
{
    partial class Ekran_Logowania_Klienta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ekran_Logowania_Klienta));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(183, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 480);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(271, 320);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 431);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 431);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.GradientInactiveCaption;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.Location = new Point(147, 361);
            button3.Name = "button3";
            button3.Size = new Size(120, 31);
            button3.TabIndex = 8;
            button3.Text = "Zarejestruj się";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.GradientInactiveCaption;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(289, 431);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 7;
            button2.Text = "Zamknij";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.GradientInactiveCaption;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(45, 361);
            button1.Name = "button1";
            button1.Size = new Size(84, 31);
            button1.TabIndex = 6;
            button1.Text = "Zaloguj się";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 320);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(45, 323);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "HASLO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(45, 283);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "LOGIN:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 280);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(45, 239);
            label1.Name = "label1";
            label1.Size = new Size(185, 28);
            label1.TabIndex = 0;
            label1.Text = "System Hotelowy";
            // 
            // Ekran_Logowania_Klienta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(751, 580);
            Controls.Add(panel1);
            Name = "Ekran_Logowania_Klienta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
    }
}
