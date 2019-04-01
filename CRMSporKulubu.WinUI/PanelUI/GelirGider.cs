using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using CRMSporKulubu.WinUI.MenuUI;

namespace CRMSporKulubu.WinUI.PanelUI
{
	public partial class GelirGider : Form
	{
		FinansTakip _finansTakip;
		FinansTakipService _finansTakipService;
		GelirGiderKategoriService _gelirGiderKategoriService;
		CalisanService _calisanService;
		SporcuService _sporcuService;
		UyeService _uyeService;
		UrunService _urunService;
		public GelirGider()
		{
			InitializeComponent();
			_gelirGiderKategoriService = new GelirGiderKategoriService();
			_calisanService = new CalisanService();
			_sporcuService = new SporcuService();
			_uyeService = new UyeService();
			_finansTakip = new FinansTakip();
			_urunService = new UrunService();
			_finansTakipService = new FinansTakipService();
		}

		private void GelirGider_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.ClearSelection();
		}

		private void GelirGider_Load_1(object sender, EventArgs e)
		{
			FinansTakipDoldur();


		}

		private void button3_Click(object sender, EventArgs e)
		{
			button3.Text = "";
		}
		public void FinansTakipDoldur()
		{

			dataGridView1.DataSource = _finansTakipService.finansTakipListesiRaporu();
			if (cmbGelirGiderTip.Items.Count == 0)
			{
				cmbGelirGiderTip.Items.Add("Gelir");
				cmbGelirGiderTip.Items.Add("Gider");
				cmbGelirGiderTip.SelectedIndex = 0;
			}

			cmbKategori.SelectedValue = -1;
			DataGridRenkAtama();
			//Anasayfa anasayfa = new Anasayfa();
			//anasayfa.gelirGiderC.Update();
			//anasayfa.solidGauge1.Update();
			//Anasayfa.gelirGiderC.Update();
			//foreach (Control item in anasayfa.Controls)
			//{
			//	if (item is LiveCharts.WinForms.SolidGauge)
			//	{
			//		item.Update();
			//	}
			//}

		}
		public void KontrolleriSil()
		{
			foreach (Control item in this.Controls)
			{
				if (item is ComboBox)
				{
					ComboBox cmb = item as ComboBox;
					cmb.SelectedIndex = -1;
				}
				if (item is TextBox)
				{
					TextBox text = item as TextBox;
					text.Clear();
				}
				if (item is NumericUpDown)
				{
					NumericUpDown nmr = item as NumericUpDown;
					nmr.Value = 0;

				}
			}
		}

		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int finansTakipID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
			_finansTakip = _finansTakipService.FinansTakipGetirById(finansTakipID);

			if (_finansTakip.Not == null)
			{
				txtNot.Text = "Not Bulunmuyor.. ";
			}
			else
			{
				txtNot.Text = _finansTakip.Not.ToString();

			}
			txtUrunAdi.Text = _finansTakip.Fiyat.ToString();     //txtTutar


