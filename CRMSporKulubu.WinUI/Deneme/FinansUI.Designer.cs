namespace CRMSporKulubu.WinUI.Deneme
{
    partial class FinansUI
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFinansSil = new System.Windows.Forms.Button();
            this.btnFinansGuncelle = new System.Windows.Forms.Button();
            this.dtpSonOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbGelirGiderTip = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmbSporcu = new System.Windows.Forms.ComboBox();
            this.dgvFinans = new System.Windows.Forms.DataGridView();
            this.cmbCalisanAdi = new System.Windows.Forms.ComboBox();
            this.cmbUyeAdi = new System.Windows.Forms.ComboBox();
            this.cmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrUrunAdet = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Uye :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Sporcu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Çalışan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Kategori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Gelir Gider Tip :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(479, 245);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(169, 20);
            this.txtTutar.TabIndex = 40;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(626, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 40);
            this.button3.TabIndex = 39;
            this.button3.Text = "Gelir/Gider Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFinansSil
            // 
            this.btnFinansSil.Location = new System.Drawing.Point(573, 309);
            this.btnFinansSil.Name = "btnFinansSil";
            this.btnFinansSil.Size = new System.Drawing.Size(75, 21);
            this.btnFinansSil.TabIndex = 38;
            this.btnFinansSil.Text = "Delete";
            this.btnFinansSil.UseVisualStyleBackColor = true;
            this.btnFinansSil.Click += new System.EventHandler(this.btnFinansSil_Click_1);
            // 
            // btnFinansGuncelle
            // 
            this.btnFinansGuncelle.Location = new System.Drawing.Point(479, 309);
            this.btnFinansGuncelle.Name = "btnFinansGuncelle";
            this.btnFinansGuncelle.Size = new System.Drawing.Size(75, 21);
            this.btnFinansGuncelle.TabIndex = 37;
            this.btnFinansGuncelle.Text = "Update";
            this.btnFinansGuncelle.UseVisualStyleBackColor = true;
            this.btnFinansGuncelle.Click += new System.EventHandler(this.btnFinansGuncelle_Click_2);
            // 
            // dtpSonOdemeTarihi
            // 
            this.dtpSonOdemeTarihi.Location = new System.Drawing.Point(479, 273);
            this.dtpSonOdemeTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSonOdemeTarihi.Name = "dtpSonOdemeTarihi";
            this.dtpSonOdemeTarihi.Size = new System.Drawing.Size(169, 20);
            this.dtpSonOdemeTarihi.TabIndex = 36;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(133, 402);
            this.txtNot.Margin = new System.Windows.Forms.Padding(2);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(81, 34);
            this.txtNot.TabIndex = 35;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(133, 256);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(158, 21);
            this.cmbKategori.TabIndex = 31;
            // 
            // cmbGelirGiderTip
            // 
            this.cmbGelirGiderTip.FormattingEnabled = true;
            this.cmbGelirGiderTip.Location = new System.Drawing.Point(133, 229);
            this.cmbGelirGiderTip.Name = "cmbGelirGiderTip";
            this.cmbGelirGiderTip.Size = new System.Drawing.Size(158, 21);
            this.cmbGelirGiderTip.TabIndex = 30;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(9, 22);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(154, 20);
            this.txtArama.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "-";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(383, 23);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // cmbSporcu
            // 
            this.cmbSporcu.FormattingEnabled = true;
            this.cmbSporcu.Location = new System.Drawing.Point(133, 310);
            this.cmbSporcu.Name = "cmbSporcu";
            this.cmbSporcu.Size = new System.Drawing.Size(158, 21);
            this.cmbSporcu.TabIndex = 33;
            // 
            // dgvFinans
            // 
            this.dgvFinans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinans.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFinans.Location = new System.Drawing.Point(12, 54);
            this.dgvFinans.Name = "dgvFinans";
            this.dgvFinans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinans.Size = new System.Drawing.Size(830, 150);
            this.dgvFinans.TabIndex = 25;
            this.dgvFinans.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFinans_MouseDoubleClick);
            // 
            // cmbCalisanAdi
            // 
            this.cmbCalisanAdi.FormattingEnabled = true;
            this.cmbCalisanAdi.Location = new System.Drawing.Point(133, 284);
            this.cmbCalisanAdi.Name = "cmbCalisanAdi";
            this.cmbCalisanAdi.Size = new System.Drawing.Size(158, 21);
            this.cmbCalisanAdi.TabIndex = 46;
            // 
            // cmbUyeAdi
            // 
            this.cmbUyeAdi.FormattingEnabled = true;
            this.cmbUyeAdi.Location = new System.Drawing.Point(133, 339);
            this.cmbUyeAdi.Name = "cmbUyeAdi";
            this.cmbUyeAdi.Size = new System.Drawing.Size(158, 21);
            this.cmbUyeAdi.TabIndex = 47;
            // 
            // cmbUrunAdi
            // 
            this.cmbUrunAdi.FormattingEnabled = true;
            this.cmbUrunAdi.Location = new System.Drawing.Point(133, 377);
            this.cmbUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUrunAdi.Name = "cmbUrunAdi";
            this.cmbUrunAdi.Size = new System.Drawing.Size(81, 21);
            this.cmbUrunAdi.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Urun Adi :";
            // 
            // nmrUrunAdet
            // 
            this.nmrUrunAdet.Location = new System.Drawing.Point(479, 221);
            this.nmrUrunAdet.Margin = new System.Windows.Forms.Padding(2);
            this.nmrUrunAdet.Name = "nmrUrunAdet";
            this.nmrUrunAdet.Size = new System.Drawing.Size(169, 20);
            this.nmrUrunAdet.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Urun Adet :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Tutar :";
            // 
            // FinansUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 460);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmrUrunAdet);
            this.Controls.Add(this.cmbUrunAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbUyeAdi);
            this.Controls.Add(this.cmbCalisanAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFinansSil);
            this.Controls.Add(this.btnFinansGuncelle);
            this.Controls.Add(this.dtpSonOdemeTarihi);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.cmbGelirGiderTip);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbSporcu);
            this.Controls.Add(this.dgvFinans);
            this.Name = "FinansUI";
            this.Text = "FinansUI";
            this.Load += new System.EventHandler(this.FinansUI_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUrunAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFinansSil;
        private System.Windows.Forms.Button btnFinansGuncelle;
        private System.Windows.Forms.DateTimePicker dtpSonOdemeTarihi;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.ComboBox cmbCalisan;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbGelirGiderTip;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cmbSporcu;
        private System.Windows.Forms.DataGridView dgvFinans;
        private System.Windows.Forms.ComboBox cmbCalisanAdi;
        private System.Windows.Forms.ComboBox cmbUyeAdi;
        private System.Windows.Forms.ComboBox cmbUrunAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrUrunAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}