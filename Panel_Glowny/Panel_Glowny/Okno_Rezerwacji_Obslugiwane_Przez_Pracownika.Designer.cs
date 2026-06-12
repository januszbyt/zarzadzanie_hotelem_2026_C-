namespace Panele_Glowne
{
    partial class Okno_Rezerwacji_Obslugiwane_Przez_Pracownika
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
            Title = new Label();
            dataGridView1 = new DataGridView();
            idRezerwacji = new DataGridViewTextBoxColumn();
            Imie = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            telefon = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            numerPokoju = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            od = new DataGridViewTextBoxColumn();
            doKiedy = new DataGridViewTextBoxColumn();
            kwota = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            dodajToolStripMenuItem = new ToolStripMenuItem();
            edytujToolStripMenuItem = new ToolStripMenuItem();
            usuńToolStripMenuItem = new ToolStripMenuItem();
            powrótToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Title.Location = new Point(434, 30);
            Title.Name = "Title";
            Title.Size = new Size(182, 45);
            Title.TabIndex = 0;
            Title.Text = "Rezerwacje";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            // Tutaj definiujemy dynamiczne rozciąganie krawędzi tabeli
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // Tutaj wymuszamy, aby kolumny wypełniły całą dostępną przestrzeń
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idRezerwacji, Imie, Nazwisko, telefon, email, numerPokoju, status, od, doKiedy, kwota });
            dataGridView1.Location = new Point(25, 90);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1000, 420);
            dataGridView1.TabIndex = 1;
            // 
            // idRezerwacji
            // 
            idRezerwacji.HeaderText = "ID";
            idRezerwacji.Name = "idRezerwacji";
            idRezerwacji.ReadOnly = true;
            idRezerwacji.Visible = false;
            // 
            // Imie
            // 
            Imie.HeaderText = "Imię";
            Imie.Name = "Imie";
            Imie.ReadOnly = true;
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.Name = "Nazwisko";
            Nazwisko.ReadOnly = true;
            // 
            // telefon
            // 
            telefon.HeaderText = "Telefon";
            telefon.Name = "telefon";
            telefon.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "E-mail";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // numerPokoju
            // 
            numerPokoju.HeaderText = "Pokój";
            numerPokoju.Name = "numerPokoju";
            numerPokoju.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // od
            // 
            od.HeaderText = "Od";
            od.Name = "od";
            od.ReadOnly = true;
            // 
            // doKiedy
            // 
            doKiedy.HeaderText = "Do";
            doKiedy.Name = "doKiedy";
            doKiedy.ReadOnly = true;
            // 
            // kwota
            // 
            kwota.HeaderText = "Kwota";
            kwota.Name = "kwota";
            kwota.ReadOnly = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dodajToolStripMenuItem, edytujToolStripMenuItem, usuńToolStripMenuItem, powrótToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1050, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // dodajToolStripMenuItem
            // 
            dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            dodajToolStripMenuItem.Size = new Size(50, 20);
            dodajToolStripMenuItem.Text = "Dodaj";
            dodajToolStripMenuItem.Click += dodajToolStripMenuItem_Click;
            // 
            // edytujToolStripMenuItem
            // 
            edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            edytujToolStripMenuItem.Size = new Size(52, 20);
            edytujToolStripMenuItem.Text = "Edytuj";
            edytujToolStripMenuItem.Click += edytujToolStripMenuItem_Click;
            // 
            // usuńToolStripMenuItem
            // 
            usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            usuńToolStripMenuItem.Size = new Size(46, 20);
            usuńToolStripMenuItem.Text = "Usuń";
            usuńToolStripMenuItem.Click += usuńToolStripMenuItem_Click;
            // 
            // powrótToolStripMenuItem
            // 
            powrótToolStripMenuItem.BackColor = Color.FromArgb(255, 128, 128);
            powrótToolStripMenuItem.Name = "powrótToolStripMenuItem";
            powrótToolStripMenuItem.Size = new Size(57, 20);
            powrótToolStripMenuItem.Text = "Powrót";
            powrótToolStripMenuItem.Click += powrótToolStripMenuItem_Click;
            // 
            // Okno_Rezerwacji_Obslugiwane_Przez_Pracownika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 550);
            Controls.Add(dataGridView1);
            Controls.Add(Title);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Okno_Rezerwacji_Obslugiwane_Przez_Pracownika";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezerwacje - Panel Pracownika";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dodajToolStripMenuItem;
        private ToolStripMenuItem edytujToolStripMenuItem;
        private ToolStripMenuItem usuńToolStripMenuItem;

        private DataGridViewTextBoxColumn idRezerwacji;
        private DataGridViewTextBoxColumn Imie;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn telefon;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn numerPokoju;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn od;
        private DataGridViewTextBoxColumn doKiedy;
        private DataGridViewTextBoxColumn kwota;

        private ToolStripMenuItem powrótToolStripMenuItem;
    }
}