			if (!_finansTakip.GelirMiGiderMi)
			{
				cmbGelirGiderTip.SelectedIndex = 1;
				cmbKategori.DataSource = null;
				cmbKategori.DataSource = _gelirGiderKategoriService.TumKategorileriGetir();
				cmbKategori.DisplayMember = "GelirGiderKategoriAdi";
				cmbKategori.ValueMember = "ID";
				cmbKategori.SelectedValue = _finansTakip.GelirGiderKategoriID;

				//cmbUyeAdi.SelectedIndex = -1;
				//cmbSporcu.SelectedIndex = -1;
				//cmbKategori.SelectedIndex = -1;
				//cmbCalisan.SelectedIndex = -1;


				if (_finansTakip.CalisanID >= 1)
				{
					cmbCalisanAdi.DataSource = _calisanService.TumCalisanlariGetir();
					cmbCalisanAdi.DisplayMember = "Ad";
					cmbCalisanAdi.ValueMember = "ID";
					cmbCalisanAdi.SelectedValue = _finansTakip.CalisanID;



					cmbUyeAdi.SelectedIndex = -1;
					cmbSporcu.SelectedIndex = -1;
					cmbUrunAdi.SelectedIndex = -1;
					nmrUrunAdet.Value = 0;
					//cmbKategori.SelectedIndex = -1;


				}
				if (_finansTakip.SporcuID >= 1)
				{
					cmbSporcu.DataSource = _sporcuService.TumSporculariGetir();
					cmbSporcu.DisplayMember = "Ad";
					cmbSporcu.ValueMember = "ID";
					cmbSporcu.SelectedValue = _finansTakip.SporcuID;

					//cmbCalisan.Enabled = false;
					nmrUrunAdet.Value = 0;
					cmbUyeAdi.SelectedIndex = -1;
					cmbCalisanAdi.SelectedIndex = -1;
					cmbUrunAdi.SelectedIndex = -1;


				}
				if (_finansTakip.UyeID >= 1)
				{

					cmbUyeAdi.DataSource = _uyeService.TumUyeleriGetir();
					cmbUyeAdi.DisplayMember = "Ad";
					cmbUyeAdi.ValueMember = "ID";
					cmbUyeAdi.SelectedValue = _finansTakip.UyeID;

					cmbSporcu.SelectedIndex = -1;
					//cmbKategori.SelectedIndex = -1;
					cmbCalisanAdi.SelectedIndex = -1;
					cmbUrunAdi.SelectedIndex = -1;
				}
				if (_finansTakip.UrunID >= 1)
				{

					cmbUrunAdi.DataSource = _urunService.TumurunleriGetir();
					cmbUrunAdi.DisplayMember = "UrunAd";
					cmbUrunAdi.ValueMember = "ID";
					cmbUrunAdi.SelectedValue = _finansTakip.UrunID;
					nmrUrunAdet.Value = _finansTakip.UrunAdet.Value;
					cmbSporcu.SelectedIndex = -1;
					cmbUyeAdi.SelectedIndex = -1;
					cmbCalisanAdi.SelectedIndex = -1;
				}


			}
			else
			{
				cmbGelirGiderTip.SelectedIndex = 0;
				cmbKategori.DataSource = _gelirGiderKategoriService.TumKategorileriGetir();
				cmbKategori.DisplayMember = "GelirGiderKategoriAdi";
				cmbKategori.ValueMember = "ID";
				cmbKategori.SelectedValue = _finansTakip.GelirGiderKategoriID;

				if (cmbKategori.SelectedText == "Maaş" && _finansTakip.CalisanID != null)
				{
					cmbCalisanAdi.DisplayMember = "Ad";
					cmbCalisanAdi.ValueMember = "ID";
					cmbCalisanAdi.DataSource = _calisanService.TumCalisanlariGetir();


				}
				else if (cmbKategori.SelectedText == "Maaş" && _finansTakip.SporcuID != null)
				{

					cmbSporcu.DisplayMember = "Ad";
					cmbSporcu.ValueMember = "ID";
					cmbSporcu.DataSource = _sporcuService.TumSporculariGetir();
				}
				if (Convert.ToInt32(cmbKategori.SelectedValue) == _finansTakip.GelirGiderKategoriID && _finansTakip.UrunID != null)
				{
					cmbUrunAdi.DataSource = _urunService.TumurunleriGetir();
					cmbUrunAdi.DisplayMember = "UrunAd";
					cmbUrunAdi.ValueMember = "ID";
					cmbUrunAdi.SelectedValue = _finansTakip.UrunID;
					nmrUrunAdet.Value = _finansTakip.UrunAdet.Value;

				}
				if (_finansTakip.UyeID >= 1)
				{

					cmbUyeAdi.DataSource = _uyeService.TumUyeleriGetir();
					cmbUyeAdi.DisplayMember = "Ad";
					cmbUyeAdi.ValueMember = "ID";
					cmbUyeAdi.SelectedValue = _finansTakip.UyeID;

					cmbSporcu.SelectedIndex = -1;
					//cmbKategori.SelectedIndex = -1;
					cmbCalisanAdi.SelectedIndex = -1;
					cmbUrunAdi.SelectedIndex = -1;
				}


			}
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _finansTakipService.OdemeTarihineGoreGetir(dateTimePicker1.Value, dateTimePicker2.Value);
			DataGridRenkAtama();
		}

		private void btnFinansGuncelle_Click(object sender, EventArgs e)
		{
			int finansTakipID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
			_finansTakip = _finansTakipService.FinansTakipGetirById(finansTakipID);


			if (_finansTakip != null && (int)cmbKategori.SelectedValue > 0)
			{
				if (_finansTakip.CalisanID > 0)
				{
					_finansTakip.Not = txtNot.Text;
					_finansTakip.Fiyat = Convert.ToDecimal(txtUrunAdi.Text);        //txttutar
					_finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
					_finansTakip.CalisanID = (int)cmbCalisanAdi.SelectedValue;
					_finansTakip.SonOdemeTarihi = dtpSonOdemeTarihi.Value;
					_finansTakip.UyeID = null;
					_finansTakip.SporcuID = null;
					_finansTakip.GuncellenmeTarihi = DateTime.Now;
					_finansTakip.AktifMi = true;

					int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
					if (etkilenen > 0)
					{
						MessageBox.Show("Finans Takip Güncellendi..");
					}
				}
				if (_finansTakip.SporcuID > 0)
				{
					_finansTakip.Not = txtNot.Text;
					_finansTakip.Fiyat = Convert.ToDecimal(txtUrunAdi.Text);       //txttutar
					_finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
					_finansTakip.SporcuID = (int)cmbSporcu.SelectedValue;
					_finansTakip.SonOdemeTarihi = dtpSonOdemeTarihi.Value;
					_finansTakip.GuncellenmeTarihi = DateTime.Now;
					_finansTakip.AktifMi = true;


					int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
					if (etkilenen > 0)
					{
						MessageBox.Show("Finans Bilgisi Güncellendi..");
					}
				}
				if (_finansTakip.UyeID > 0)
				{
					_finansTakip.Not = txtNot.Text;
					_finansTakip.Fiyat = Convert.ToDecimal(txtUrunAdi.Text);       //txttutar
					_finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
					_finansTakip.UyeID = (int)cmbUyeAdi.SelectedValue;
					_finansTakip.SonOdemeTarihi = dtpSonOdemeTarihi.Value;
					_finansTakip.GuncellenmeTarihi = DateTime.Now;
					_finansTakip.AktifMi = true;


					int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
					if (etkilenen > 0)
					{
						MessageBox.Show("Finans Bilgisi Güncellendi..");
					}
					else
					{
						MessageBox.Show("Bir Hata Olustu.");
					}
				}
				if (_finansTakip.UrunID > 0)
				{

					_finansTakip.UrunAdet = (int)nmrUrunAdet.Value;
					_finansTakip.Not = txtNot.Text;
					_finansTakip.Fiyat = Convert.ToDecimal(txtUrunAdi.Text);    //txttutar
					_finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
					_finansTakip.UrunID = (int)cmbUrunAdi.SelectedValue;
					_finansTakip.SonOdemeTarihi = dtpSonOdemeTarihi.Value;
					_finansTakip.GuncellenmeTarihi = DateTime.Now;
					_finansTakip.AktifMi = true;


					int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
					if (etkilenen > 0)
					{
						MessageBox.Show("Finans Takip Güncellendi..");
					}

				}

				for (int i = 0; i < dataGridView1.RowCount; i++)
				{
					int finansTakipID1 = Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value);
					FinansTakip _finansTakip1 = _finansTakipService.FinansTakipGetirById(finansTakipID1);
					if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["OdemeDurumu"].Value))
					{
						if (_finansTakip1.OdemeDurumu != true)
						{
							_finansTakip1.OdemeDurumu = true;
							_finansTakip1.OdemeTarihi = DateTime.Now;
							_finansTakipService.FinansTakipUpdate(_finansTakip1);
						}
					}
					else
					{
						if (_finansTakip1.OdemeDurumu == true)
						{
							_finansTakip1.OdemeDurumu = false;
							_finansTakip1.OdemeTarihi = null;
							_finansTakipService.FinansTakipUpdate(_finansTakip1);
						}
					}
				}

			}
			//_finansTakip.Not = txtNot.Text;
			//_finansTakip.Fiyat =Convert.ToDecimal( txtTutar.Text);
			//_finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
			//_finansTakip.CalisanID = (int)cmbCalisan.SelectedValue;
			//_finansTakip.SporcuID = (int)cmbSporcu.SelectedValue;
			//_finansTakip.UyeID = (int)cmbUyeAdi.SelectedValue;
			//_finansTakip.OdemeTarihi = dtpOdemeTarihi.Value;

			//int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
			//if (etkilenen>0)
			//{
			//    MessageBox.Show("Finans Takip Güncellendi..");
			//}
			FinansTakipDoldur();
			DataGridRenkAtama();
			KontrolleriSil();
		}

		private void btnFinansSil_Click(object sender, EventArgs e)
		{
			int finansTakipID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
			_finansTakip = _finansTakipService.FinansTakipGetirById(finansTakipID);


			int etkilenen = _finansTakipService.FinansTakipSil(_finansTakip);
			if (etkilenen > 0)
			{
				MessageBox.Show("Urun Silindi");
				dataGridView1.DataSource = _finansTakipService.TumFinansTakipTablosunuGetir();
			}
			FinansTakipDoldur();
			DataGridRenkAtama();
			KontrolleriSil();
		}

		private void btnUyeEkle_Click(object sender, EventArgs e)
		{
			GelirGierEkleYeni gelirGierEkleYeni = new GelirGierEkleYeni(this);
			gelirGierEkleYeni.Show();
		}
		public void DataGridRenkAtama()
		{
			for (int i = 0; i < dataGridView1.RowCount; i++)
			{
				if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["OdemeDurumu"].Value) == false)
				{
					DateTime dt = Convert.ToDateTime(dataGridView1.Rows[i].Cells["SonOdemeTarihi"].Value);
					TimeSpan timeSpan = DateTime.Now - dt;
					if (timeSpan.TotalDays > 0)
					{
						dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
					}
				}
			}

		}

		private void button3_TextChanged(object sender, EventArgs e)
		{
		 
				//dataGridView1.DataSource = null;
				//List<FinansTakipDTO> List = _finansTakipService.FinansBilgileriniGetir(button3.Text);
				//dataGridView1.DataSource = List;
			
		}
	}
}
