namespace Panele_Glowne
{
    partial class EkranPokoje
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            IdPokoju = new DataGridViewTextBoxColumn();
            NumerPokoju = new DataGridViewTextBoxColumn();
            TypPokoju = new DataGridViewTextBoxColumn();
            CenaZaNoc = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            IdPokojuWolne = new DataGridViewTextBoxColumn();
            NumerPokojuWolne = new DataGridViewTextBoxColumn();
            TypPokojuWolne = new DataGridViewTextBoxColumn();
            CenaZaNocWolne = new DataGridViewTextBoxColumn();
            StatusWolne = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            IdPokojuZajete = new DataGridViewTextBoxColumn();
            NumerPokojuZajete = new DataGridViewTextBoxColumn();
            TypPokojuZajete = new DataGridViewTextBoxColumn();
            CenaZaNocZajete = new DataGridViewTextBoxColumn();
            StatusZajete = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(238, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(991, 478);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(983, 445);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Wszystkie";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdPokoju, NumerPokoju, TypPokoju, CenaZaNoc, Status });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(987, 449);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdPokoju
            // 
            IdPokoju.HeaderText = "IdPokoju";
            IdPokoju.MinimumWidth = 6;
            IdPokoju.Name = "IdPokoju";
            IdPokoju.Width = 175;
            // 
            // NumerPokoju
            // 
            NumerPokoju.HeaderText = "NumerPokoju";
            NumerPokoju.MinimumWidth = 6;
            NumerPokoju.Name = "NumerPokoju";
            NumerPokoju.Width = 175;
            // 
            // TypPokoju
            // 
            TypPokoju.HeaderText = "TypPokoju";
            TypPokoju.MinimumWidth = 6;
            TypPokoju.Name = "TypPokoju";
            TypPokoju.Width = 200;
            // 
            // CenaZaNoc
            // 
            CenaZaNoc.HeaderText = "CenaZaNoc";
            CenaZaNoc.MinimumWidth = 6;
            CenaZaNoc.Name = "CenaZaNoc";
            CenaZaNoc.Width = 175;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 205;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(983, 445);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Wolne";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IdPokojuWolne, NumerPokojuWolne, TypPokojuWolne, CenaZaNocWolne, StatusWolne });
            dataGridView2.Location = new Point(1, 1);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(987, 449);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // IdPokojuWolne
            // 
            IdPokojuWolne.HeaderText = "IdPokoju";
            IdPokojuWolne.MinimumWidth = 6;
            IdPokojuWolne.Name = "IdPokojuWolne";
            IdPokojuWolne.Width = 175;
            // 
            // NumerPokojuWolne
            // 
            NumerPokojuWolne.HeaderText = "NumerPokoju";
            NumerPokojuWolne.MinimumWidth = 6;
            NumerPokojuWolne.Name = "NumerPokojuWolne";
            NumerPokojuWolne.Width = 175;
            // 
            // TypPokojuWolne
            // 
            TypPokojuWolne.HeaderText = "TypPokoju";
            TypPokojuWolne.MinimumWidth = 6;
            TypPokojuWolne.Name = "TypPokojuWolne";
            TypPokojuWolne.Width = 200;
            // 
            // CenaZaNocWolne
            // 
            CenaZaNocWolne.HeaderText = "CenaZaNoc";
            CenaZaNocWolne.MinimumWidth = 6;
            CenaZaNocWolne.Name = "CenaZaNocWolne";
            CenaZaNocWolne.Width = 175;
            // 
            // StatusWolne
            // 
            StatusWolne.HeaderText = "Status";
            StatusWolne.MinimumWidth = 6;
            StatusWolne.Name = "StatusWolne";
            StatusWolne.Width = 205;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(983, 445);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Zajęte";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { IdPokojuZajete, NumerPokojuZajete, TypPokojuZajete, CenaZaNocZajete, StatusZajete });
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(987, 449);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 51);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(39, 13);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 0;
            label1.Text = "Ekran - Pokoje";
            label1.Click += label1_Click;
            // 
            // IdPokojuZajete
            // 
            IdPokojuZajete.HeaderText = "IdPokoju";
            IdPokojuZajete.MinimumWidth = 6;
            IdPokojuZajete.Name = "IdPokojuZajete";
            IdPokojuZajete.Width = 175;
            // 
            // NumerPokojuZajete
            // 
            NumerPokojuZajete.HeaderText = "NumerPokoju";
            NumerPokojuZajete.MinimumWidth = 6;
            NumerPokojuZajete.Name = "NumerPokojuZajete";
            NumerPokojuZajete.Width = 175;
            // 
            // TypPokojuZajete
            // 
            TypPokojuZajete.HeaderText = "TypPokoju";
            TypPokojuZajete.MinimumWidth = 6;
            TypPokojuZajete.Name = "TypPokojuZajete";
            TypPokojuZajete.Width = 200;
            // 
            // CenaZaNocZajete
            // 
            CenaZaNocZajete.HeaderText = "CenaZaNoc";
            CenaZaNocZajete.MinimumWidth = 6;
            CenaZaNocZajete.Name = "CenaZaNocZajete";
            CenaZaNocZajete.Width = 175;
            // 
            // StatusZajete
            // 
            StatusZajete.HeaderText = "Status";
            StatusZajete.MinimumWidth = 6;
            StatusZajete.Name = "StatusZajete";
            StatusZajete.Width = 205;
            // 
            // button1
            // 
            button1.Location = new Point(12, 490);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(26, 92);
            button2.Name = "button2";
            button2.Size = new Size(183, 44);
            button2.TabIndex = 3;
            button2.Text = "Wyświetl szczegóły";
            button2.UseVisualStyleBackColor = true;
            // 
            // EkranPokoje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1255, 588);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Name = "EkranPokoje";
            Text = "      ";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdPokoju;
        private DataGridViewTextBoxColumn NumerPokoju;
        private DataGridViewTextBoxColumn TypPokoju;
        private DataGridViewTextBoxColumn CenaZaNoc;
        private DataGridViewTextBoxColumn Status;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IdPokojuWolne;
        private DataGridViewTextBoxColumn NumerPokojuWolne;
        private DataGridViewTextBoxColumn TypPokojuWolne;
        private DataGridViewTextBoxColumn CenaZaNocWolne;
        private DataGridViewTextBoxColumn StatusWolne;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn IdPokojuZajete;
        private DataGridViewTextBoxColumn NumerPokojuZajete;
        private DataGridViewTextBoxColumn TypPokojuZajete;
        private DataGridViewTextBoxColumn CenaZaNocZajete;
        private DataGridViewTextBoxColumn StatusZajete;
        private Button button1;
        private Button button2;
    }
}