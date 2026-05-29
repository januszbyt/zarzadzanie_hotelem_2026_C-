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
            Imie = new DataGridViewTextBoxColumn();
            Nazwisko = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            osoby = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            od = new DataGridViewTextBoxColumn();
            doKiedy = new DataGridViewTextBoxColumn();
            kwota = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            dodajToolStripMenuItem = new ToolStripMenuItem();
            edytujToolStripMenuItem = new ToolStripMenuItem();
            usuńToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Title.Location = new Point(354, 9);
            Title.Name = "Title";
            Title.Size = new Size(182, 45);
            Title.TabIndex = 0;
            Title.Text = "Rezerwacje";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Imie, Nazwisko, email, osoby, status, od, doKiedy, kwota });
            dataGridView1.Location = new Point(28, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 394);
            dataGridView1.TabIndex = 1;
            // 
            // Imie
            // 
            Imie.HeaderText = "Imie";
            Imie.Name = "Imie";
            // 
            // Nazwisko
            // 
            Nazwisko.HeaderText = "Nazwisko";
            Nazwisko.Name = "Nazwisko";
            // 
            // email
            // 
            email.HeaderText = "e-mail";
            email.Name = "email";
            // 
            // osoby
            // 
            osoby.HeaderText = "L. osób";
            osoby.Name = "osoby";
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // od
            // 
            od.HeaderText = "Od";
            od.Name = "od";
            // 
            // doKiedy
            // 
            doKiedy.HeaderText = "Do";
            doKiedy.Name = "doKiedy";
            // 
            // kwota
            // 
            kwota.HeaderText = "kwota";
            kwota.Name = "kwota";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dodajToolStripMenuItem, edytujToolStripMenuItem, usuńToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 24);
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
            // 
            // button1
            // 
            button1.Location = new Point(757, 51);
            button1.Name = "button1";
            button1.Size = new Size(114, 26);
            button1.TabIndex = 3;
            button1.Text = "Powrot";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Okno_Rezerwacji_Obslugiwane_Przez_Pracownika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 510);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(Title);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Okno_Rezerwacji_Obslugiwane_Przez_Pracownika";
            Text = "Rezerwacje";
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
        private DataGridViewTextBoxColumn Imie;
        private DataGridViewTextBoxColumn Nazwisko;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn osoby;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn od;
        private DataGridViewTextBoxColumn doKiedy;
        private DataGridViewTextBoxColumn kwota;
        private Button button1;
    }
}