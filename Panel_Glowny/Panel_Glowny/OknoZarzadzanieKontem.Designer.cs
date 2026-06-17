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
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 73);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(478, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 69);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblZarzadzanieHaslem
            // 
            lblZarzadzanieHaslem.AutoSize = true;
            lblZarzadzanieHaslem.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblZarzadzanieHaslem.Location = new Point(3, 12);
            lblZarzadzanieHaslem.Name = "lblZarzadzanieHaslem";
            lblZarzadzanieHaslem.Size = new Size(305, 46);
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
            panel2.Location = new Point(11, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 443);
            panel2.TabIndex = 1;
            // 
            // btnPowrot
            // 
            btnPowrot.BackColor = Color.FromArgb(255, 128, 128);
            btnPowrot.Location = new Point(237, 392);
            btnPowrot.Name = "btnPowrot";
            btnPowrot.Size = new Size(87, 35);
            btnPowrot.TabIndex = 14;
            btnPowrot.Text = "Powrot";
            btnPowrot.UseVisualStyleBackColor = false;
            btnPowrot.Click += btnPowrot_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(27, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 88);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblInfo.Location = new Point(185, 67);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(343, 40);
            lblInfo.TabIndex = 12;
            lblInfo.Text = "Aby zaktualizowac poszczegolne informacje \r\ndotyczace twojego konta kliknij przycisk \"Zmien\"";
            // 
            // lblwitajnazwa
            // 
            lblwitajnazwa.AutoSize = true;
            lblwitajnazwa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblwitajnazwa.Location = new Point(237, 29);
            lblwitajnazwa.Name = "lblwitajnazwa";
            lblwitajnazwa.Size = new Size(52, 20);
            lblwitajnazwa.TabIndex = 11;
            lblwitajnazwa.Text = "nazwa";
            // 
            // lblWitaj
            // 
            lblWitaj.AutoSize = true;
            lblWitaj.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWitaj.Location = new Point(185, 29);
            lblWitaj.Name = "lblWitaj";
            lblWitaj.Size = new Size(46, 20);
            lblWitaj.TabIndex = 10;
            lblWitaj.Text = "Witaj";
            // 
            // btnZmienPin
            // 
            btnZmienPin.Location = new Point(454, 352);
            btnZmienPin.Name = "btnZmienPin";
            btnZmienPin.Size = new Size(87, 35);
            btnZmienPin.TabIndex = 8;
            btnZmienPin.Text = "Zmień";
            btnZmienPin.UseVisualStyleBackColor = true;
            btnZmienPin.Click += btnZmianaPin_Click;
            // 
            // lblPinUzytkownika
            // 
            lblPinUzytkownika.AutoSize = true;
            lblPinUzytkownika.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPinUzytkownika.Location = new Point(27, 331);
            lblPinUzytkownika.Name = "lblPinUzytkownika";
            lblPinUzytkownika.Size = new Size(39, 20);
            lblPinUzytkownika.TabIndex = 7;
            lblPinUzytkownika.Text = "PIN:";
            // 
            // lblPobieranyPin
            // 
            lblPobieranyPin.AutoSize = true;
            lblPobieranyPin.Location = new Point(27, 365);
            lblPobieranyPin.Name = "lblPobieranyPin";
            lblPobieranyPin.Size = new Size(33, 20);
            lblPobieranyPin.TabIndex = 6;
            lblPobieranyPin.Text = "----";
            // 
            // btnZmienHaslo
            // 
            btnZmienHaslo.Location = new Point(454, 257);
            btnZmienHaslo.Name = "btnZmienHaslo";
            btnZmienHaslo.Size = new Size(87, 35);
            btnZmienHaslo.TabIndex = 5;
            btnZmienHaslo.Text = "Zmień";
            btnZmienHaslo.UseVisualStyleBackColor = true;
            btnZmienHaslo.Click += btnZmienHaslo_Click;
            // 
            // lblPobieraneHaslo
            // 
            lblPobieraneHaslo.AutoSize = true;
            lblPobieraneHaslo.Location = new Point(27, 271);
            lblPobieraneHaslo.Name = "lblPobieraneHaslo";
            lblPobieraneHaslo.Size = new Size(33, 20);
            lblPobieraneHaslo.TabIndex = 4;
            lblPobieraneHaslo.Text = "----";
            // 
            // lblHasloUzytkownika
            // 
            lblHasloUzytkownika.AutoSize = true;
            lblHasloUzytkownika.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHasloUzytkownika.Location = new Point(24, 239);
            lblHasloUzytkownika.Name = "lblHasloUzytkownika";
            lblHasloUzytkownika.Size = new Size(52, 20);
            lblHasloUzytkownika.TabIndex = 3;
            lblHasloUzytkownika.Text = "Haslo:";
            // 
            // lblpobieranaNazwa
            // 
            lblpobieranaNazwa.AutoSize = true;
            lblpobieranaNazwa.Location = new Point(27, 189);
            lblpobieranaNazwa.Name = "lblpobieranaNazwa";
            lblpobieranaNazwa.Size = new Size(33, 20);
            lblpobieranaNazwa.TabIndex = 1;
            lblpobieranaNazwa.Text = "----";
            // 
            // lblNazwaUzytkownika
            // 
            lblNazwaUzytkownika.AutoSize = true;
            lblNazwaUzytkownika.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNazwaUzytkownika.Location = new Point(24, 160);
            lblNazwaUzytkownika.Name = "lblNazwaUzytkownika";
            lblNazwaUzytkownika.Size = new Size(152, 20);
            lblNazwaUzytkownika.TabIndex = 0;
            lblNazwaUzytkownika.Text = "Nazwa uzytkownika:";
            // 
            // OknoZarzadzanieKontem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(592, 545);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OknoZarzadzanieKontem";
            StartPosition = FormStartPosition.CenterScreen;
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