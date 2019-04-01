namespace CRMSporKulubu.WinUI.Deneme
{
	partial class RaporTest
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
			this.btnSeciliAyinRaporu = new System.Windows.Forms.Button();
			this.btnOdemeEkle = new System.Windows.Forms.Button();
			this.cmbAylar = new System.Windows.Forms.ComboBox();
			this.cmbRaporlar = new System.Windows.Forms.ComboBox();
			this.grbxDetay = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbYillar = new System.Windows.Forms.ComboBox();
			this.btnGecikenler = new System.Windows.Forms.Button();
			this.cmbMaasTip = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
			this.grbxDetay.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvRapor
			// 
			this.dgvRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRapor.Location = new System.Drawing.Point(12, 39);
			this.dgvRapor.Name = "dgvRapor";
			this.dgvRapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRapor.Size = new System.Drawing.Size(853, 248);
			this.dgvRapor.TabIndex = 0;
			this.dgvRapor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRapor_DataBindingComplete);
			// 
			// btnSeciliAyinRaporu
			// 
			this.btnSeciliAyinRaporu.Location = new System.Drawing.Point(329, 11);
			this.btnSeciliAyinRaporu.Name = "btnSeciliAyinRaporu";
			this.btnSeciliAyinRaporu.Size = new System.Drawing.Size(86, 22);
			this.btnSeciliAyinRaporu.TabIndex = 1;
			this.btnSeciliAyinRaporu.Text = "Listele";
			this.btnSeciliAyinRaporu.UseVisualStyleBackColor = true;
			this.btnSeciliAyinRaporu.Click += new System.EventHandler(this.btnSeciliAyinRaporu_Click);
			// 
			// btnOdemeEkle
			// 
			this.btnOdemeEkle.Location = new System.Drawing.Point(477, 306);
			this.btnOdemeEkle.Name = "btnOdemeEkle";
			this.btnOdemeEkle.Size = new System.Drawing.Size(179, 35);
			this.btnOdemeEkle.TabIndex = 2;
			this.btnOdemeEkle.Text = "Ödeme Durumunu Güncelle";
			this.btnOdemeEkle.UseVisualStyleBackColor = true;
			this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
			// 
			// cmbAylar
			// 
			this.cmbAylar.FormattingEnabled = true;
			this.cmbAylar.Location = new System.Drawing.Point(15, 11);
			this.cmbAylar.Name = "cmbAylar";
			this.cmbAylar.Size = new System.Drawing.Size(179, 21);
			this.cmbAylar.TabIndex = 3;
			// 
			// cmbRaporlar
			// 
			this.cmbRaporlar.FormattingEnabled = true;
			this.cmbRaporlar.Location = new System.Drawing.Point(740, 12);
			this.cmbRaporlar.Name = "cmbRaporlar";
			this.cmbRaporlar.Size = new System.Drawing.Size(121, 21);
			this.cmbRaporlar.TabIndex = 4;
			this.cmbRaporlar.SelectedIndexChanged += new System.EventHandler(this.cmbRaporlar_SelectedIndexChanged);
			// 
			// grbxDetay
			// 
			this.grbxDetay.Controls.Add(this.label6);
			this.grbxDetay.Controls.Add(this.label5);
			this.grbxDetay.Controls.Add(this.label4);
			this.grbxDetay.Controls.Add(this.label3);
			this.grbxDetay.Controls.Add(this.label2);
			this.grbxDetay.Controls.Add(this.label1);
			this.grbxDetay.Location = new System.Drawing.Point(12, 306);
			this.grbxDetay.Name = "grbxDetay";
			this.grbxDetay.Size = new System.Drawing.Size(252, 118);
			this.grbxDetay.TabIndex = 7;
			this.grbxDetay.TabStop = false;
			this.grbxDetay.Text = "Aylık Genel Toplam";
			this.grbxDetay.Enter += new System.EventHandler(this.grbxDetay_Enter);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(85, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "label6";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(85, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "label5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(85, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "label4";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ödenecek:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ödenen:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Toplam:";
			// 
			// cmbYillar
			// 
			this.cmbYillar.FormattingEnabled = true;
			this.cmbYillar.Location = new System.Drawing.Point(200, 11);
			this.cmbYillar.Name = "cmbYillar";
			this.cmbYillar.Size = new System.Drawing.Size(121, 21);
			this.cmbYillar.TabIndex = 8;
			// 
			// btnGecikenler
			// 
			this.btnGecikenler.Location = new System.Drawing.Point(421, 11);
			this.btnGecikenler.Name = "btnGecikenler";
			this.btnGecikenler.Size = new System.Drawing.Size(148, 22);
			this.btnGecikenler.TabIndex = 9;
			this.btnGecikenler.Text = "Ödeme Tarihi Geçenler";
			this.btnGecikenler.UseVisualStyleBackColor = true;
			this.btnGecikenler.Click += new System.EventHandler(this.btnGecikenler_Click);
			// 
			// cmbMaasTip
			// 
			this.cmbMaasTip.FormattingEnabled = true;
			this.cmbMaasTip.Location = new System.Drawing.Point(638, 11);
			this.cmbMaasTip.Name = "cmbMaasTip";
			this.cmbMaasTip.Size = new System.Drawing.Size(96, 21);
			this.cmbMaasTip.TabIndex = 10;
			this.cmbMaasTip.Visible = false;
			this.cmbMaasTip.SelectedIndexChanged += new System.EventHandler(this.cmbMaasTip_SelectedIndexChanged);
			// 
			// RaporTest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(873, 493);
			this.Controls.Add(this.cmbMaasTip);
			this.Controls.Add(this.btnGecikenler);
			this.Controls.Add(this.cmbYillar);
			this.Controls.Add(this.grbxDetay);
			this.Controls.Add(this.cmbRaporlar);
			this.Controls.Add(this.cmbAylar);
			this.Controls.Add(this.btnOdemeEkle);
			this.Controls.Add(this.btnSeciliAyinRaporu);
			this.Controls.Add(this.dgvRapor);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "RaporTest";
			this.Text = "RaporTest";
			this.Load += new System.EventHandler(this.RaporTest_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
			this.grbxDetay.ResumeLayout(false);
			this.grbxDetay.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRapor;
		private System.Windows.Forms.Button btnSeciliAyinRaporu;
		private System.Windows.Forms.Button btnOdemeEkle;
		private System.Windows.Forms.ComboBox cmbAylar;
		private System.Windows.Forms.ComboBox cmbRaporlar;
		private System.Windows.Forms.GroupBox grbxDetay;
		private System.Windows.Forms.ComboBox cmbYillar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGecikenler;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbMaasTip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}