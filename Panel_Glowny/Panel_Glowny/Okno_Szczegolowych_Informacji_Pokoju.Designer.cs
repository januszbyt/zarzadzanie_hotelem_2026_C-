using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Panele_Glowne
{
    partial class Okno_Szczegolowych_Informacji_Pokoju
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 92);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold);
            label3.Location = new Point(149, 51);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 46);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 1;
            label2.Text = "o nr.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 13.8F, FontStyle.Bold);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 27);
            label1.TabIndex = 0;
            label1.Text = "Szczegóły pokoju";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(label22);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(264, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 495);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label22.Location = new Point(239, 60);
            label22.Name = "label22";
            label22.Size = new Size(36, 20);
            label22.TabIndex = 18;
            label22.Text = "brak";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label21.Location = new Point(691, 197);
            label21.Name = "label21";
            label21.Size = new Size(36, 20);
            label21.TabIndex = 17;
            label21.Text = "brak";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label20.Location = new Point(687, 166);
            label20.Name = "label20";
            label20.Size = new Size(36, 20);
            label20.TabIndex = 16;
            label20.Text = "brak";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label19.Location = new Point(707, 134);
            label19.Name = "label19";
            label19.Size = new Size(36, 20);
            label19.TabIndex = 15;
            label19.Text = "brak";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label18.Location = new Point(687, 100);
            label18.Name = "label18";
            label18.Size = new Size(36, 20);
            label18.TabIndex = 14;
            label18.Text = "brak";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label17.Location = new Point(196, 199);
            label17.Name = "label17";
            label17.Size = new Size(36, 20);
            label17.TabIndex = 13;
            label17.Text = "brak";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label16.Location = new Point(125, 166);
            label16.Name = "label16";
            label16.Size = new Size(36, 20);
            label16.TabIndex = 12;
            label16.Text = "brak";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label15.Location = new Point(165, 134);
            label15.Name = "label15";
            label15.Size = new Size(36, 20);
            label15.TabIndex = 11;
            label15.Text = "brak";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label14.Location = new Point(113, 100);
            label14.Name = "label14";
            label14.Size = new Size(36, 20);
            label14.TabIndex = 10;
            label14.Text = "brak";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(533, 197);
            label13.Name = "label13";
            label13.Size = new Size(152, 22);
            label13.TabIndex = 9;
            label13.Text = "LACZNA KWOTA:";
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(49, 58);
            label12.Name = "label12";
            label12.Size = new Size(193, 22);
            label12.TabIndex = 8;
            label12.Text = "Ilosc osob w pokoju:";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(533, 164);
            label11.Name = "label11";
            label11.Size = new Size(148, 22);
            label11.TabIndex = 7;
            label11.Text = "DATA WYJAZDU:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(533, 132);
            label10.Name = "label10";
            label10.Size = new Size(168, 22);
            label10.TabIndex = 6;
            label10.Text = "DATA PRZYJAZDU:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(533, 100);
            label9.Name = "label9";
            label9.Size = new Size(157, 22);
            label9.TabIndex = 5;
            label9.Text = "ID_REZERWACJI:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(50, 197);
            label8.Name = "label8";
            label8.Size = new Size(140, 22);
            label8.TabIndex = 4;
            label8.Text = "NR_TELEFONU:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(50, 164);
            label7.Name = "label7";
            label7.Size = new Size(69, 22);
            label7.TabIndex = 3;
            label7.Text = "EMAIL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(50, 132);
            label6.Name = "label6";
            label6.Size = new Size(109, 22);
            label6.TabIndex = 2;
            label6.Text = "NAZWISKO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 100);
            label5.Name = "label5";
            label5.Size = new Size(54, 22);
            label5.TabIndex = 1;
            label5.Text = "IMIE:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Georgia", 13.8F, FontStyle.Bold);
            label4.Location = new Point(253, 7);
            label4.Name = "label4";
            label4.Size = new Size(347, 27);
            label4.TabIndex = 0;
            label4.Text = "Aktualna rezerwacja pokoju";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(40, 473);
            button1.Name = "button1";
            button1.Size = new Size(124, 29);
            button1.TabIndex = 2;
            button1.Text = "Powrot";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Okno_Szczegolowych_Informacji_Pokoju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1171, 530);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Okno_Szczegolowych_Informacji_Pokoju";
            Text = "OknoSzczegolowPokoju";
            Load += Okno_Szczegolowych_Informacji_Pokoju_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label13;
        private Label label12;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Button button1;
    }
}

