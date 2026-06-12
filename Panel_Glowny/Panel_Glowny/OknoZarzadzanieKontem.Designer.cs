namespace Panele_Glowne
{
    partial class OknoZarzadzanieKontem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoZarzadzanieKontem));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblZarzadzanieHaslem = new Label();
            panel2 = new Panel();
            btnPowrot = new Button();
            pictureBox2 = new PictureBox();
            lblInfo = new Label();
            lblwitajnazwa = new Label();
            lblWitaj = new Label();
            btnZmienPin = new Button();
            lblPinUzytkownika = new Label();
            lblPobieranyPin = new Label();
            btnZmienHaslo = new Button();
            lblPobieraneHaslo = new Label();
            lblHasloUzytkownika = new Label();
            lblpobieranaNazwa = new Label();
            lblNazwaUzytkownika = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblZarzadzanieHaslem);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 55);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(418, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 52);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblZarzadzanieHaslem
            // 
            lblZarzadzanieHaslem.AutoSize = true;
            lblZarzadzanieHaslem.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblZarzadzanieHaslem.Location = new Point(3, 9);
            lblZarzadzanieHaslem.Name = "lblZarzadzanieHaslem";
            lblZarzadzanieHaslem.Size = new Size(247, 37);
            lblZarzadzanieHaslem.TabIndex = 0;
            lblZarzadzanieHaslem.Text = "Zarządzaj kontem";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(btnPowrot);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(lblInfo);
            panel2.Controls.Add(lblwitajnazwa);
            panel2.Controls.Add(lblWitaj);
            panel2.Controls.Add(btnZmienPin);
            panel2.Controls.Add(lblPinUzytkownika);
            panel2.Controls.Add(lblPobieranyPin);
            panel2.Controls.Add(btnZmienHaslo);
            panel2.Controls.Add(lblPobieraneHaslo);
            panel2.Controls.Add(lblHasloUzytkownika);
            panel2.Controls.Add(lblpobieranaNazwa);
            panel2.Controls.Add(lblNazwaUzytkownika);
            panel2.Location = new Point(10, 68);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 332);
            panel2.TabIndex = 1;
            // 
            // btnPowrot
            // 
            btnPowrot.BackColor = Color.FromArgb(255, 128, 128);
            btnPowrot.Location = new Point(207, 294);
            btnPowrot.Margin = new Padding(3, 2, 3, 2);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(76, 26);
            btnPowrot.TabIndex = 14;
            btnPowrot.Text = "Powrot";
            btnPowrot.UseVisualStyleBackColor = false;
            btnPowrot.Click += btnPowrot_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(21, 22);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(111, 66);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblInfo.Location = new Point(162, 50);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(266, 30);
            lblInfo.TabIndex = 12;
            lblInfo.Text = "Aby zaktualizowac poszczegolne informacje \r\ndotyczace twojego konta kliknij przycisk \"Zmien\"";
            // 
            // lblwitajnazwa
            // 
            lblwitajnazwa.AutoSize = true;
            lblwitajnazwa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblwitajnazwa.Location = new Point(207, 22);
            lblwitajnazwa.Name = "lblwitajnazwa";
            lblwitajnazwa.Size = new Size(41, 15);
            lblwitajnazwa.TabIndex = 11;
            lblwitajnazwa.Text = "nazwa";
            // 
            // lblWitaj
            // 
            lblWitaj.AutoSize = true;
            lblWitaj.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWitaj.Location = new Point(162, 22);
            lblWitaj.Name = "lblWitaj";
            lblWitaj.Size = new Size(36, 15);
            lblWitaj.TabIndex = 10;
            lblWitaj.Text = "Witaj";
            // 
            // btnZmienPin
            // 
            btnZmienPin.Location = new Point(397, 264);
            btnZmienPin.Margin = new Padding(3, 2, 3, 2);
            btnZmienPin.Name = "btnZmienPin";
            btnZmienPin.Size = new Size(76, 26);
            btnZmienPin.TabIndex = 8;
            btnZmienPin.Text = "Zmień";
            btnZmienPin.UseVisualStyleBackColor = true;
            btnZmienPin.Click += btnZmianaPin_Click;
            // 
            // lblPinUzytkownika
            // 
            lblPinUzytkownika.AutoSize = true;
            lblPinUzytkownika.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPinUzytkownika.Location = new Point(24, 248);
            lblPinUzytkownika.Name = "lblPinUzytkownika";
            lblPinUzytkownika.Size = new Size(30, 15);
            lblPinUzytkownika.TabIndex = 7;
            lblPinUzytkownika.Text = "PIN:";
            // 
            // lblPobieranyPin
            // 
            lblPobieranyPin.AutoSize = true;
            lblPobieranyPin.Location = new Point(24, 274);
            lblPobieranyPin.Name = "lblPobieranyPin";
            lblPobieranyPin.Size = new Size(27, 15);
            lblPobieranyPin.TabIndex = 6;
            lblPobieranyPin.Text = "----";
            // 
            // btnZmienHaslo
            // 
            btnZmienHaslo.Location = new Point(397, 193);
            btnZmienHaslo.Margin = new Padding(3, 2, 3, 2);
            btnZmienHaslo.Name = "btnZmienHaslo";
            btnZmienHaslo.Size = new Size(76, 26);
            btnZmienHaslo.TabIndex = 5;
            btnZmienHaslo.Text = "Zmień";
            btnZmienHaslo.UseVisualStyleBackColor = true;
            btnZmienHaslo.Click += btnZmienHaslo_Click;
            // 
            // lblPobieraneHaslo
            // 
            lblPobieraneHaslo.AutoSize = true;
            lblPobieraneHaslo.Location = new Point(24, 203);
            lblPobieraneHaslo.Name = "lblPobieraneHaslo";
            lblPobieraneHaslo.Size = new Size(27, 15);
            lblPobieraneHaslo.TabIndex = 4;
            lblPobieraneHaslo.Text = "----";
            // 
            // lblHasloUzytkownika
            // 
            lblHasloUzytkownika.AutoSize = true;
            lblHasloUzytkownika.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHasloUzytkownika.Location = new Point(21, 179);
            lblHasloUzytkownika.Name = "lblHasloUzytkownika";
            lblHasloUzytkownika.Size = new Size(40, 15);
            lblHasloUzytkownika.TabIndex = 3;
            lblHasloUzytkownika.Text = "Haslo:";
            // 
            // lblpobieranaNazwa
            // 
            lblpobieranaNazwa.AutoSize = true;
            lblpobieranaNazwa.Location = new Point(24, 142);
            lblpobieranaNazwa.Name = "lblpobieranaNazwa";
            lblpobieranaNazwa.Size = new Size(27, 15);
            lblpobieranaNazwa.TabIndex = 1;
            lblpobieranaNazwa.Text = "----";
            // 
            // lblNazwaUzytkownika
            // 
            lblNazwaUzytkownika.AutoSize = true;
            lblNazwaUzytkownika.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNazwaUzytkownika.Location = new Point(21, 120);
            lblNazwaUzytkownika.Name = "lblNazwaUzytkownika";
            lblNazwaUzytkownika.Size = new Size(121, 15);
            lblNazwaUzytkownika.TabIndex = 0;
            lblNazwaUzytkownika.Text = "Nazwa uzytkownika:";
            // 
            // OknoZarzadzanieKontem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(518, 409);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OknoZarzadzanieKontem";
            Text = "OknoZarzadzanieKontem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblZarzadzanieHaslem;
        private PictureBox pictureBox1;
        private Label lblNazwaUzytkownika;
        private Label lblPobieraneHaslo;
        private Label lblHasloUzytkownika;
        private Label lblpobieranaNazwa;
        private Button btnZmienPin;
        private Label lblPinUzytkownika;
        private Label lblPobieranyPin;
        private Button btnZmienHaslo;
        private Label lblInfo;
        private Label lblwitajnazwa;
        private Label lblWitaj;
        private PictureBox pictureBox2;
        private Button btnPowrot;
    }
}