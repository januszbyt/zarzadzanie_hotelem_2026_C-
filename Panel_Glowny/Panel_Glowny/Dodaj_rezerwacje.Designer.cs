namespace Panele_Glowne
{
    partial class Dodaj_rezerwacje
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
            label = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            email = new TextBox();
            imie = new TextBox();
            nazwisko = new TextBox();
            noce = new TextBox();
            kwota = new TextBox();
            przyjazd = new DateTimePicker();
            odjazd = new DateTimePicker();
            dodaj = new Button();
            powrot = new Button();
            label10 = new Label();
            Standard = new RadioButton();
            Deluxe = new RadioButton();
            osobowy = new ComboBox();
            labelTelefon = new Label();
            telefon = new TextBox();
            labelDokument = new Label();
            dokument = new TextBox();
            labelUwagi = new Label();
            uwagi = new TextBox();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label.Location = new Point(267, 12);
            label.Name = "label";
            label.Size = new Size(438, 54);
            label.TabIndex = 0;
            label.Text = "DODAJ REZERWACJE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 128);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "E-mail gościa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 167);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Imię";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 205);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 3;
            label3.Text = "Nazwisko";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 248);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 4;
            label4.Text = "Data przyjazdu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 287);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 5;
            label5.Text = "Data wyjazdu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 321);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 6;
            label6.Text = "Liczba nocy";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 356);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 7;
            label7.Text = "Ilu osobowy";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 431);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 8;
            label8.Text = "Kwota";
            // 
            // email
            // 
            email.Location = new Point(168, 124);
            email.Margin = new Padding(3, 4, 3, 4);
            email.Name = "email";
            email.Size = new Size(138, 27);
            email.TabIndex = 10;
            // 
            // imie
            // 
            imie.Location = new Point(168, 163);
            imie.Margin = new Padding(3, 4, 3, 4);
            imie.Name = "imie";
            imie.Size = new Size(138, 27);
            imie.TabIndex = 11;
            // 
            // nazwisko
            // 
            nazwisko.Location = new Point(168, 201);
            nazwisko.Margin = new Padding(3, 4, 3, 4);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(138, 27);
            nazwisko.TabIndex = 12;
            // 
            // noce
            // 
            noce.Location = new Point(168, 317);
            noce.Margin = new Padding(3, 4, 3, 4);
            noce.Name = "noce";
            noce.ReadOnly = true;
            noce.Size = new Size(138, 27);
            noce.TabIndex = 15;
            // 
            // kwota
            // 
            kwota.Location = new Point(168, 427);
            kwota.Margin = new Padding(3, 4, 3, 4);
            kwota.Name = "kwota";
            kwota.ReadOnly = true;
            kwota.Size = new Size(138, 27);
            kwota.TabIndex = 17;
            // 
            // przyjazd
            // 
            przyjazd.Location = new Point(168, 240);
            przyjazd.Margin = new Padding(3, 4, 3, 4);
            przyjazd.MinDate = new DateTime(2026, 6, 11, 0, 0, 0, 0);
            przyjazd.Name = "przyjazd";
            przyjazd.Size = new Size(228, 27);
            przyjazd.TabIndex = 19;
            przyjazd.Value = new DateTime(2026, 6, 11, 0, 0, 0, 0);
            przyjazd.ValueChanged += przyjazd_ValueChanged;
            // 
            // odjazd
            // 
            odjazd.CustomFormat = "";
            odjazd.Location = new Point(168, 279);
            odjazd.Margin = new Padding(3, 4, 3, 4);
            odjazd.MinDate = new DateTime(2026, 6, 12, 0, 0, 0, 0);
            odjazd.Name = "odjazd";
            odjazd.Size = new Size(228, 27);
            odjazd.TabIndex = 20;
            odjazd.Value = new DateTime(2026, 6, 12, 0, 0, 0, 0);
            odjazd.ValueChanged += Odjazd_noce_ValueChanged;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(639, 479);
            dodaj.Margin = new Padding(3, 4, 3, 4);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(120, 48);
            dodaj.TabIndex = 21;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // powrot
            // 
            powrot.BackColor = Color.FromArgb(255, 128, 128);
            powrot.Location = new Point(781, 479);
            powrot.Margin = new Padding(3, 4, 3, 4);
            powrot.Name = "powrot";
            powrot.Size = new Size(120, 48);
            powrot.TabIndex = 22;
            powrot.Text = "Powrót";
            powrot.UseVisualStyleBackColor = false;
            powrot.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 393);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 23;
            label10.Text = "Typ pokoju";
            // 
            // Standard
            // 
            Standard.AutoSize = true;
            Standard.Checked = true;
            Standard.Location = new Point(168, 391);
            Standard.Margin = new Padding(3, 4, 3, 4);
            Standard.Name = "Standard";
            Standard.Size = new Size(90, 24);
            Standard.TabIndex = 25;
            Standard.TabStop = true;
            Standard.Text = "Standard";
            Standard.UseVisualStyleBackColor = true;
            Standard.CheckedChanged += kwotaPokoi;
            // 
            // Deluxe
            // 
            Deluxe.AutoSize = true;
            Deluxe.Location = new Point(267, 391);
            Deluxe.Margin = new Padding(3, 4, 3, 4);
            Deluxe.Name = "Deluxe";
            Deluxe.Size = new Size(76, 24);
            Deluxe.TabIndex = 26;
            Deluxe.Text = "Deluxe";
            Deluxe.UseVisualStyleBackColor = true;
            Deluxe.CheckedChanged += kwotaPokoi;
            // 
            // osobowy
            // 
            osobowy.DisplayMember = "1";
            osobowy.DropDownStyle = ComboBoxStyle.DropDownList;
            osobowy.FormattingEnabled = true;
            osobowy.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            osobowy.Location = new Point(168, 352);
            osobowy.Margin = new Padding(3, 4, 3, 4);
            osobowy.Name = "osobowy";
            osobowy.Size = new Size(138, 28);
            osobowy.TabIndex = 27;
            osobowy.SelectedIndexChanged += kwotaPokoi;
            osobowy.DataContextChanged += kwotaPokoi;
            // 
            // labelTelefon
            // 
            labelTelefon.AutoSize = true;
            labelTelefon.Location = new Point(457, 128);
            labelTelefon.Name = "labelTelefon";
            labelTelefon.Size = new Size(58, 20);
            labelTelefon.TabIndex = 28;
            labelTelefon.Text = "Telefon";
            // 
            // telefon
            // 
            telefon.Location = new Point(606, 124);
            telefon.Margin = new Padding(3, 4, 3, 4);
            telefon.Name = "telefon";
            telefon.Size = new Size(171, 27);
            telefon.TabIndex = 29;
            // 
            // labelDokument
            // 
            labelDokument.AutoSize = true;
            labelDokument.Location = new Point(457, 167);
            labelDokument.Name = "labelDokument";
            labelDokument.Size = new Size(135, 20);
            labelDokument.TabIndex = 30;
            labelDokument.Text = "Nr dok. tożsamości";
            // 
            // dokument
            // 
            dokument.Location = new Point(606, 163);
            dokument.Margin = new Padding(3, 4, 3, 4);
            dokument.Name = "dokument";
            dokument.Size = new Size(171, 27);
            dokument.TabIndex = 31;
            // 
            // labelUwagi
            // 
            labelUwagi.AutoSize = true;
            labelUwagi.Location = new Point(457, 205);
            labelUwagi.Name = "labelUwagi";
            labelUwagi.Size = new Size(51, 20);
            labelUwagi.TabIndex = 32;
            labelUwagi.Text = "Uwagi";
            // 
            // uwagi
            // 
            uwagi.Location = new Point(606, 201);
            uwagi.Margin = new Padding(3, 4, 3, 4);
            uwagi.Multiline = true;
            uwagi.Name = "uwagi";
            uwagi.Size = new Size(228, 105);
            uwagi.TabIndex = 33;
            // 
            // Dodaj_rezerwacje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(uwagi);
            Controls.Add(labelUwagi);
            Controls.Add(dokument);
            Controls.Add(labelDokument);
            Controls.Add(telefon);
            Controls.Add(labelTelefon);
            Controls.Add(Deluxe);
            Controls.Add(Standard);
            Controls.Add(osobowy);
            Controls.Add(label10);
            Controls.Add(powrot);
            Controls.Add(dodaj);
            Controls.Add(odjazd);
            Controls.Add(przyjazd);
            Controls.Add(kwota);
            Controls.Add(noce);
            Controls.Add(nazwisko);
            Controls.Add(imie);
            Controls.Add(email);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dodaj_rezerwacje";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj rezerwacje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox noce;
        private TextBox kwota;
        private DateTimePicker przyjazd;
        private DateTimePicker odjazd;
        private Button dodaj;
        private Button powrot;
        private Label label10;
        private RadioButton Standard;
        private RadioButton Deluxe;
        private ComboBox osobowy;
        private TextBox email;
        private TextBox imie;
        private TextBox nazwisko;

        // Deklaracja nowych elementów
        private Label labelTelefon;
        private TextBox telefon;
        private Label labelDokument;
        private TextBox dokument;
        private Label labelUwagi;
        private TextBox uwagi;
    }
}