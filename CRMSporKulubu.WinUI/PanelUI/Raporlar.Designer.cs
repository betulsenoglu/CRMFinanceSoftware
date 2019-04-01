namespace CRMSporKulubu.WinUI.PanelUI
{
	partial class Raporlar
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
			this.dgvRapor = new System.Windows.Forms.DataGridView();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1111 = new System.Windows.Forms.Label();
			this.label111 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnSeciliAyinRaporu = new System.Windows.Forms.Button();
			this.btnGecikenler = new System.Windows.Forms.Button();
			this.cmbYillar = new System.Windows.Forms.ComboBox();
			this.cmbAylar = new System.Windows.Forms.ComboBox();
			this.cmbMaasTip = new System.Windows.Forms.ComboBox();
			this.cmbRaporlar = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnOdemeEkle = new System.Windows.Forms.Button();
			this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			this.cmbGrafikler = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvRapor
			// 
			this.dgvRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRapor.BackgroundColor = System.Drawing.Color.White;
			this.dgvRapor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRapor.Location = new System.Drawing.Point(12, 53);
			this.dgvRapor.Name = "dgvRapor";
			this.dgvRapor.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			this.dgvRapor.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvRapor.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dgvRapor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.dgvRapor.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dgvRapor.RowTemplate.Height = 32;
			this.dgvRapor.Size = new System.Drawing.Size(891, 205);
			this.dgvRapor.TabIndex = 51;
			this.dgvRapor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRapor_CellContentClick);
			this.dgvRapor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRapor_DataBindingComplete);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(219)))));
			this.panel5.Controls.Add(this.label7);
			this.panel5.Location = new System.Drawing.Point(733, 268);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(131, 33);
			this.panel5.TabIndex = 53;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.label7.Location = new System.Drawing.Point(2, 10);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 13);
			this.label7.TabIndex = 26;
			this.label7.Text = "Aylık Genel Toplam";
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label1111);
			this.panel4.Controls.Add(this.label111);
			this.panel4.Controls.Add(this.label11);
			this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel4.Location = new System.Drawing.Point(721, 285);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(183, 120);
			this.panel4.TabIndex = 52;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(94, 94);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 80;
			this.label6.Text = "label6";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(94, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 79;
			this.label5.Text = "label5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(94, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 78;
			this.label4.Text = "label4";
			// 
			// label1111
			// 
			this.label1111.AutoSize = true;
			this.label1111.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1111.ForeColor = System.Drawing.Color.DimGray;
			this.label1111.Location = new System.Drawing.Point(8, 92);
			this.label1111.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1111.Name = "label1111";
			this.label1111.Size = new System.Drawing.Size(60, 15);
			this.label1111.TabIndex = 77;
			this.label1111.Text = "Ödenecek";
			// 
			// label111
			// 
			this.label111.AutoSize = true;
			this.label111.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label111.ForeColor = System.Drawing.Color.DimGray;
			this.label111.Location = new System.Drawing.Point(19, 62);
			this.label111.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label111.Name = "label111";
			this.label111.Size = new System.Drawing.Size(49, 15);
			this.label111.TabIndex = 76;
			this.label111.Text = "Ödenen";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.DimGray;
			this.label11.Location = new System.Drawing.Point(21, 31);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 15);
			this.label11.TabIndex = 75;
			this.label11.Text = "Toplam";
			// 
			// btnSeciliAyinRaporu
			// 
			this.btnSeciliAyinRaporu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnSeciliAyinRaporu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnSeciliAyinRaporu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnSeciliAyinRaporu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnSeciliAyinRaporu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeciliAyinRaporu.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeciliAyinRaporu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.btnSeciliAyinRaporu.Location = new System.Drawing.Point(282, 25);
			this.btnSeciliAyinRaporu.Margin = new System.Windows.Forms.Padding(2);
			this.btnSeciliAyinRaporu.Name = "btnSeciliAyinRaporu";
			this.btnSeciliAyinRaporu.Size = new System.Drawing.Size(86, 23);
			this.btnSeciliAyinRaporu.TabIndex = 74;
			this.btnSeciliAyinRaporu.Text = "LISTELE";
			this.btnSeciliAyinRaporu.UseVisualStyleBackColor = false;
			this.btnSeciliAyinRaporu.Click += new System.EventHandler(this.btnSeciliAyinRaporu_Click);
			// 
			// btnGecikenler
			// 
			this.btnGecikenler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnGecikenler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnGecikenler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnGecikenler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnGecikenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGecikenler.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGecikenler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.btnGecikenler.Location = new System.Drawing.Point(377, 25);
			this.btnGecikenler.Margin = new System.Windows.Forms.Padding(2);
			this.btnGecikenler.Name = "btnGecikenler";
			this.btnGecikenler.Size = new System.Drawing.Size(155, 23);
			this.btnGecikenler.TabIndex = 75;
			this.btnGecikenler.Text = "ÖDEME TARIHI GEÇENLER";
			this.btnGecikenler.UseVisualStyleBackColor = false;
			this.btnGecikenler.Click += new System.EventHandler(this.btnGecikenler_Click);
			// 
			// cmbYillar
			// 
			this.cmbYillar.FormattingEnabled = true;
			this.cmbYillar.Location = new System.Drawing.Point(152, 27);
			this.cmbYillar.Name = "cmbYillar";
			this.cmbYillar.Size = new System.Drawing.Size(121, 21);
			this.cmbYillar.TabIndex = 77;
			// 
			// cmbAylar
			// 
			this.cmbAylar.FormattingEnabled = true;
			this.cmbAylar.Location = new System.Drawing.Point(12, 27);
			this.cmbAylar.Name = "cmbAylar";
			this.cmbAylar.Size = new System.Drawing.Size(131, 21);
			this.cmbAylar.TabIndex = 76;
			// 
			// cmbMaasTip
			// 
			this.cmbMaasTip.FormattingEnabled = true;
			this.cmbMaasTip.Location = new System.Drawing.Point(556, 27);
			this.cmbMaasTip.Name = "cmbMaasTip";
			this.cmbMaasTip.Size = new System.Drawing.Size(96, 21);
			this.cmbMaasTip.TabIndex = 79;
			this.cmbMaasTip.Visible = false;
			this.cmbMaasTip.SelectedIndexChanged += new System.EventHandler(this.cmbMaasTip_SelectedIndexChanged);
			// 
			// cmbRaporlar
			// 
			this.cmbRaporlar.FormattingEnabled = true;
			this.cmbRaporlar.Location = new System.Drawing.Point(654, 27);
			this.cmbRaporlar.Name = "cmbRaporlar";
			this.cmbRaporlar.Size = new System.Drawing.Size(121, 21);
			this.cmbRaporlar.TabIndex = 78;
			this.cmbRaporlar.SelectedIndexChanged += new System.EventHandler(this.cmbRaporlar_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 15);
			this.label1.TabIndex = 80;
			this.label1.Text = "Ay";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DimGray;
			this.label2.Location = new System.Drawing.Point(146, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 15);
			this.label2.TabIndex = 81;
			this.label2.Text = "Yıl";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DimGray;
			this.label3.Location = new System.Drawing.Point(592, 9);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 15);
			this.label3.TabIndex = 82;
			this.label3.Text = "Maaş Tipi";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.DimGray;
			this.label8.Location = new System.Drawing.Point(716, 9);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 15);
			this.label8.TabIndex = 83;
			this.label8.Text = "Raporlar";
			// 
			// btnOdemeEkle
			// 
			this.btnOdemeEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnOdemeEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.btnOdemeEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnOdemeEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
			this.btnOdemeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOdemeEkle.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOdemeEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(60)))));
			this.btnOdemeEkle.Location = new System.Drawing.Point(783, 25);
			this.btnOdemeEkle.Margin = new System.Windows.Forms.Padding(2);
			this.btnOdemeEkle.Name = "btnOdemeEkle";
			this.btnOdemeEkle.Size = new System.Drawing.Size(121, 23);
			this.btnOdemeEkle.TabIndex = 84;
			this.btnOdemeEkle.Text = "ÖDEME GÜNCELLE";
			this.btnOdemeEkle.UseVisualStyleBackColor = false;
			this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
			// 
			// cartesianChart1
			// 
			this.cartesianChart1.Location = new System.Drawing.Point(20, 29);
			this.cartesianChart1.Margin = new System.Windows.Forms.Padding(2);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(632, 240);
			this.cartesianChart1.TabIndex = 85;
			this.cartesianChart1.Text = "cartesianChart1";
			// 
			// cmbGrafikler
			// 
			this.cmbGrafikler.FormattingEnabled = true;
			this.cmbGrafikler.Location = new System.Drawing.Point(556, 7);
			this.cmbGrafikler.Name = "cmbGrafikler";
			this.cmbGrafikler.Size = new System.Drawing.Size(121, 21);
			this.cmbGrafikler.TabIndex = 86;
			this.cmbGrafikler.SelectedIndexChanged += new System.EventHandler(this.cmbGrafikler_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DimGray;
			this.label9.Location = new System.Drawing.Point(500, 9);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 15);
			this.label9.TabIndex = 87;
			this.label9.Text = "Grafikler";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.cartesianChart1);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.cmbGrafikler);
			this.panel1.Location = new System.Drawing.Point(12, 268);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(686, 282);
			this.panel1.TabIndex = 81;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// Raporlar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(915, 552);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.btnOdemeEkle);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbMaasTip);
			this.Controls.Add(this.cmbRaporlar);
			this.Controls.Add(this.cmbYillar);
			this.Controls.Add(this.cmbAylar);
			this.Controls.Add(this.btnGecikenler);
			this.Controls.Add(this.btnSeciliAyinRaporu);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.dgvRapor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Raporlar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Raporlar";
			this.Load += new System.EventHandler(this.Raporlar_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRapor;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label111;
		private System.Windows.Forms.Label label1111;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSeciliAyinRaporu;
		private System.Windows.Forms.Button btnGecikenler;
		private System.Windows.Forms.ComboBox cmbYillar;
		private System.Windows.Forms.ComboBox cmbAylar;
		private System.Windows.Forms.ComboBox cmbMaasTip;
		private System.Windows.Forms.ComboBox cmbRaporlar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnOdemeEkle;
		private LiveCharts.WinForms.CartesianChart cartesianChart1;
		private System.Windows.Forms.ComboBox cmbGrafikler;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel1;
	}
}