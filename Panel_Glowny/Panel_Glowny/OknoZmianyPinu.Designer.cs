namespace Panele_Glowne
{
    partial class OknoZmianyPinu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoZmianyPinu));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnZmien = new Button();
            btnAnuluj = new Button();
            txtPowtorzPin = new TextBox();
            txtNowyPin = new TextBox();
            txtStaryPin = new TextBox();
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 82);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(327, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 1;
            label1.Text = "Zmiana PIN";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnZmien);
            panel2.Controls.Add(btnAnuluj);
            panel2.Controls.Add(txtPowtorzPin);
            panel2.Controls.Add(txtNowyPin);
            panel2.Controls.Add(txtStaryPin);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 327);
            panel2.TabIndex = 0;
            // 
            // btnZmien
            // 
            btnZmien.Location = new Point(195, 279);
            btnZmien.Name = "btnZmien";
            btnZmien.Size = new Size(94, 29);
            btnZmien.TabIndex = 0;
            btnZmien.Text = "Zmień";
            btnZmien.UseVisualStyleBackColor = true;
            btnZmien.Click += btnZmien_Click;
            // 
            // btnAnuluj
            // 
            btnAnuluj.Location = new Point(295, 279);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(94, 29);
            btnAnuluj.TabIndex = 1;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = true;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // txtPowtorzPin
            // 
            txtPowtorzPin.Location = new Point(26, 202);
            txtPowtorzPin.Name = "txtPowtorzPin";
            txtPowtorzPin.Size = new Size(266, 27);
            txtPowtorzPin.TabIndex = 2;
            // 
            // txtNowyPin
            // 
            txtNowyPin.Location = new Point(26, 132);
            txtNowyPin.Name = "txtNowyPin";
            txtNowyPin.Size = new Size(266, 27);
            txtNowyPin.TabIndex = 3;
            // 
            // txtStaryPin
            // 
            txtStaryPin.Location = new Point(26, 62);
            txtStaryPin.Name = "txtStaryPin";
            txtStaryPin.Size = new Size(266, 27);
            txtStaryPin.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(26, 179);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 5;
            label4.Text = "Powtórz nowy PIN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(26, 109);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 6;
            label3.Text = "Nowy PIN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(25, 39);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "Stary PIN:";
            // 
            // OknoZmianyPinu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(429, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OknoZmianyPinu";
            Text = "Zmiana PIN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStaryPin;
        private TextBox txtNowyPin;
        private TextBox txtPowtorzPin;
        private Button btnZmien;
        private Button btnAnuluj;
    }
}