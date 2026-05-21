namespace Panele_Glowne
{
    partial class Form_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Admin));
            panel2 = new Panel();
            button4 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            monthCalendar1 = new MonthCalendar();
            button6 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(9, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 433);
            panel2.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(34, 358);
            button4.Name = "button4";
            button4.Size = new Size(111, 42);
            button4.TabIndex = 3;
            button4.Text = "Wyloguj sie";
            button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(34, 15);
            button1.Name = "button1";
            button1.Size = new Size(111, 42);
            button1.TabIndex = 0;
            button1.Text = "Panel Glowny";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 100);
            panel1.TabIndex = 3;
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
            panel3.Controls.Add(monthCalendar1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(198, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(454, 539);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(135, 21);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 5;
            label3.Text = "Witamy Administracje";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(42, 376);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(34, 76);
            button2.Name = "button2";
            button2.Size = new Size(111, 42);
            button2.TabIndex = 4;
            button2.Text = "Dodaj Pracownika";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(34, 135);
            button3.Name = "button3";
            button3.Size = new Size(111, 42);
            button3.TabIndex = 5;
            button3.Text = "Usuń Pracownika";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(29, 270);
            button5.Name = "button5";
            button5.Size = new Size(126, 66);
            button5.TabIndex = 6;
            button5.Text = "Zarządzaj rezerwacjami";
            button5.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(1, 2);
            monthCalendar1.Location = new Point(84, 50);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // button6
            // 
            button6.Location = new Point(28, 183);
            button6.Name = "button6";
            button6.Size = new Size(126, 66);
            button6.TabIndex = 7;
            button6.Text = "Zarządzaj gościami Hotelu";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(881, 586);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form_Admin";
            Text = "Form_Admin";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox1;
        private MonthCalendar monthCalendar1;
        private Button button6;
    }
}