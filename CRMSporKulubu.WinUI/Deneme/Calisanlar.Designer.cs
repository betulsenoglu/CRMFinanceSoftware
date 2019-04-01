namespace CRMSporKulubu.WinUI.Deneme
{
    partial class Calisanlar
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
			this.btnUyeEkle = new System.Windows.Forms.Button();
			this.rdbKadin = new System.Windows.Forms.RadioButton();
			this.rdbErkek = new System.Windows.Forms.RadioButton();
			this.dtpKayitTarihi = new System.Windows.Forms.DateTimePicker();
			this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
			this.nmrMaasBilgisi = new System.Windows.Forms.NumericUpDown();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.txtTCNo = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSporcuAra = new System.Windows.Forms.TextBox();
			this.chkRegisterYetkisi = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.nmrMaasBilgisi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUyeEkle
			// 
			this.btnUyeEkle.Location = new System.Drawing.Point(767, 290);
			this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnUyeEkle.Name = "btnUyeEkle";
			this.btnUyeEkle.Size = new System.Drawing.Size(212, 47);
			this.btnUyeEkle.TabIndex = 82;
			this.btnUyeEkle.Text = "Yeni Calisan Ekle";
			this.btnUyeEkle.UseVisualStyleBackColor = true;
			this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
			// 
			// rdbKadin
			// 
			this.rdbKadin.AutoSize = true;
			this.rdbKadin.Location = new System.Drawing.Point(201, 422);
			this.rdbKadin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rdbKadin.Name = "rdbKadin";
			this.rdbKadin.Size = new System.Drawing.Size(52, 17);
			this.rdbKadin.TabIndex = 81;
			this.rdbKadin.TabStop = true;
			this.rdbKadin.Text = "Kadin";
			this.rdbKadin.UseVisualStyleBackColor = true;
			// 
			// rdbErkek
			// 
			this.rdbErkek.AutoSize = true;
			this.rdbErkek.Location = new System.Drawing.Point(119, 422);
			this.rdbErkek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rdbErkek.Name = "rdbErkek";
			this.rdbErkek.Size = new System.Drawing.Size(53, 17);
			this.rdbErkek.TabIndex = 80;
			this.rdbErkek.TabStop = true;
			this.rdbErkek.Text = "Erkek";
			this.rdbErkek.UseVisualStyleBackColor = true;
			// 
			// dtpKayitTarihi
			// 
			this.dtpKayitTarihi.Location = new System.Drawing.Point(399, 397);
			this.dtpKayitTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtpKayitTarihi.Name = "dtpKayitTarihi";
			this.dtpKayitTarihi.Size = new System.Drawing.Size(151, 20);
			this.dtpKayitTarihi.TabIndex = 79;
			// 
			// dtpDogumTarihi
			// 
			this.dtpDogumTarihi.Location = new System.Drawing.Point(119, 389);
			this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dtpDogumTarihi.Name = "dtpDogumTarihi";
			this.dtpDogumTarihi.Size = new System.Drawing.Size(151, 20);
			this.dtpDogumTarihi.TabIndex = 78;
			// 
			// nmrMaasBilgisi
			// 
			this.nmrMaasBilgisi.Location = new System.Drawing.Point(399, 421);
			this.nmrMaasBilgisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nmrMaasBilgisi.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
			this.nmrMaasBilgisi.Name = "nmrMaasBilgisi";
			this.nmrMaasBilgisi.Size = new System.Drawing.Size(149, 20);
			this.nmrMaasBilgisi.TabIndex = 77;
			// 
			// txtAdres
			// 
			this.txtAdres.Location = new System.Drawing.Point(399, 359);
			this.txtAdres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(151, 32);
			this.txtAdres.TabIndex = 76;
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(399, 329);
			this.txtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(151, 20);
			this.txtTel.TabIndex = 75;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(399, 299);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(151, 20);
			this.txtEmail.TabIndex = 74;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(119, 357);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(151, 20);
			this.txtSoyad.TabIndex = 73;
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(119, 329);
			this.txtAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(151, 20);
			this.txtAd.TabIndex = 72;
			// 
			// txtTCNo
			// 
			this.txtTCNo.Location = new System.Drawing.Point(119, 299);
			this.txtTCNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTCNo.Name = "txtTCNo";
			this.txtTCNo.Size = new System.Drawing.Size(151, 20);
			this.txtTCNo.TabIndex = 71;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(454, 485);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(127, 42);
			this.btnDelete.TabIndex = 70;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(322, 485);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(127, 42);
			this.btnUpdate.TabIndex = 69;
			this.btnUpdate.Text = "Guncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(56, 422);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 13);
			this.label11.TabIndex = 68;
			this.label11.Text = "Cinsiyet:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(326, 422);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 13);
			this.label10.TabIndex = 67;
			this.label10.Text = "Maas Bilgisi:";
			// 
			// dgvCalisanlar
			// 
			this.dgvCalisanlar.AllowUserToOrderColumns = true;
			this.dgvCalisanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCalisanlar.Location = new System.Drawing.Point(23, 55);
			this.dgvCalisanlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvCalisanlar.MultiSelect = false;
			this.dgvCalisanlar.Name = "dgvCalisanlar";
			this.dgvCalisanlar.ReadOnly = true;
			this.dgvCalisanlar.RowTemplate.Height = 33;
			this.dgvCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCalisanlar.Size = new System.Drawing.Size(1002, 210);
			this.dgvCalisanlar.TabIndex = 66;
			this.dgvCalisanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellContentClick);
			this.dgvCalisanlar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCalisanlar_MouseDoubleClick);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(328, 400);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 13);
			this.label9.TabIndex = 65;
			this.label9.Text = "Kayit Tarihi:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(354, 361);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 64;
			this.label8.Text = "Adres:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(347, 331);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 63;
			this.label7.Text = "Telefon:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(353, 302);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 62;
			this.label6.Text = "E-mail:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(37, 389);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 61;
			this.label5.Text = "Dogum Tarihi:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(69, 358);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 60;
			this.label4.Text = "Soyad:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 331);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 59;
			this.label3.Text = "Ad:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 300);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 58;
			this.label2.Text = "T.C. Kimlik No:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(700, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 57;
			this.label1.Text = "Calisan Ara:";
			// 
			// txtSporcuAra
			// 
			this.txtSporcuAra.Location = new System.Drawing.Point(767, 26);
			this.txtSporcuAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtSporcuAra.Name = "txtSporcuAra";
			this.txtSporcuAra.Size = new System.Drawing.Size(199, 20);
			this.txtSporcuAra.TabIndex = 56;
			this.txtSporcuAra.TextChanged += new System.EventHandler(this.txtSporcuAra_TextChanged);
			// 
			// chkRegisterYetkisi
			// 
			this.chkRegisterYetkisi.AutoSize = true;
			this.chkRegisterYetkisi.Location = new System.Drawing.Point(399, 450);
			this.chkRegisterYetkisi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.chkRegisterYetkisi.Name = "chkRegisterYetkisi";
			this.chkRegisterYetkisi.Size = new System.Drawing.Size(99, 17);
			this.chkRegisterYetkisi.TabIndex = 83;
			this.chkRegisterYetkisi.Text = "Register Yetkisi";
			this.chkRegisterYetkisi.UseVisualStyleBackColor = true;
			// 
			// Calisanlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(999, 522);
			this.Controls.Add(this.chkRegisterYetkisi);
			this.Controls.Add(this.btnUyeEkle);
			this.Controls.Add(this.rdbKadin);
			this.Controls.Add(this.rdbErkek);
			this.Controls.Add(this.dtpKayitTarihi);
			this.Controls.Add(this.dtpDogumTarihi);
			this.Controls.Add(this.nmrMaasBilgisi);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.txtTCNo);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dgvCalisanlar);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSporcuAra);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Calisanlar";
			this.Text = "Calisanlar";
			this.Load += new System.EventHandler(this.Calisanlar_Load);
			((System.ComponentModel.ISupportInitialize)(this.nmrMaasBilgisi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.DateTimePicker dtpKayitTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.NumericUpDown nmrMaasBilgisi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSporcuAra;
        private System.Windows.Forms.CheckBox chkRegisterYetkisi;
    }
}