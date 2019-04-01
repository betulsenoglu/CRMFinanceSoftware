namespace CRMSporKulubu.WinUI.Deneme
{
	partial class RaporMaas
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
			this.dgvRaporMaas = new System.Windows.Forms.DataGridView();
			this.btnSeciliAyMaas = new System.Windows.Forms.Button();
			this.btnOdemeEkle = new System.Windows.Forms.Button();
			this.cmbAylar = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvRaporMaas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRaporMaas
			// 
			this.dgvRaporMaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRaporMaas.Location = new System.Drawing.Point(40, 37);
			this.dgvRaporMaas.Name = "dgvRaporMaas";
			this.dgvRaporMaas.Size = new System.Drawing.Size(710, 280);
			this.dgvRaporMaas.TabIndex = 0;
			// 
			// btnSeciliAyMaas
			// 
			this.btnSeciliAyMaas.Location = new System.Drawing.Point(180, 339);
			this.btnSeciliAyMaas.Name = "btnSeciliAyMaas";
			this.btnSeciliAyMaas.Size = new System.Drawing.Size(75, 23);
			this.btnSeciliAyMaas.TabIndex = 1;
			this.btnSeciliAyMaas.Text = "Listele";
			this.btnSeciliAyMaas.UseVisualStyleBackColor = true;
			this.btnSeciliAyMaas.Click += new System.EventHandler(this.btnSeciliAyMaas_Click);
			// 
			// btnOdemeEkle
			// 
			this.btnOdemeEkle.Location = new System.Drawing.Point(675, 339);
			this.btnOdemeEkle.Name = "btnOdemeEkle";
			this.btnOdemeEkle.Size = new System.Drawing.Size(75, 23);
			this.btnOdemeEkle.TabIndex = 2;
			this.btnOdemeEkle.Text = "Ödendi";
			this.btnOdemeEkle.UseVisualStyleBackColor = true;
			this.btnOdemeEkle.Click += new System.EventHandler(this.btnOdemeEkle_Click);
			// 
			// cmbAylar
			// 
			this.cmbAylar.FormattingEnabled = true;
			this.cmbAylar.Location = new System.Drawing.Point(40, 341);
			this.cmbAylar.Name = "cmbAylar";
			this.cmbAylar.Size = new System.Drawing.Size(121, 21);
			this.cmbAylar.TabIndex = 3;
			// 
			// RaporMaas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmbAylar);
			this.Controls.Add(this.btnOdemeEkle);
			this.Controls.Add(this.btnSeciliAyMaas);
			this.Controls.Add(this.dgvRaporMaas);
			this.Name = "RaporMaas";
			this.Text = "RaporMaas";
			this.Load += new System.EventHandler(this.RaporMaas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRaporMaas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRaporMaas;
		private System.Windows.Forms.Button btnSeciliAyMaas;
		private System.Windows.Forms.Button btnOdemeEkle;
		private System.Windows.Forms.ComboBox cmbAylar;
	}
}