namespace CRMSporKulubu.WinUI.PanelUI
{
	partial class AnasayfaGuncelDurum
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaGuncelDurum));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtFinansArama = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(25, 334);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 20;
			this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(205)))), ((int)(((byte)(242)))));
			this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.dataGridView1.RowTemplate.Height = 32;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(857, 216);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
			// 
			// cartesianChart1
			// 
			this.cartesianChart1.Location = new System.Drawing.Point(25, 38);
			this.cartesianChart1.Margin = new System.Windows.Forms.Padding(2);
			this.cartesianChart1.Name = "cartesianChart1";
			this.cartesianChart1.Size = new System.Drawing.Size(858, 252);
			this.cartesianChart1.TabIndex = 5;
			this.cartesianChart1.Text = "cartesianChart1";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Silver;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(864, 312);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(17, 17);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 91;
			this.pictureBox2.TabStop = false;
			// 
			// txtFinansArama
			// 
			this.txtFinansArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtFinansArama.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFinansArama.ForeColor = System.Drawing.Color.Black;
			this.txtFinansArama.Location = new System.Drawing.Point(709, 311);
			this.txtFinansArama.Margin = new System.Windows.Forms.Padding(2);
			this.txtFinansArama.Multiline = true;
			this.txtFinansArama.Name = "txtFinansArama";
			this.txtFinansArama.Size = new System.Drawing.Size(174, 20);
			this.txtFinansArama.TabIndex = 90;
			this.txtFinansArama.Text = "Kategori Ara";
			this.txtFinansArama.Click += new System.EventHandler(this.txtFinansArama_Click);
			this.txtFinansArama.TextChanged += new System.EventHandler(this.txtFinansArama_TextChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(326, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 23);
			this.label1.TabIndex = 92;
			this.label1.Text = "Yıllık Güncel Gelir Gider Grafiği";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(357, 305);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(215, 23);
			this.label3.TabIndex = 94;
			this.label3.Text = "Tüm Geciken Ödemeler";
			// 
			// AnasayfaGuncelDurum
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(894, 551);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txtFinansArama);
			this.Controls.Add(this.cartesianChart1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AnasayfaGuncelDurum";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AnasayfaGuncelDurum";
			this.Load += new System.EventHandler(this.AnasayfaGuncelDurum_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private LiveCharts.WinForms.CartesianChart cartesianChart1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtFinansArama;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}