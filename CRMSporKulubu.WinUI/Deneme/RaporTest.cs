using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.Entities.Models;
using CRMSporKulubu.Entities.Models.EnumTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMSporKulubu.Entities.DTO;
using System.Windows.Media;
using CRMSporKulubu.DAL.CRMDbContext;

namespace CRMSporKulubu.WinUI.Deneme
{
	public partial class RaporTest : Form
	{
		CalisanService _calisanService;
		UyeService _uyeService;
		FinansTakipService _finansTakipService;
		FinansTakip _finansTakip;
		//GelirGiderKategori _gelGidKategori;
		GelirGiderKategoriService _gelirGiderKategoriService;
		SporcuService _sporcuService;
		public RaporTest()
		{
			InitializeComponent();
			_uyeService = new UyeService();
			_finansTakipService = new FinansTakipService();
			_finansTakip = new FinansTakip();
			_calisanService = new CalisanService();
			_gelirGiderKategoriService = new GelirGiderKategoriService();
			grbxDetay.Visible = false;
			cmbMaasTip.Visible = false;
			_sporcuService = new SporcuService();
		}
		public void DataGridAidatDoldur(DateTime dateTime)
		{
			foreach (Uye item in _finansTakipService.FinansTakipOlmayanUyeler(dateTime))
			{
				_finansTakip.GelirGiderKategoriID = 2;
				_finansTakip.GelirMiGiderMi = true;
				_finansTakip.UyeID = item.ID;
				_finansTakip.CalisanID = null;
				_finansTakip.SporcuID = null;
				_finansTakip.OlusturulmaTarihi = DateTime.Now;
				_finansTakip.OdemeDurumu = false;
				_finansTakip.OdemeTarihi = null;
				_finansTakip.SonOdemeTarihi = dateTime;
				_finansTakip.AktifMi = true;
				_finansTakip.Fiyat = item.Aidat;
				_finansTakipService.AddFinansTakipService(_finansTakip);

			}
			dgvRapor.DataSource = null;
			dgvRapor.DataSource = _uyeService.AidatRaporla(dateTime);
			DataGridRenkAtama();
		}
		public void DataGridMaasDoldurCalisan(DateTime dateTime)
		{

			foreach (Calisan item in _finansTakipService.FinansTakipOlmayanCalisanlar(dateTime))
			{
				_finansTakip.GelirGiderKategoriID = 1;
				_finansTakip.GelirMiGiderMi = false;
				_finansTakip.CalisanID = item.ID;
				_finansTakip.UyeID = null;
				_finansTakip.SporcuID = null;
				_finansTakip.OlusturulmaTarihi = DateTime.Now;
				_finansTakip.OdemeDurumu = false;
				_finansTakip.OdemeTarihi = null;
				_finansTakip.SonOdemeTarihi = dateTime;
				_finansTakip.AktifMi = true;
				_finansTakip.Fiyat = item.Maas;
				_finansTakipService.AddFinansTakipService(_finansTakip);

			}
			dgvRapor.DataSource = null;
			dgvRapor.DataSource = _calisanService.MaasRaporla(dateTime);
			DataGridRenkAtama();
		}
		public void DataGridMaasDoldurSporcu(DateTime dateTime)
		{

			foreach (Sporcu item in _finansTakipService.FinansTakipOlmayanSporcular(dateTime))
			{
				_finansTakip.GelirGiderKategoriID = 1;
				_finansTakip.GelirMiGiderMi = false;
				_finansTakip.SporcuID = item.ID;
				_finansTakip.CalisanID = null;
				_finansTakip.UyeID = null;
				_finansTakip.OlusturulmaTarihi = DateTime.Now;
				_finansTakip.OdemeDurumu = false;
				_finansTakip.OdemeTarihi = null;
				_finansTakip.SonOdemeTarihi = dateTime;
				_finansTakip.AktifMi = true;
				_finansTakip.Fiyat = item.Maas;
				_finansTakipService.AddFinansTakipService(_finansTakip);

			}
			dgvRapor.DataSource = null;
			dgvRapor.DataSource = _sporcuService.MaasRaporla(dateTime);
			DataGridRenkAtama();
		}
		public void DataGirdUrunSatisDoldur(DateTime dateTime)
		{
			dgvRapor.DataSource = _finansTakipService.UrunSatisRaporla(dateTime);
			DataGridRenkAtama();
		}
		public void DataGridAylikRaporDoldur(DateTime dateTime, bool kontrol)
		{
			dgvRapor.DataSource = _finansTakipService.AylikRaporGetir(dateTime, kontrol);
			DataGridRenkAtama();
		}
		public DateTime İstenenTarih()
		{
			Aylar seciliAy = (Aylar)cmbAylar.SelectedItem;
			int istenenAy = Convert.ToInt32(seciliAy);
			int istenenYil = Convert.ToInt32(cmbYillar.SelectedItem);
			DateTime dateTime = new DateTime(istenenYil, istenenAy, 28);
			return dateTime;
		}
		public void DataGridRenkAtama()
		{
			for (int i = 0; i < dgvRapor.RowCount; i++)
			{
				if (Convert.ToBoolean(dgvRapor.Rows[i].Cells["OdemeDurumu"].Value) == false)
				{
					DateTime dt = Convert.ToDateTime(dgvRapor.Rows[i].Cells["SonOdemeTarihi"].Value);
					TimeSpan timeSpan = DateTime.Now - dt;
					if (timeSpan.TotalDays > 0)
					{
						dgvRapor.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
					}
				}
			}
		}
		public void OdemeGuncelle()
		{
			for (int i = 0; i < dgvRapor.RowCount; i++)
			{
				if (Convert.ToBoolean(dgvRapor.Rows[i].Cells["OdemeDurumu"].Value) == true)
				{
					int id = Convert.ToInt32(dgvRapor.Rows[i].Cells[0].Value);
					DateTime dateTime = Convert.ToDateTime(dgvRapor.Rows[i].Cells["SonOdemeTarihi"].Value);
					if (cmbRaporlar.SelectedItem.ToString() == "Maaş")
					{
						if (cmbMaasTip.SelectedIndex == 0)
						{
							_finansTakip = _finansTakipService.ArananFinansTakipCalisan(dateTime, id);
						}
						else
						{
							_finansTakip = _finansTakipService.ArananFinansTakipSporcu(dateTime, id);
						}
					}
					else if (cmbRaporlar.SelectedItem.ToString() == "Aidat")
					{
						_finansTakip = _finansTakipService.ArananFinansTakipUye(dateTime, id);
					}
					else if (cmbRaporlar.SelectedItem.ToString() == "Ürün Satış")
					{
						_finansTakip = _finansTakipService.ArananFinansTakipUrun(dateTime, id);
					}

					if (_finansTakip.OdemeDurumu != true)
					{
						_finansTakip.OdemeDurumu = true;
						_finansTakip.OdemeTarihi = DateTime.Now;
						_finansTakipService.FinansTakipUpdate(_finansTakip);
					}
				}
				else
				{
					int id = Convert.ToInt32(dgvRapor.Rows[i].Cells[0].Value);
					DateTime dateTime = Convert.ToDateTime(dgvRapor.Rows[i].Cells["SonOdemeTarihi"].Value);
					if (cmbRaporlar.SelectedItem.ToString() == "Maaş")
					{
						if (cmbMaasTip.SelectedIndex == 0)
						{
							_finansTakip = _finansTakipService.ArananFinansTakipCalisan(dateTime, id);
						}
						else
						{
							_finansTakip = _finansTakipService.ArananFinansTakipSporcu(dateTime, id);
						}
					}
					else if (cmbRaporlar.SelectedItem.ToString() == "Aidat")
					{
						_finansTakip = _finansTakipService.ArananFinansTakipUye(dateTime, id);
					}
					else if (cmbRaporlar.SelectedItem.ToString() == "Ürün Satış")
					{
						_finansTakip = _finansTakipService.ArananFinansTakipUrun(dateTime, id);
					}

					if (_finansTakip.OdemeDurumu == true)
					{
						_finansTakip.OdemeDurumu = false;
						_finansTakip.OdemeTarihi = null;
						_finansTakipService.FinansTakipUpdate(_finansTakip);
					}
				}
			}
			MessageBox.Show("Ödeme Durumu Güncellendi!");
			dgvRapor.DataSource = null;
			if (cmbRaporlar.SelectedItem.ToString() == "Maaş")
			{
				dgvRapor.DataSource = _calisanService.MaasRaporla(İstenenTarih());
				cmbMaasTip.SelectedIndex = 0;
				DataGridRenkAtama();
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aidat")
			{
				dgvRapor.DataSource = _uyeService.AidatRaporla(İstenenTarih());
				DataGridRenkAtama();
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Ürün Satış")
			{
				dgvRapor.DataSource = _finansTakipService.UrunSatisRaporla(İstenenTarih());
				DataGridRenkAtama();
			}
		}
		public void DataMaasDoldur()
		{
			if (cmbMaasTip.SelectedIndex == 0)
			{
				DataGridMaasDoldurCalisan(İstenenTarih());
			}
			else
			{
				DataGridMaasDoldurSporcu(İstenenTarih());
			}
		}
		private void RaporTest_Load(object sender, EventArgs e)
		{

			cmbMaasTip.Items.Add("Çalışan");
			cmbMaasTip.Items.Add("Sporcu");
			for (int i = DateTime.Now.Year; i >= 2000; i--)
			{
				i.ToString();
				cmbYillar.Items.Add(i);
			}
			cmbYillar.SelectedIndex = 0;
			DateTime dateTime = DateTime.Now.AddDays(28 - (DateTime.Now.Day));
			cmbAylar.DataSource = Enum.GetValues(typeof(Aylar));
			cmbAylar.SelectedIndex = DateTime.Now.Month - 1;
			cmbRaporlar.Items.Add("Aidat");
			cmbRaporlar.Items.Add("Maaş");
			cmbRaporlar.Items.Add("Ürün Satış");
			cmbRaporlar.Items.Add("Aylık Gelir");
			cmbRaporlar.Items.Add("Aylık Gider");
			btnOdemeEkle.Visible = true;
			btnGecikenler.Visible = false;
			cmbRaporlar.SelectedIndex = 0;			
			

		}
		private void btnSeciliAyinRaporu_Click(object sender, EventArgs e)
		{
			
			if (cmbRaporlar.SelectedItem.ToString() == "Aidat")
			{
				DataGridAidatDoldur(İstenenTarih());
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Maaş")
			{
				DataMaasDoldur();
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Ürün Satış")
			{
				DataGirdUrunSatisDoldur(İstenenTarih());
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gelir")
			{
				DataGridAylikRaporDoldur(İstenenTarih(), true);
				ToplamGelirGiderHesapla();
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gider")
			{
				DataGridAylikRaporDoldur(İstenenTarih(), false);
				ToplamGelirGiderHesapla();
			}


		}
		private void btnOdemeEkle_Click(object sender, EventArgs e)
		{
			OdemeGuncelle();

		}
		//private void btnMaasGuncelle_Click(object sender, EventArgs e)
		//{
		//	OdemeGuncelle();

		//}
		//private void btnUrunOdemeGuncelle_Click(object sender, EventArgs e)
		//{
		//	OdemeGuncelle();

		//}
		private void cmbRaporlar_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnGecikenler.Visible = false;
			cmbMaasTip.Visible = false;
			grbxDetay.Visible = false;
			cmbAylar.SelectedIndex = DateTime.Now.Month - 1;
			cmbYillar.SelectedIndex = 0;
			if (cmbRaporlar.SelectedItem.ToString() == "Aidat")
			{
				btnOdemeEkle.Visible = true;
				DataGridAidatDoldur(İstenenTarih());
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Maaş")
			{
				btnOdemeEkle.Visible = true;
				cmbMaasTip.Visible = true;
				cmbMaasTip.SelectedIndex = 0;
				DataMaasDoldur();
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Ürün Satış")
			{
				btnOdemeEkle.Visible = true;
				DataGirdUrunSatisDoldur(İstenenTarih());
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gelir")
			{
				
				btnOdemeEkle.Visible = false;				
				btnGecikenler.Visible = true;
				DataGridAylikRaporDoldur(İstenenTarih(), true);
				ToplamGelirGiderHesapla();
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gider")
			{
				
				btnOdemeEkle.Visible = false;				
				btnGecikenler.Visible = true;
				DataGridAylikRaporDoldur(İstenenTarih(), false);
				ToplamGelirGiderHesapla();
			}
		}		

		private void dgvRapor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dgvRapor.ClearSelection();
		}

		private void btnGecikenler_Click(object sender, EventArgs e)
		{
			grbxDetay.Visible = false;
			if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gelir")
			{
				dgvRapor.DataSource = _finansTakipService.GecikenOdemeleriGetir(İstenenTarih(), true);
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gider")
			{
				dgvRapor.DataSource = _finansTakipService.GecikenOdemeleriGetir(İstenenTarih(), false);
			}

		}
		public void ToplamGelirGiderHesapla()
		{
			grbxDetay.Visible = true;
			decimal GenelToplam = 0;
			decimal OdenenToplam = 0;
			decimal OdenmeyenToplam = 0;
			for (int i = 0; i < dgvRapor.Rows.Count; ++i)
			{
				if (Convert.ToBoolean(dgvRapor.Rows[i].Cells["OdemeDurumu"].Value))
				{
					OdenenToplam += Convert.ToInt32(dgvRapor.Rows[i].Cells["Fiyat"].Value);
				}
				else
				{
					OdenmeyenToplam += Convert.ToInt32(dgvRapor.Rows[i].Cells["Fiyat"].Value);
				}
			}
			GenelToplam = OdenenToplam + OdenmeyenToplam;
			label4.Text = GenelToplam.ToString();
			label5.Text = OdenenToplam.ToString();
			label6.Text = OdenmeyenToplam.ToString();
		}

		private void cmbMaasTip_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbAylar.SelectedIndex = DateTime.Now.Month - 1;
			cmbYillar.SelectedIndex = 0;
			DataMaasDoldur();
		}

		private void grbxDetay_Enter(object sender, EventArgs e)
		{

		}
	}
}
