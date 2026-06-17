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
            btnZarzadzajKontem = new Button();
            button1 = new Button();
            button6 = new Button();
            button2 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(btnZarzadzajKontem);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Location = new Point(10, 157);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 577);
            panel2.TabIndex = 4;
            // 
            // btnZarzadzajKontem
            // 
            btnZarzadzajKontem.Location = new Point(24, 467);
            btnZarzadzajKontem.Margin = new Padding(3, 4, 3, 4);
            btnZarzadzajKontem.Name = "btnZarzadzajKontem";
            btnZarzadzajKontem.Size = new Size(154, 39);
            btnZarzadzajKontem.TabIndex = 9;
            btnZarzadzajKontem.Text = "Zarzadzaj kontem";
            btnZarzadzajKontem.UseVisualStyleBackColor = true;
            btnZarzadzajKontem.Click += btnZarzadzajKontem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 291);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(127, 88);
            button1.TabIndex = 8;
            button1.Text = "Szczególy pokoi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(39, 164);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(127, 88);
            button6.TabIndex = 7;
            button6.Text = "Zarządzaj gościami Hotelu";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.Location = new Point(39, 37);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(127, 88);
            button2.TabIndex = 4;
            button2.Text = "Zarządzaj Pracownikami";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(39, 514);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(127, 56);
            button4.TabIndex = 3;
            button4.Text = "Wyloguj sie";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 133);
            panel1.TabIndex = 3;
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
            label2.Click += label2_Click;
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
            panel3.Controls.Add(monthCalendar1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(226, 16);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(519, 719);
            panel3.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(1, 2);
            monthCalendar1.Location = new Point(96, 67);
            monthCalendar1.Margin = new Padding(10, 12, 10, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(154, 28);
            label3.Name = "label3";
            label3.Size = new Size(202, 25);
            label3.TabIndex = 5;
            label3.Text = "Witamy Administracje";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(48, 501);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(765, 781);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button2;
        private Button button4;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox1;
        private MonthCalendar monthCalendar1;
        private Button button6;
        private Button button1;
        private Button btnZarzadzajKontem;
    }
}