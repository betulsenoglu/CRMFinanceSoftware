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

namespace CRMSporKulubu.WinUI.Deneme
{
	public partial class RaporMaas : Form
	{
		CalisanService _calisanService;
		FinansTakipService _finansTakipService;
		FinansTakip _finansTakip;
		public RaporMaas()
		{
			InitializeComponent();
			_calisanService = new CalisanService();
			_finansTakipService = new FinansTakipService();
			_finansTakip = new FinansTakip();
		}

		private void RaporMaas_Load(object sender, EventArgs e)
		{
			//cmbAylar.DataSource = Enum.GetValues(typeof(Aylar));

			//foreach (Calisan item in _finansTakipService.FinansTakipOlmayanCalisanlar(DateTime.Now.Month))
			//{
			//	_finansTakip.GelirGiderKategoriID = 1;
			//	_finansTakip.GelirMiGiderMi = false;
			//	_finansTakip.CalisanID = item.ID;
			//	_finansTakip.OlusturulmaTarihi = DateTime.Now;
			//	_finansTakip.OdemeDurumu = false;
			//	_finansTakip.OdemeTarihi = DateTime.Now.AddDays(28 - (DateTime.Now.Day));
			//	_finansTakip.AktifMi = true;
			//	_finansTakip.Fiyat = item.Maas;
			//	_finansTakipService.AddFinansTakipService(_finansTakip);

			//}
			//dgvRaporMaas.DataSource = null;
			//dgvRaporMaas.DataSource = _calisanService.MaasRaporla(DateTime.Now.Month);
		}

		private void btnSeciliAyMaas_Click(object sender, EventArgs e)
		{
			//Aylar seciliAy = (Aylar)cmbAylar.SelectedItem;
			//int istenenAy = Convert.ToInt32(seciliAy);
			//DateTime dateTime = new DateTime(2019, istenenAy, 28);

			//foreach (Calisan item in _finansTakipService.FinansTakipOlmayanCalisanlar(istenenAy))
			//{
			//	_finansTakip.GelirGiderKategoriID = 1;
			//	_finansTakip.GelirMiGiderMi = false;
			//	_finansTakip.CalisanID = item.ID;
			//	_finansTakip.OlusturulmaTarihi = DateTime.Now;
			//	_finansTakip.OdemeDurumu = false;
			//	_finansTakip.OdemeTarihi =dateTime;
			//	_finansTakip.AktifMi = true;
			//	_finansTakip.Fiyat = item.Maas;
			//	_finansTakipService.AddFinansTakipService(_finansTakip);

			//}
			//dgvRaporMaas.DataSource = null;
			//dgvRaporMaas.DataSource = _calisanService.MaasRaporla(istenenAy);
		}

		private void btnOdemeEkle_Click(object sender, EventArgs e)
		{
			//for (int i = 0; i < dgvRaporMaas.RowCount; i++)
			//{
			//	DateTime dateTime = (DateTime)dgvRaporMaas.Rows[i].Cells[5].Value;
			//	int id = Convert.ToInt32(dgvRaporMaas.Rows[i].Cells[0].Value);
			//	_finansTakip = _finansTakipService.ArananFinansTakipCalisan(dateTime, id);

			//	if (Convert.ToBoolean(dgvRaporMaas.Rows[i].Cells[4].Value))
			//	{
			//		if (_finansTakip.OdemeDurumu!=true)
			//		{
			//			_finansTakip.OdemeDurumu = true;
			//			_finansTakipService.FinansTakipUpdate(_finansTakip);
			//		}					
			//	}
				
			//}
			//MessageBox.Show("Ödeme Durumu Güncellendi!");
			//Aylar seciliAy = (Aylar)cmbAylar.SelectedItem;
			//int istenenAy = Convert.ToInt32(seciliAy);
			//dgvRaporMaas.DataSource = null;
			//dgvRaporMaas.DataSource = _calisanService.MaasRaporla(istenenAy);
		}
	}
}
