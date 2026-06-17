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
            tytul.Location = new Point(25, 40);
            tytul.Name = "tytul";
            tytul.Size = new Size(401, 41);
            tytul.TabIndex = 0;
            tytul.Text = "Logowanie do Bazy Danych";
            // 
            // login
            // 
            login.Font = new Font("Segoe UI", 12F);
            login.Location = new Point(86, 227);
            login.Margin = new Padding(3, 4, 3, 4);
            login.Name = "login";
            login.Size = new Size(228, 34);
            login.TabIndex = 1;
            // 
            // haslo
            // 
            haslo.Font = new Font("Segoe UI", 12F);
            haslo.Location = new Point(86, 347);
            haslo.Margin = new Padding(3, 4, 3, 4);
            haslo.Name = "haslo";
            haslo.PasswordChar = '*';
            haslo.Size = new Size(228, 34);
            haslo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(109, 187);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 3;
            label1.Text = "Podaj login do USOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(109, 307);
            label2.Name = "label2";
            label2.Size = new Size(197, 28);
            label2.TabIndex = 4;
            label2.Text = "Podaj haslo do USOS";
            // 
            // button1
            // 
            button1.Location = new Point(136, 427);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 68);
            button1.TabIndex = 5;
            button1.Text = "ZALOGUJ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnZaloguj_Click;
            // 
            // Logowanie_do_bazy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 560);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(haslo);
            Controls.Add(login);
            Controls.Add(tytul);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Logowanie_do_bazy";
            StartPosition = FormStartPosition.CenterScreen;
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