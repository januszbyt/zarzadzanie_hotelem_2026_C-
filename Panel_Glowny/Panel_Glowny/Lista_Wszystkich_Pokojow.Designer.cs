using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Panele_Glowne
{
    partial class Lista_Wszystkich_Pokojow
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            IdPokojuZajete = new DataGridViewTextBoxColumn();
            NumerPokojuZajete = new DataGridViewTextBoxColumn();
            TypPokojuZajete = new DataGridViewTextBoxColumn();
            CenaZaNocZajete = new DataGridViewTextBoxColumn();
            IloscOsobZajete = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            IdPokojuWolne = new DataGridViewTextBoxColumn();
            NumerPokojuWolne = new DataGridViewTextBoxColumn();
            TypPokojuWolne = new DataGridViewTextBoxColumn();
            CenaZaNocWolne = new DataGridViewTextBoxColumn();
            IloscOsobWolne = new DataGridViewTextBoxColumn();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            IdPokoju = new DataGridViewTextBoxColumn();
            NumerPokoju = new DataGridViewTextBoxColumn();
            TypPokoju = new DataGridViewTextBoxColumn();
            CenaZaNoc = new DataGridViewTextBoxColumn();
            IloscOsob = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            dataGridView4 = new DataGridView();
            dataGridView5 = new DataGridView();
            dataGridView6 = new DataGridView();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 39);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label1.Location = new Point(34, 10);
            label1.Name = "label1";
            label1.Size = new Size(116, 18);
            label1.TabIndex = 0;
            label1.Text = "Ekran - Pokoje";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 399);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 26);
            button1.TabIndex = 2;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 69);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(160, 33);
            button2.TabIndex = 3;
            button2.Text = "Wyświetl szczegóły";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(23, 141);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Standard";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(23, 177);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Deluxe";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(859, 330);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Czteroosobowe";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { IdPokojuZajete, NumerPokojuZajete, TypPokojuZajete, CenaZaNocZajete, IloscOsobZajete });
            dataGridView3.Location = new Point(0, 0);
            dataGridView3.Margin = new Padding(3, 2, 3, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(864, 337);
            dataGridView3.TabIndex = 0;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // IdPokojuZajete
            // 
            IdPokojuZajete.DataPropertyName = "IdPokoju";
            IdPokojuZajete.HeaderText = "IdPokoju";
            IdPokojuZajete.MinimumWidth = 6;
            IdPokojuZajete.Name = "IdPokojuZajete";
            IdPokojuZajete.Width = 175;
            // 
            // NumerPokojuZajete
            // 
            NumerPokojuZajete.DataPropertyName = "NumerPokoju";
            NumerPokojuZajete.HeaderText = "NumerPokoju";
            NumerPokojuZajete.MinimumWidth = 6;
            NumerPokojuZajete.Name = "NumerPokojuZajete";
            NumerPokojuZajete.Width = 175;
            // 
            // TypPokojuZajete
            // 
            TypPokojuZajete.DataPropertyName = "TypPokoju";
            TypPokojuZajete.HeaderText = "TypPokoju";
            TypPokojuZajete.MinimumWidth = 6;
            TypPokojuZajete.Name = "TypPokojuZajete";
            TypPokojuZajete.Width = 200;
            // 
            // CenaZaNocZajete
            // 
            CenaZaNocZajete.DataPropertyName = "CenaZaNoc";
            CenaZaNocZajete.HeaderText = "CenaZaNoc";
            CenaZaNocZajete.MinimumWidth = 6;
            CenaZaNocZajete.Name = "CenaZaNocZajete";
            CenaZaNocZajete.Width = 175;
            // 
            // IloscOsobZajete
            // 
            IloscOsobZajete.DataPropertyName = "IloscOsob";
            IloscOsobZajete.HeaderText = "Ilosc osob";
            IloscOsobZajete.MinimumWidth = 6;
            IloscOsobZajete.Name = "IloscOsobZajete";
            IloscOsobZajete.Width = 205;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(859, 330);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dwuosobowe";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { IdPokojuWolne, NumerPokojuWolne, TypPokojuWolne, CenaZaNocWolne, IloscOsobWolne });
            dataGridView2.Location = new Point(1, 1);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(864, 337);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // IdPokojuWolne
            // 
            IdPokojuWolne.DataPropertyName = "IdPokoju";
            IdPokojuWolne.HeaderText = "IdPokoju";
            IdPokojuWolne.MinimumWidth = 6;
            IdPokojuWolne.Name = "IdPokojuWolne";
            IdPokojuWolne.Width = 175;
            // 
            // NumerPokojuWolne
            // 
            NumerPokojuWolne.DataPropertyName = "NumerPokoju";
            NumerPokojuWolne.HeaderText = "NumerPokoju";
            NumerPokojuWolne.MinimumWidth = 6;
            NumerPokojuWolne.Name = "NumerPokojuWolne";
            NumerPokojuWolne.Width = 175;
            // 
            // TypPokojuWolne
            // 
            TypPokojuWolne.DataPropertyName = "TypPokoju";
            TypPokojuWolne.HeaderText = "TypPokoju";
            TypPokojuWolne.MinimumWidth = 6;
            TypPokojuWolne.Name = "TypPokojuWolne";
            TypPokojuWolne.Width = 200;
            // 
            // CenaZaNocWolne
            // 
            CenaZaNocWolne.DataPropertyName = "CenaZaNoc";
            CenaZaNocWolne.HeaderText = "CenaZaNoc";
            CenaZaNocWolne.MinimumWidth = 6;
            CenaZaNocWolne.Name = "CenaZaNocWolne";
            CenaZaNocWolne.Width = 175;
            // 
            // IloscOsobWolne
            // 
            IloscOsobWolne.DataPropertyName = "IloscOsob";
            IloscOsobWolne.HeaderText = "Ilosc osob";
            IloscOsobWolne.MinimumWidth = 6;
            IloscOsobWolne.Name = "IloscOsobWolne";
            IloscOsobWolne.Width = 205;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(859, 330);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Wszystkie";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdPokoju, NumerPokoju, TypPokoju, CenaZaNoc, IloscOsob });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(864, 337);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IdPokoju
            // 
            IdPokoju.DataPropertyName = "IdPokoju";
            IdPokoju.HeaderText = "IdPokoju";
            IdPokoju.MinimumWidth = 6;
            IdPokoju.Name = "IdPokoju";
            IdPokoju.Width = 175;
            // 
            // NumerPokoju
            // 
            NumerPokoju.DataPropertyName = "NumerPokoju";
            NumerPokoju.HeaderText = "NumerPokoju";
            NumerPokoju.MinimumWidth = 6;
            NumerPokoju.Name = "NumerPokoju";
            NumerPokoju.Width = 175;
            // 
            // TypPokoju
            // 
            TypPokoju.DataPropertyName = "TypPokoju";
            TypPokoju.HeaderText = "TypPokoju";
            TypPokoju.MinimumWidth = 6;
            TypPokoju.Name = "TypPokoju";
            TypPokoju.Width = 200;
            // 
            // CenaZaNoc
            // 
            CenaZaNoc.DataPropertyName = "CenaZaNoc";
            CenaZaNoc.HeaderText = "CenaZaNoc";
            CenaZaNoc.MinimumWidth = 6;
            CenaZaNoc.Name = "CenaZaNoc";
            CenaZaNoc.Width = 175;
            // 
            // IloscOsob
            // 
            IloscOsob.DataPropertyName = "IloscOsob";
            IloscOsob.HeaderText = "Ilosc osob";
            IloscOsob.MinimumWidth = 6;
            IloscOsob.Name = "IloscOsob";
            IloscOsob.Width = 205;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(208, 9);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(867, 358);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView6);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(859, 330);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Jednoosobowe";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(859, 330);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Trzyosobowe";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(dataGridView4);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(859, 330);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Pieciosobowe";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(3, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(853, 331);
            dataGridView4.TabIndex = 0;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(3, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(853, 327);
            dataGridView5.TabIndex = 0;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(4, 1);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.Size = new Size(855, 326);
            dataGridView6.TabIndex = 0;
            // 
            // Lista_Wszystkich_Pokojow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1103, 441);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Lista_Wszystkich_Pokojow";
            Text = "      ";
            Load += EkranPokoje_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn IdPokojuZajete;
        private DataGridViewTextBoxColumn NumerPokojuZajete;
        private DataGridViewTextBoxColumn TypPokojuZajete;
        private DataGridViewTextBoxColumn CenaZaNocZajete;
        private DataGridViewTextBoxColumn IloscOsobZajete;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn IdPokojuWolne;
        private DataGridViewTextBoxColumn NumerPokojuWolne;
        private DataGridViewTextBoxColumn TypPokojuWolne;
        private DataGridViewTextBoxColumn CenaZaNocWolne;
        private DataGridViewTextBoxColumn IloscOsobWolne;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdPokoju;
        private DataGridViewTextBoxColumn NumerPokoju;
        private DataGridViewTextBoxColumn TypPokoju;
        private DataGridViewTextBoxColumn CenaZaNoc;
        private DataGridViewTextBoxColumn IloscOsob;
        private TabControl tabControl1;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView dataGridView4;
        private DataGridView dataGridView6;
        private DataGridView dataGridView5;
    }
}

