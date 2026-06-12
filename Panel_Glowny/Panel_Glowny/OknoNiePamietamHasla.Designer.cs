namespace Panele_Glowne
{
    partial class OknoNiePamietamHasla
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
            lblResetowanieHasla = new Label();
            tboxPinPomocniczy = new TextBox();
            lblPinPomocniczy = new Label();
            btnAnuluj = new Button();
            btnZresetuj = new Button();
            tboxPowtorzHaslo = new TextBox();
            lblPowtorzHaslo = new Label();
            tboxHaslo = new TextBox();
            lblHaslo = new Label();
            tboxLogin = new TextBox();
            lblLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(lblResetowanieHasla);
            panel1.Controls.Add(tboxPinPomocniczy);
            panel1.Controls.Add(lblPinPomocniczy);
            panel1.Controls.Add(btnAnuluj);
            panel1.Controls.Add(btnZresetuj);
            panel1.Controls.Add(tboxPowtorzHaslo);
            panel1.Controls.Add(lblPowtorzHaslo);
            panel1.Controls.Add(tboxHaslo);
            panel1.Controls.Add(lblHaslo);
            panel1.Controls.Add(tboxLogin);
            panel1.Controls.Add(lblLogin);
            panel1.Location = new Point(10, 16);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 386);
            panel1.TabIndex = 0;
            // 
            // lblResetowanieHasla
            // 
            lblResetowanieHasla.AutoSize = true;
            lblResetowanieHasla.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblResetowanieHasla.Location = new Point(52, 22);
            lblResetowanieHasla.Name = "lblResetowanieHasla";
            lblResetowanieHasla.Size = new Size(253, 37);
            lblResetowanieHasla.TabIndex = 10;
            lblResetowanieHasla.Text = "Resetowanie hasla";
            // 
            // tboxPinPomocniczy
            // 
            tboxPinPomocniczy.Location = new Point(39, 257);
            tboxPinPomocniczy.Margin = new Padding(3, 2, 3, 2);
            tboxPinPomocniczy.Name = "tboxPinPomocniczy";
            tboxPinPomocniczy.Size = new Size(301, 23);
            tboxPinPomocniczy.TabIndex = 9;
            // 
            // lblPinPomocniczy
            // 
            lblPinPomocniczy.AutoSize = true;
            lblPinPomocniczy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPinPomocniczy.Location = new Point(39, 240);
            lblPinPomocniczy.Name = "lblPinPomocniczy";
            lblPinPomocniczy.Size = new Size(132, 15);
            lblPinPomocniczy.TabIndex = 8;
            lblPinPomocniczy.Text = "Podaj PIN pomocniczy:";
            // 
            // btnAnuluj
            // 
            btnAnuluj.BackColor = Color.FromArgb(255, 128, 128);
            btnAnuluj.Location = new Point(273, 335);
            btnAnuluj.Margin = new Padding(3, 2, 3, 2);
            btnAnuluj.Name = "btnAnuluj";
            btnAnuluj.Size = new Size(66, 28);
            btnAnuluj.TabIndex = 7;
            btnAnuluj.Text = "Anuluj";
            btnAnuluj.UseVisualStyleBackColor = false;
            btnAnuluj.Click += btnAnuluj_Click;
            // 
            // btnZresetuj
            // 
            btnZresetuj.Location = new Point(199, 335);
            btnZresetuj.Margin = new Padding(3, 2, 3, 2);
            btnZresetuj.Name = "btnZresetuj";
            btnZresetuj.Size = new Size(66, 28);
            btnZresetuj.TabIndex = 6;
            btnZresetuj.Text = "Zresetuj";
            btnZresetuj.UseVisualStyleBackColor = true;
            btnZresetuj.Click += btnZresetuj_Click;
            // 
            // tboxPowtorzHaslo
            // 
            tboxPowtorzHaslo.Location = new Point(39, 203);
            tboxPowtorzHaslo.Margin = new Padding(3, 2, 3, 2);
            tboxPowtorzHaslo.Name = "tboxPowtorzHaslo";
            tboxPowtorzHaslo.Size = new Size(301, 23);
            tboxPowtorzHaslo.TabIndex = 5;
            // 
            // lblPowtorzHaslo
            // 
            lblPowtorzHaslo.AutoSize = true;
            lblPowtorzHaslo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPowtorzHaslo.Location = new Point(39, 186);
            lblPowtorzHaslo.Name = "lblPowtorzHaslo";
            lblPowtorzHaslo.Size = new Size(88, 15);
            lblPowtorzHaslo.TabIndex = 4;
            lblPowtorzHaslo.Text = "Powtorz haslo:";
            // 
            // tboxHaslo
            // 
            tboxHaslo.Location = new Point(39, 153);
            tboxHaslo.Margin = new Padding(3, 2, 3, 2);
            tboxHaslo.Name = "tboxHaslo";
            tboxHaslo.Size = new Size(301, 23);
            tboxHaslo.TabIndex = 3;
            // 
            // lblHaslo
            // 
            lblHaslo.AutoSize = true;
            lblHaslo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHaslo.Location = new Point(39, 136);
            lblHaslo.Name = "lblHaslo";
            lblHaslo.Size = new Size(74, 15);
            lblHaslo.TabIndex = 2;
            lblHaslo.Text = "Nowe haslo:";
            // 
            // tboxLogin
            // 
            tboxLogin.Location = new Point(39, 98);
            tboxLogin.Margin = new Padding(3, 2, 3, 2);
            tboxLogin.Name = "tboxLogin";
            tboxLogin.Size = new Size(301, 23);
            tboxLogin.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLogin.Location = new Point(39, 81);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(40, 15);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login:";
            lblLogin.Click += label1_Click;
            // 
            // OknoNiePamietamHasla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(396, 411);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OknoNiePamietamHasla";
            Text = "OknoNiePamietamHasla";
            Load += OknoNiePamietamHasla_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblLogin;
        private TextBox tboxLogin;
        private Label lblHaslo;
        private TextBox tboxHaslo;
        private TextBox tboxPowtorzHaslo;
        private Label lblPowtorzHaslo;
        private Button btnAnuluj;
        private Button btnZresetuj;
        private Label lblResetowanieHasla;
        private TextBox tboxPinPomocniczy;
        private Label lblPinPomocniczy;
    }
}
