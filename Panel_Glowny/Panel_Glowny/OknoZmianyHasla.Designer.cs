namespace Panele_Glowne
{
    partial class OknoZmianyHasla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoZmianyHasla));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnZmien = new Button();
            btnAnuluj = new Button();
            txtPowtorzHaslo = new TextBox();
            txtNoweHaslo = new TextBox();
            txtStareHaslo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 82);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(327, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 61);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(191, 38);
            label1.TabIndex = 0;
            label1.Text = "Zmiana hasła";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnZmien);
            panel2.Controls.Add(btnAnuluj);
            panel2.Controls.Add(txtPowtorzHaslo);
            panel2.Controls.Add(txtNoweHaslo);
            panel2.Controls.Add(txtStareHaslo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(11, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 327);
            panel2.TabIndex = 1;
            // 
            // btnZmien
            // 
            btnZmien.Location = new Point(195, 279);
            btnZmien.Name = "btnZmien";
            btnZmien.Size = new Size(94, 29);
            btnZmien.TabIndex = 7;
            btnZmien.Text = "Zmień";
            btnZmien.UseVisualStyleBackColor = true;
            btnZmien.Click += btnZmien_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.BackColor = Color.FromArgb(255, 128, 128);
            btnAnuluj.Location = new Point(295, 279);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(94, 29);
            btnAnuluj.TabIndex = 6;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = false;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // txtPowtorzHaslo
            // 
            txtPowtorzHaslo.Location = new Point(26, 203);
            txtPowtorzHaslo.Name = "txtPowtorzHaslo";
            txtPowtorzHaslo.Size = new Size(266, 27);
            txtPowtorzHaslo.TabIndex = 5;
            // 
            // txtNoweHaslo
            // 
            txtNoweHaslo.Location = new Point(26, 132);
            txtNoweHaslo.Name = "txtNoweHaslo";
            txtNoweHaslo.Size = new Size(266, 27);
            txtNoweHaslo.TabIndex = 4;
            // 
            // txtStareHaslo
            // 
            txtStareHaslo.Location = new Point(26, 61);
            txtStareHaslo.Name = "txtStareHaslo";
            txtStareHaslo.Size = new Size(266, 27);
            txtStareHaslo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(26, 179);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 2;
            label4.Text = "Powtorz nowe hasło:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 109);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 1;
            label3.Text = "Nowe hasło:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(25, 39);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 0;
            label2.Text = "Stare hasło:";
            // 
            // OknoZmianyHasla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(429, 451);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OknoZmianyHasla";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OknoZmianyHasla";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtStareHaslo;
        private Label label4;
        private Label label3;
        private Button btnZmien;
        private Button btnAnuluj;
        private TextBox txtPowtorzHaslo;
        private TextBox txtNoweHaslo;
    }
}