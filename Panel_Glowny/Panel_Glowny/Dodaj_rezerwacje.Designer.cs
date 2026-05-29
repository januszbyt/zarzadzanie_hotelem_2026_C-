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
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            przyjazd = new DateTimePicker();
            odjazd = new DateTimePicker();
            dodaj = new Button();
            powrot = new Button();
            label10 = new Label();
            Standard = new RadioButton();
            Deluxe = new RadioButton();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label.Location = new Point(234, 9);
            label.Name = "label";
            label.Size = new Size(354, 45);
            label.TabIndex = 0;
            label.Text = "DODAJ REZERWACJE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 96);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "E-mail gościa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 125);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 2;
            label2.Text = "Imie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 154);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Nazwisko";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 186);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Data przyjazdu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 215);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 5;
            label5.Text = "Data wyjazdu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 241);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 6;
            label6.Text = "Liczba nocy";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 267);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 7;
            label7.Text = "Ilu osobowy";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 293);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 8;
            label8.Text = "Kwota";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 322);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 9;
            label9.Text = "Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(147, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(147, 238);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(121, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(147, 290);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(121, 23);
            textBox8.TabIndex = 17;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(147, 319);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(121, 23);
            textBox9.TabIndex = 18;
            // 
            // przyjazd
            // 
            przyjazd.Location = new Point(147, 180);
            przyjazd.Name = "przyjazd";
            przyjazd.Size = new Size(200, 23);
            przyjazd.TabIndex = 19;
            przyjazd.MinDate = DateTime.Today.AddDays(0);
            przyjazd.Value = DateTime.Today.AddDays(0);
            // 
            // odjazd
            // 
            odjazd.CustomFormat = "";
            odjazd.Location = new Point(147, 209);
            odjazd.Name = "odjazd";
            odjazd.Size = new Size(200, 23);
            odjazd.TabIndex = 20;
            odjazd.MinDate = DateTime.Today.AddDays(1);
            odjazd.Value = DateTime.Today.AddDays(1);
            // 
            // dodaj
            // 
            dodaj.Location = new Point(559, 359);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(105, 36);
            dodaj.TabIndex = 21;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            // 
            // powrot
            // 
            powrot.Location = new Point(683, 359);
            powrot.Name = "powrot";
            powrot.Size = new Size(105, 36);
            powrot.TabIndex = 22;
            powrot.Text = "Powrót";
            powrot.UseVisualStyleBackColor = true;
            powrot.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 351);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 23;
            label10.Text = "Typ pokoju";
            // 
            // Standard
            // 
            Standard.AutoSize = true;
            Standard.Location = new Point(147, 349);
            Standard.Name = "Standard";
            Standard.Size = new Size(72, 19);
            Standard.TabIndex = 25;
            Standard.Text = "Standard";
            Standard.UseVisualStyleBackColor = true;
            // 
            // Deluxe
            // 
            Deluxe.AutoSize = true;
            Deluxe.Location = new Point(234, 349);
            Deluxe.Name = "Deluxe";
            Deluxe.Size = new Size(61, 19);
            Deluxe.TabIndex = 26;
            Deluxe.Text = "Deluxe";
            Deluxe.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox1.Location = new Point(147, 264);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 27;
            // 
            // Dodaj_rezerwacje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(Deluxe);
            Controls.Add(Standard);
            Controls.Add(label10);
            Controls.Add(powrot);
            Controls.Add(dodaj);
            Controls.Add(odjazd);
            Controls.Add(przyjazd);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Name = "Dodaj_rezerwacje";
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
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox9;
        private DateTimePicker przyjazd;
        private DateTimePicker odjazd;
        private Button dodaj;
        private Button powrot;
        private Label label10;
        private RadioButton Standard;
        private RadioButton Deluxe;
        private ComboBox comboBox1;
    }
}