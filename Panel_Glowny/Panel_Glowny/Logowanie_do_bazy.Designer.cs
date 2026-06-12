namespace Panele_Glowne
{
    partial class Logowanie_do_bazy
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
            tytul = new Label();
            login = new TextBox();
            haslo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // tytul
            // 
            tytul.AutoSize = true;
            tytul.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            tytul.Location = new Point(22, 30);
            tytul.Name = "tytul";
            tytul.Size = new Size(327, 32);
            tytul.TabIndex = 0;
            tytul.Text = "Logowanie do Bazy Danych";
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 12F);
            login.Location = new Point(75, 170);
            login.Name = "login";
            login.Size = new Size(200, 29);
            login.TabIndex = 1;
            // 
            // haslo
            // 
            haslo.Font = new Font("Segoe UI", 12F);
            haslo.Location = new Point(75, 260);
            haslo.Name = "haslo";
            haslo.PasswordChar = '*';
            haslo.Size = new Size(200, 29);
            haslo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(95, 140);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 3;
            label1.Text = "Podaj login do USOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(95, 230);
            label2.Name = "label2";
            label2.Size = new Size(156, 21);
            label2.TabIndex = 4;
            label2.Text = "Podaj haslo do USOS";
            // 
            // button1
            // 
            button1.Location = new Point(119, 320);
            button1.Name = "button1";
            button1.Size = new Size(102, 51);
            button1.TabIndex = 5;
            button1.Text = "ZALOGUJ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnZaloguj_Click;
            // 
            // Logowanie_do_bazy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 420);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(haslo);
            Controls.Add(login);
            Controls.Add(tytul);
            Name = "Logowanie_do_bazy";
            Text = "Logowanie_do_bazy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tytul;
        private TextBox login;
        private TextBox haslo;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}