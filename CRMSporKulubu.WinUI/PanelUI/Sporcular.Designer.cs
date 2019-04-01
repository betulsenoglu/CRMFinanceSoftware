namespace CRMSporKulubu.WinUI.PanelUI
{
	partial class Sporcular
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sporcular));
			this.btnUyeEkle = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.nmrAidatBilgisi = new System.Windows.Forms.NumericUpDown();
			this.dtpKayitTarihi = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.rdbErkek = new System.Windows.Forms.RadioButton();
			this.rdbKadin = new System.Windows.Forms.RadioButton();
			this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAd = new System.Windows.Forms.TextBox();
			this.txtSoyad = new System.Windows.Forms.TextBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtTCNo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbTakimlar = new System.Windows.Forms.ComboBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtUyeAra = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nmrAidatBilgisi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUyeEkle
			// 
			this.btnUyeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnUyeEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnUyeEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnUyeEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnUyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUyeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUyeEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.btnUyeEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeEkle.Image")));
			this.btnUyeEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUyeEkle.Location = new System.Drawing.Point(721, 24);
			this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(2);
			this.btnUyeEkle.Name = "btnUyeEkle";
			this.btnUyeEkle.Size = new System.Drawing.Size(180, 37);
			this.btnUyeEkle.TabIndex = 73;
			this.btnUyeEkle.Text = "YENİ SPORCU EKLE";
			this.btnUyeEkle.UseVisualStyleBackColor = false;
			this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.btnDelete.Location = new System.Drawing.Point(774, 476);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 28);
			this.btnDelete.TabIndex = 72;
			this.btnDelete.Text = "SİL";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.btnUpdate.Location = new System.Drawing.Point(685, 476);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 28);
			this.btnUpdate.TabIndex = 71;
			this.btnUpdate.Text = "GÜNCELLE";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Gray;
			this.panel2.Location = new System.Drawing.Point(613, 350);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1, 180);
			this.panel2.TabIndex = 70;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Location = new System.Drawing.Point(319, 350);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1, 180);
			this.panel1.TabIndex = 69;
			// 
			// nmrAidatBilgisi
			// 
			this.nmrAidatBilgisi.Location = new System.Drawing.Point(634, 428);
			this.nmrAidatBilgisi.Margin = new System.Windows.Forms.Padding(2);
			this.nmrAidatBilgisi.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
			this.nmrAidatBilgisi.Name = "nmrAidatBilgisi";
			this.nmrAidatBilgisi.Size = new System.Drawing.Size(263, 20);
			this.nmrAidatBilgisi.TabIndex = 68;
			// 
			// dtpKayitTarihi
			// 
			this.dtpKayitTarihi.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
			this.dtpKayitTarihi.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
			this.dtpKayitTarihi.CalendarTitleForeColor = System.Drawing.Color.Gray;
			this.dtpKayitTarihi.Location = new System.Drawing.Point(344, 521);
			this.dtpKayitTarihi.Margin = new System.Windows.Forms.Padding(2);
			this.dtpKayitTarihi.Name = "dtpKayitTarihi";
			this.dtpKayitTarihi.Size = new System.Drawing.Size(247, 20);
			this.dtpKayitTarihi.TabIndex = 66;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(341, 504);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 65;
			this.label1.Text = "Kayıt Tarihi";
			// 
			// txtAdres
			// 
			this.txtAdres.BackColor = System.Drawing.Color.White;
			this.txtAdres.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAdres.ForeColor = System.Drawing.Color.Black;
			this.txtAdres.Location = new System.Drawing.Point(344, 437);
			this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(248, 65);
			this.txtAdres.TabIndex = 64;
			// 
			// txtTel
			// 
			this.txtTel.BackColor = System.Drawing.Color.White;
			this.txtTel.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTel.ForeColor = System.Drawing.Color.Black;
			this.txtTel.Location = new System.Drawing.Point(345, 396);
			this.txtTel.Margin = new System.Windows.Forms.Padding(2);
			this.txtTel.Multiline = true;
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(247, 27);
			this.txtTel.TabIndex = 63;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.White;
			this.txtEmail.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.ForeColor = System.Drawing.Color.Black;
			this.txtEmail.Location = new System.Drawing.Point(345, 350);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
			this.txtEmail.Multiline = true;
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(247, 27);
			this.txtEmail.TabIndex = 62;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(26, 517);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 61;
			this.label5.Text = "Cinsiyet";
			// 
			// rdbErkek
			// 
			this.rdbErkek.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbErkek.ForeColor = System.Drawing.Color.Black;
			this.rdbErkek.Location = new System.Drawing.Point(138, 513);
			this.rdbErkek.Name = "rdbErkek";
			this.rdbErkek.Size = new System.Drawing.Size(63, 24);
			this.rdbErkek.TabIndex = 59;
			this.rdbErkek.Text = "Erkek";
			// 
			// rdbKadin
			// 
			this.rdbKadin.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbKadin.ForeColor = System.Drawing.Color.Black;
			this.rdbKadin.Location = new System.Drawing.Point(81, 513);
			this.rdbKadin.Name = "rdbKadin";
			this.rdbKadin.Size = new System.Drawing.Size(61, 24);
			this.rdbKadin.TabIndex = 60;
			this.rdbKadin.Text = "Kadın";
			// 
			// dtpDogumTarihi
			// 
			this.dtpDogumTarihi.CalendarMonthBackground = System.Drawing.SystemColors.MenuText;
			this.dtpDogumTarihi.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
			this.dtpDogumTarihi.CalendarTitleForeColor = System.Drawing.Color.Gray;
			this.dtpDogumTarihi.Location = new System.Drawing.Point(29, 490);
			this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
			this.dtpDogumTarihi.Name = "dtpDogumTarihi";
			this.dtpDogumTarihi.Size = new System.Drawing.Size(263, 20);
			this.dtpDogumTarihi.TabIndex = 58;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(26, 469);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 57;
			this.label2.Text = "Doğum Tarihi";
			// 
			// txtAd
			// 
			this.txtAd.BackColor = System.Drawing.Color.White;
			this.txtAd.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAd.ForeColor = System.Drawing.Color.Black;
			this.txtAd.Location = new System.Drawing.Point(27, 396);
			this.txtAd.Margin = new System.Windows.Forms.Padding(2);
			this.txtAd.Multiline = true;
			this.txtAd.Name = "txtAd";
			this.txtAd.Size = new System.Drawing.Size(265, 27);
			this.txtAd.TabIndex = 56;
			// 
			// txtSoyad
			// 
			this.txtSoyad.BackColor = System.Drawing.Color.White;
			this.txtSoyad.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSoyad.ForeColor = System.Drawing.Color.Black;
			this.txtSoyad.Location = new System.Drawing.Point(27, 437);
			this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
			this.txtSoyad.Multiline = true;
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.Size = new System.Drawing.Size(265, 27);
			this.txtSoyad.TabIndex = 55;
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.DarkGray;
			this.panel11.Location = new System.Drawing.Point(27, 376);
			this.panel11.Margin = new System.Windows.Forms.Padding(2);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(265, 1);
			this.panel11.TabIndex = 52;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(27, 66);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 20;
			this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dataGridView1.RowTemplate.Height = 32;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(874, 263);
			this.dataGridView1.TabIndex = 50;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
			this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSporcular_MouseDoubleClick);
			// 
			// txtTCNo
			// 
			this.txtTCNo.BackColor = System.Drawing.Color.White;
			this.txtTCNo.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTCNo.ForeColor = System.Drawing.Color.Black;
			this.txtTCNo.Location = new System.Drawing.Point(27, 350);
			this.txtTCNo.Margin = new System.Windows.Forms.Padding(2);
			this.txtTCNo.Multiline = true;
			this.txtTCNo.Name = "txtTCNo";
			this.txtTCNo.Size = new System.Drawing.Size(265, 27);
			this.txtTCNo.TabIndex = 54;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(631, 410);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 84;
			this.label4.Text = "Maaş Bilgisi";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(631, 364);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 86;
			this.label6.Text = "Takım";
			// 
			// cmbTakimlar
			// 
			this.cmbTakimlar.FormattingEnabled = true;
			this.cmbTakimlar.Location = new System.Drawing.Point(634, 381);
			this.cmbTakimlar.Margin = new System.Windows.Forms.Padding(2);
			this.cmbTakimlar.Name = "cmbTakimlar";
			this.cmbTakimlar.Size = new System.Drawing.Size(263, 21);
			this.cmbTakimlar.TabIndex = 87;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Silver;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(272, 41);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(17, 17);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 89;
			this.pictureBox2.TabStop = false;
			// 
			// txtUyeAra
			// 
			this.txtUyeAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtUyeAra.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUyeAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.txtUyeAra.Location = new System.Drawing.Point(26, 39);
			this.txtUyeAra.Margin = new System.Windows.Forms.Padding(2);
			this.txtUyeAra.Name = "txtUyeAra";
			this.txtUyeAra.Size = new System.Drawing.Size(266, 22);
			this.txtUyeAra.TabIndex = 88;
			this.txtUyeAra.Text = "Sporcu Ara";
			this.txtUyeAra.Click += new System.EventHandler(this.txtUyeAra_Click);
			this.txtUyeAra.TextChanged += new System.EventHandler(this.txtUyeAra_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(343, 420);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 15);
			this.label10.TabIndex = 95;
			this.label10.Text = "Adres";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(342, 379);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 15);
			this.label9.TabIndex = 94;
			this.label9.Text = "Gsm";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(342, 332);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 15);
			this.label8.TabIndex = 93;
			this.label8.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(23, 420);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 15);
			this.label7.TabIndex = 92;
			this.label7.Text = "Soyad";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(26, 379);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 15);
			this.label3.TabIndex = 91;
			this.label3.Text = "Ad";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(26, 332);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(150, 15);
			this.label11.TabIndex = 90;
			this.label11.Text = "Tc Kimlik No - Pasaport No";
			// 
			// Sporcular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(912, 552);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txtUyeAra);
			this.Controls.Add(this.cmbTakimlar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnUyeEkle);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.nmrAidatBilgisi);
			this.Controls.Add(this.dtpKayitTarihi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.rdbErkek);
			this.Controls.Add(this.rdbKadin);
			this.Controls.Add(this.dtpDogumTarihi);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAd);
			this.Controls.Add(this.txtSoyad);
			this.Controls.Add(this.panel11);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtTCNo);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Sporcular";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sporcular";
			this.Load += new System.EventHandler(this.Sporcular_Load);
			((System.ComponentModel.ISupportInitialize)(this.nmrAidatBilgisi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUyeEkle;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown nmrAidatBilgisi;
		private System.Windows.Forms.DateTimePicker dtpKayitTarihi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton rdbErkek;
		private System.Windows.Forms.RadioButton rdbKadin;
		private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAd;
		private System.Windows.Forms.TextBox txtSoyad;
		private System.Windows.Forms.Panel panel11;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtTCNo;
		//private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbTakimlar;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtUyeAra;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label11;
	}
}