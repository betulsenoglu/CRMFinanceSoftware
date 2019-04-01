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
using LiveCharts;
using LiveCharts.Wpf;

namespace CRMSporKulubu.WinUI.PanelUI
{
	public partial class Raporlar : Form
	{
		CalisanService _calisanService;
		UyeService _uyeService;
		FinansTakipService _finansTakipService;
		FinansTakip _finansTakip; 		
		GelirGiderKategoriService _gelirGiderKategoriService;
		SporcuService _sporcuService;
		UrunService _urunService;
		public Raporlar()
		{
			InitializeComponent();
			_uyeService = new UyeService();
			_urunService = new UrunService();
			_finansTakipService = new FinansTakipService();
			_finansTakip = new FinansTakip();
			_calisanService = new CalisanService();
			_gelirGiderKategoriService = new GelirGiderKategoriService();
			panel4.Visible = true;
			panel5.Visible = true;
			cmbMaasTip.Visible = false;
			label3.Visible = false;
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
						dgvRapor.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.IndianRed;
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
				ToplamGelirGiderHesapla("Maas");
				DataGridRenkAtama();
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aidat")
			{
				dgvRapor.DataSource = _uyeService.AidatRaporla(İstenenTarih());
				ToplamGelirGiderHesapla("Aidat");
				DataGridRenkAtama();
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Ürün Satış")
			{
				dgvRapor.DataSource = _finansTakipService.UrunSatisRaporla(İstenenTarih());
				ToplamGelirGiderHesapla("ToplamKazanc");
				DataGridRenkAtama();
			}
		}
		public void DataMaasDoldur()
		{
			if (cmbMaasTip.SelectedIndex == 0)
			{
				DataGridMaasDoldurCalisan(İstenenTarih());
				ToplamGelirGiderHesapla("Maas");
			}
			else
			{
				DataGridMaasDoldurSporcu(İstenenTarih());
				ToplamGelirGiderHesapla("Maas");
			}
		}

		private void Raporlar_Load(object sender, EventArgs e)
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
			cmbGrafikler.Items.Add("Gelir-Gider");
			cmbGrafikler.Items.Add("Ürün Satış");
			cmbGrafikler.Items.Add("Ürün Stok");
			cmbGrafikler.Items.Add("Yeni Üye Kaydı");
			cmbGrafikler.SelectedIndex = 0;
			btnOdemeEkle.Visible = true;
			btnGecikenler.Visible = false;
			cmbRaporlar.SelectedIndex = 0;

		}
		private void btnSeciliAyinRaporu_Click(object sender, EventArgs e)
		{

			if (cmbRaporlar.SelectedItem.ToString() == "Aidat")
			{
				DataGridAidatDoldur(İstenenTarih());
				ToplamGelirGiderHesapla("Aidat");
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Maaş")
			{
				DataMaasDoldur();
				ToplamGelirGiderHesapla("Maas");
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Ürün Satış")
			{
				DataGirdUrunSatisDoldur(İstenenTarih());
				ToplamGelirGiderHesapla("ToplamKazanc");
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gelir")
			{
				DataGridAylikRaporDoldur(İstenenTarih(), true);
				ToplamGelirGiderHesapla("Fiyat");
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gider")
			{
				DataGridAylikRaporDoldur(İstenenTarih(), false);
				ToplamGelirGiderHesapla("Fiyat");
			}


		}
		private void btnOdemeEkle_Click(object sender, EventArgs e)
		{
			OdemeGuncelle();

		}
		private void cmbRaporlar_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnGecikenler.Visible = false;
			cmbMaasTip.Visible = false;
			label3.Visible = false;
			panel4.Visible = true;
			panel5.Visible = true;
			cmbAylar.SelectedIndex = DateTime.Now.Month - 1;
			cmbYillar.SelectedIndex = 0;
			if (cmbRaporlar.SelectedItem.ToString() == "Aidat")
			{
				btnOdemeEkle.Visible = true;
				DataGridAidatDoldur(İstenenTarih());
				DataGridRenkAtama();
				ToplamGelirGiderHesapla("Aidat");
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Maaş")
			{
				btnOdemeEkle.Visible = true;
				cmbMaasTip.Visible = true;
				label3.Visible = true;
				cmbMaasTip.SelectedIndex = 0;
				DataMaasDoldur();
				ToplamGelirGiderHesapla("Maas");
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Ürün Satış")
			{
				btnOdemeEkle.Visible = true;
				DataGirdUrunSatisDoldur(İstenenTarih());
				ToplamGelirGiderHesapla("ToplamKazanc");
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gelir")
			{

				btnOdemeEkle.Visible = false;
				btnGecikenler.Visible = true;
				DataGridAylikRaporDoldur(İstenenTarih(), true);
				ToplamGelirGiderHesapla("Fiyat");
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gider")
			{

				btnOdemeEkle.Visible = false;
				btnGecikenler.Visible = true;
				DataGridAylikRaporDoldur(İstenenTarih(), false);
				ToplamGelirGiderHesapla("Fiyat");
			}
		}

		private void dgvRapor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dgvRapor.ClearSelection();
		}

		private void btnGecikenler_Click(object sender, EventArgs e)
		{
			panel4.Visible = false;
			panel5.Visible = false;
			if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gelir")
			{
				dgvRapor.DataSource = _finansTakipService.GecikenOdemeleriGetir(İstenenTarih(), true);
			}
			else if (cmbRaporlar.SelectedItem.ToString() == "Aylık Gider")
			{
				dgvRapor.DataSource = _finansTakipService.GecikenOdemeleriGetir(İstenenTarih(), false);
			}

		}
		public void ToplamGelirGiderHesapla(string ColumnName)
		{
			panel4.Visible = true;
			panel5.Visible = true;
			decimal GenelToplam = 0;
			decimal OdenenToplam = 0;
			decimal OdenmeyenToplam = 0;
			for (int i = 0; i < dgvRapor.Rows.Count; ++i)
			{
				if (Convert.ToBoolean(dgvRapor.Rows[i].Cells["OdemeDurumu"].Value))
				{
					OdenenToplam += Convert.ToInt32(dgvRapor.Rows[i].Cells[ColumnName].Value);
				}
				else
				{
					OdenmeyenToplam += Convert.ToInt32(dgvRapor.Rows[i].Cells[ColumnName].Value);
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

		private void cmbGrafikler_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbGrafikler.SelectedIndex==0)
			{
				//cartesianChart2.Visible = false;
				//cartesianChart3.Visible = false;
				//cartesianChart1.Visible = true;
				cartesianChart1.Series.Clear();
				cartesianChart1.AxisX.Clear();
				cartesianChart1.AxisY.Clear();

				var data = _finansTakipService.GelirYillikChart(DateTime.Now);
				ChartValues<decimal> listGelir = new ChartValues<decimal>();
				foreach (var item in data)
				{
					listGelir.Add(item.ToplamTutar);
				}
				List<string> listAylar = new List<string>();
				foreach (var item1 in data)
				{

					string ay = Enum.GetName(typeof(Aylar), item1.Ay);
					listAylar.Add(ay);
				}

				var data1 = _finansTakipService.GiderYillikChart(DateTime.Now);
				ChartValues<decimal> listGider = new ChartValues<decimal>();
				foreach (var item in data1)
				{
					listGider.Add(item.ToplamTutar);
				}
				List<string> listAylar1 = new List<string>();
				foreach (var item1 in data1)
				{
					listAylar1.Add(item1.Ay.ToString());
				}

				cartesianChart1.Series = new SeriesCollection();
				LineSeries gelir = new LineSeries();
				gelir.Title = "Aylık Toplam Gelir";
				gelir.Values = listGelir;
				gelir.PointGeometry = DefaultGeometries.Diamond;
				gelir.LineSmoothness = 1;
				gelir.PointGeometrySize = 10;
				gelir.PointForeground = System.Windows.Media.Brushes.DarkBlue;
				cartesianChart1.Series.Add(gelir);

				LineSeries gider = new LineSeries();
				gider.Title = "Aylık Toplam Gider";
				gider.Values = listGider;
				gider.PointGeometry = DefaultGeometries.Square;
				gider.LineSmoothness = 1;
				gider.PointGeometrySize = 10;
				gider.PointForeground = System.Windows.Media.Brushes.Black;
				cartesianChart1.Series.Add(gider);


				Axis ax1 = new Axis();
				ax1.Labels = listAylar;
				ax1.Title = "Aylar";
				ax1.Foreground = System.Windows.Media.Brushes.Black;
				ax1.FontStyle = System.Windows.FontStyles.Italic;
				ax1.FontWeight = System.Windows.FontWeights.Bold;
				cartesianChart1.AxisX.Add(ax1);
				cartesianChart1.AxisY.Add(new Axis
				{
					Foreground = System.Windows.Media.Brushes.Black,
					FontWeight = System.Windows.FontWeights.Bold,
					MinValue = 0,
					Title = "Toplam Tutar"
				});

				cartesianChart1.LegendLocation = LegendLocation.Top;

				
			}
			else if (cmbGrafikler.SelectedIndex==1)
			{
				cartesianChart1.Series.Clear();
				cartesianChart1.AxisX.Clear();
				cartesianChart1.AxisY.Clear();
				#region YillikUrun      
				var data2 = _urunService.UrunKazancGrafigi();

				ColumnSeries col2 = new ColumnSeries() { DataLabels = true, Values = new ChartValues<decimal>(), LabelPoint = point => point.Y.ToString(), Title = "Toplam Fiyat : " };
				Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
				ax.Labels = new List<string>();

				ax.Title = "Aylar";
				ax.Foreground = System.Windows.Media.Brushes.Black;
				ax.FontWeight = System.Windows.FontWeights.Bold;

				foreach (var x in data2)
				{
					col2.Values.Add(x.Fiyat);
					string ay = Enum.GetName(typeof(Aylar), x.Ay);
					ax.Labels.Add(ay);
				}


				cartesianChart1.Series.Add(col2);
				cartesianChart1.AxisX.Add(ax);
				cartesianChart1.AxisY.Add(new Axis
				{

					LabelFormatter = value => value.ToString(),
					Separator = new Separator(),
					Foreground = System.Windows.Media.Brushes.Black,
					FontWeight = System.Windows.FontWeights.Bold,
					Title = "Aylık Ürün Geliri/TL"

				});
				#endregion
			}
			else if (cmbGrafikler.SelectedIndex==3)
			{
				cartesianChart1.Series.Clear();
				cartesianChart1.AxisX.Clear();
				cartesianChart1.AxisY.Clear();
				#region UyeDagilimi

				var data = _uyeService.UyeDonemDagilimiGetir();
				ChartValues<int> list = new ChartValues<int>();
				foreach (var item in data)
				{
					list.Add(item.ToplamSayi);
				}
				List<string> listYillar = new List<string>();
				foreach (var item1 in data)
				{
					listYillar.Add(item1.Yil.ToString());
				}
				cartesianChart1.Series = new SeriesCollection();
				LineSeries a = new LineSeries();
				a.Title = "Yeni Kayıt Sayısı";
				a.Values = list;
				a.PointGeometry = DefaultGeometries.Circle;
				a.LineSmoothness = 0;
				a.PointGeometrySize = 10;
				a.PointForeground = System.Windows.Media.Brushes.DarkBlue;
				cartesianChart1.Series.Add(a);


				Axis ax1 = new Axis();
				ax1.Labels = listYillar;
				ax1.Title = "Yıllar";
				cartesianChart1.AxisX.Add(ax1);
				cartesianChart1.AxisY.Add(new Axis
				{
					Title = "Yeni Kayıt Sayısı"
				});

				cartesianChart1.LegendLocation = LegendLocation.Top;




				#endregion
			}
			else if (cmbGrafikler.SelectedIndex==2)
			{
				cartesianChart1.Series.Clear();
				cartesianChart1.AxisX.Clear();
				cartesianChart1.AxisY.Clear();
				#region UrunStok

				var dataUrunStok = _urunService.UrunStokDagilimiGrafigi();
				ColumnSeries col = new ColumnSeries() { DataLabels = true, Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString(), Title = "STOK" };
				Axis ax = new Axis() { Separator = new Separator() { Step = 1, IsEnabled = false } };
				ax.Labels = new List<string>();
				ax.LabelsRotation = 135;
				ax.Title = "ÜRÜN ADI";
				foreach (var x in dataUrunStok)
				{

					col.Values.Add(x.UrunStok);
					ax.Labels.Add(x.UrunAdi);
				}

				cartesianChart1.Series.Add(col);
				cartesianChart1.AxisX.Add(ax);
				cartesianChart1.AxisY.Add(new Axis
				{
					LabelFormatter = value => value.ToString(),
					Separator = new Separator()

				});
				#endregion
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dgvRapor_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
