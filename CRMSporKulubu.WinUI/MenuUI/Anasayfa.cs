using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.WinUI.LoginUI;
using CRMSporKulubu.WinUI.PanelUI;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSporKulubu.WinUI.MenuUI
{
	public partial class Anasayfa : Form
	{
		FinansTakipService _finansService;
		public Anasayfa()
		{
			_finansService = new FinansTakipService();
			InitializeComponent();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
		
			if (panel1.Height == 604 & panel1.Width == 205)
			{
				panel1.Height = 604;
				panel1.Width = 29;
			}
			else
			{
				panel1.Height = 604;
				panel1.Width = 205;

			}
			pnlKucukAnaSayfa.Visible = false;
			pnlKucukFinansYonetimi.Visible = false;
			pnlKucukHesapYonetimi.Visible = false;
			pnlKucukKisiYonetimi.Visible = false;
			pnlFinansYonetimi.Visible = false;
			pnlHesapYonetimi.Visible = false;
			pnlKisiYonetimi.Visible = false;
		
		}
 
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Anasayfa_Load(object sender, EventArgs e)
		{
			pnlAna.Controls.Clear();
			AnasayfaGuncelDurum anasayfagunceldurumform = new AnasayfaGuncelDurum();
			anasayfagunceldurumform.TopLevel = false;
			pnlAna.Controls.Add(anasayfagunceldurumform);
			anasayfagunceldurumform.Show();
			anasayfagunceldurumform.Dock = DockStyle.Fill;
			anasayfagunceldurumform.SendToBack();

			pnlFinansYonetimi.Visible = false;
			pnlKisiYonetimi.Visible = false;
			pnlHesapYonetimi.Visible = false;
			pnlKucukAnaSayfa.Visible = false;
			pnlKucukFinansYonetimi.Visible = false;
			pnlKucukHesapYonetimi.Visible = false;
			pnlKucukKisiYonetimi.Visible = false;

			#region PIE GRAFIK
			var dataGelirYuzde = _finansService.GelirYuzdeligiGetir();
			var dataGiderYuzde = _finansService.GiderYuzdeligiGetir();
			Func<ChartPoint, string> labelPoint = chartPoint =>
				   string.Format("", chartPoint.Y, chartPoint.Participation);
			Func<ChartPoint, string> labelPoint1 = chartPoint =>
		string.Format("", chartPoint.Y, chartPoint.Participation);
			gelirGiderC.Series = new SeriesCollection
			{
				new PieSeries
				{
					Title = "Gelir",
					Values = new ChartValues<double> {dataGelirYuzde},
					PushOut = 9,
					DataLabels = true,
					LabelPoint = labelPoint,

				  },
				new PieSeries
				{
					Title = "Gider",
					Values = new ChartValues<double> {dataGiderYuzde},
					DataLabels = true,
					LabelPoint = labelPoint1
				}
			};

			      gelirGiderC.LegendLocation = LegendLocation.Bottom;
			var dataUrun = _finansService.UrunGelirYuzdeligiGetir();
			var dataDigerGelir = _finansService.DigerGelirYuzdeligiGetir();
			var dataAidat = _finansService.AidatGelirYuzdeligiGetir();
			var dataKiralama = _finansService.KiralamaGelirYuzdeligiGetir();

			Func<ChartPoint, string> labelPointUrun = chartPoint =>
					string.Format("");
			Func<ChartPoint, string> labelPointAidat = chartPoint =>
		string.Format("");
			Func<ChartPoint, string> labelPointKiralama = chartPoint =>
		string.Format("");
			Func<ChartPoint, string> labelPointDigerGelir = chartPoint =>
		string.Format("");
			pieChart1.Series = new SeriesCollection
			{
				new PieSeries
				{
					Title = "Ürün Satışı",
					Values = new ChartValues<double> {dataUrun},
					PushOut = 5,
					DataLabels = true,
					LabelPoint = labelPointUrun
				  },
				new PieSeries
				{
					Title = "Aidat",
					Values = new ChartValues<double> {dataAidat}, PushOut = 5,
					DataLabels = true,
					LabelPoint = labelPointAidat
				},
				new PieSeries
				{
					Title = "Kiralama",
					Values = new ChartValues<double> {dataKiralama}, PushOut = 5,
					DataLabels = true,
					LabelPoint = labelPointKiralama
				},
				new PieSeries
				{
					Title = "Diğer Gelir",
					Values = new ChartValues<double> {dataDigerGelir}, PushOut = 5,
					DataLabels = true,
					LabelPoint = labelPointDigerGelir
				}
			};

			    //  pieChart1.LegendLocation = LegendLocation.Bottom;

			#endregion
			#region SolidGauge

			var dataGelirGiderMiktarlari = _finansService.BulundugumAyinGelirGiderMiktarlari();
			solidGauge1.From = 0;
			solidGauge1.To = 500000;
			foreach (var item in dataGelirGiderMiktarlari)
			{
				solidGauge1.Value = Convert.ToDouble(item.GelirMiktari);
			}
			solidGauge2.From = 0;
			solidGauge2.To = 500000;
			foreach (var item in dataGelirGiderMiktarlari)
			{
				solidGauge2.Value = Convert.ToDouble(item.GiderMiktari);
			}
			#endregion

		}


		private void btnFinansYonetimi_Click(object sender, EventArgs e)
		{
			pnlFinansYonetimi.Visible = true;
			pnlAna.Controls.Clear();
			GelirGider GelirGiderform = new GelirGider();
			GelirGiderform.TopLevel = false;
			pnlAna.Controls.Add(GelirGiderform);
			GelirGiderform.Show();
			GelirGiderform.Dock = DockStyle.Fill;
			GelirGiderform.SendToBack();

		}

		private void btnKisiYonetimi_Click(object sender, EventArgs e)
		{
			pnlKisiYonetimi.Visible = true;
			pnlFinansYonetimi.Visible = false;
			pnlAna.Controls.Clear();
			Uyeler Uyelerform = new Uyeler();
			Uyelerform.TopLevel = false;
			pnlAna.Controls.Add(Uyelerform);
			Uyelerform.Show();
			Uyelerform.Dock = DockStyle.Fill;
			Uyelerform.SendToBack();

		}

		private void btnHesapYonetimi_Click(object sender, EventArgs e)
		{
			pnlHesapYonetimi.Visible = true;
			pnlFinansYonetimi.Visible = false;
			pnlKisiYonetimi.Visible = false;

			pnlAna.Controls.Clear();
			Ayarlar Ayarlarform = new Ayarlar();
			Ayarlarform.TopLevel = false;
			pnlAna.Controls.Add(Ayarlarform);
			Ayarlarform.Show();
			Ayarlarform.Dock = DockStyle.Fill;
			Ayarlarform.SendToBack();
		}

		private void btnFinansYonetimi_MouseHover(object sender, EventArgs e)
		{
			pnlFinansYonetimi.Visible = true;
			pnlKisiYonetimi.Visible = false;
			pnlHesapYonetimi.Visible = false;
			pnlKucukAnaSayfa.Visible = false;
			pnlKucukFinansYonetimi.Visible = true;
			pnlKucukHesapYonetimi.Visible = false;
			pnlKucukKisiYonetimi.Visible = false;
		}

		private void btnFinansYonetimi_MouseLeave(object sender, EventArgs e)
		{
			
		}

		private void pnlFinansYonetimi_MouseHover(object sender, EventArgs e)
		{
			pnlFinansYonetimi.Visible = true;
		}

		private void btnGelirlerGiderler_Click(object sender, EventArgs e)
		{
			pnlFinansYonetimi.Visible = false;
			pnlAna.Controls.Clear();
			GelirGider GelirGiderform = new GelirGider();
			GelirGiderform.TopLevel = false;
			pnlAna.Controls.Add(GelirGiderform);
			GelirGiderform.Show();
			GelirGiderform.Dock = DockStyle.Fill;
			GelirGiderform.SendToBack();

		}

		private void btnUrunler_Click(object sender, EventArgs e)
		{
			pnlFinansYonetimi.Visible = false;
			pnlAna.Controls.Clear();
			Urunler Urunlerform = new Urunler();
			Urunlerform.TopLevel = false;
			pnlAna.Controls.Add(Urunlerform);
			Urunlerform.Show();
			Urunlerform.Dock = DockStyle.Fill;
			Urunlerform.SendToBack();
		}

		private void btnRaporlar_Click(object sender, EventArgs e)
		{
			pnlFinansYonetimi.Visible = false;
			pnlAna.Controls.Clear();
			Raporlar Raporlarform = new Raporlar();
			Raporlarform.TopLevel = false;
			pnlAna.Controls.Add(Raporlarform);
			Raporlarform.Show();
			Raporlarform.Dock = DockStyle.Fill;
			Raporlarform.SendToBack();


		}

		private void btnKisiYonetimi_MouseHover(object sender, EventArgs e)
		{
			pnlKisiYonetimi.Visible = true;
			pnlFinansYonetimi.Visible = false;
			pnlHesapYonetimi.Visible = false;
			pnlKucukKisiYonetimi.Visible = true;
			pnlKucukHesapYonetimi.Visible = false;
			pnlKucukFinansYonetimi.Visible = false;
			pnlKucukAnaSayfa.Visible = false;
		}

		private void btnUyeler_Click(object sender, EventArgs e)
		{
			pnlKisiYonetimi.Visible = false;
			pnlAna.Controls.Clear();
			Uyeler Uyelerform = new Uyeler();
			Uyelerform.TopLevel = false;
			pnlAna.Controls.Add(Uyelerform);
			Uyelerform.Show();
			Uyelerform.Dock = DockStyle.Fill;
			Uyelerform.SendToBack();

		}

		private void btnSporcular_Click(object sender, EventArgs e)
		{
			pnlKisiYonetimi.Visible = false;
			pnlAna.Controls.Clear();
			Sporcular Sporcularform = new Sporcular();
			Sporcularform.TopLevel = false;
			pnlAna.Controls.Add(Sporcularform);
			Sporcularform.Show();
			Sporcularform.Dock = DockStyle.Fill;
			Sporcularform.SendToBack();
		}

		private void btnCalisanlar_Click(object sender, EventArgs e)
		{
			pnlKisiYonetimi.Visible = false;
			pnlAna.Controls.Clear();
			CalisanlarForm Calisanlarform = new CalisanlarForm();
			Calisanlarform.TopLevel = false;
			pnlAna.Controls.Add(Calisanlarform);
			Calisanlarform.Show();
			Calisanlarform.Dock = DockStyle.Fill;
			Calisanlarform.SendToBack();
		}

		private void btnAnasayfa_Click(object sender, EventArgs e)
		{
			pnlHesapYonetimi.Visible = false;
			pnlFinansYonetimi.Visible = false;
			pnlKisiYonetimi.Visible = false;

			pnlAna.Controls.Clear();
			AnasayfaGuncelDurum anasayfagunceldurumform = new AnasayfaGuncelDurum();
			anasayfagunceldurumform.TopLevel = false;
			pnlAna.Controls.Add(anasayfagunceldurumform);
			anasayfagunceldurumform.Show();
			anasayfagunceldurumform.Dock = DockStyle.Fill;
			anasayfagunceldurumform.SendToBack();
		}

		private void btnAnasayfa_MouseHover(object sender, EventArgs e)
		{

			pnlKucukAnaSayfa.Visible = true;
			pnlKucukFinansYonetimi.Visible = false;
			pnlKucukHesapYonetimi.Visible = false;
			pnlKucukKisiYonetimi.Visible = false;
			pnlHesapYonetimi.Visible = false;
			pnlFinansYonetimi.Visible = false;
			pnlKisiYonetimi.Visible = false;
		}

		private void btnHesapYonetimi_MouseHover(object sender, EventArgs e)
		{
			pnlHesapYonetimi.Visible = true;
			pnlFinansYonetimi.Visible = false;
			pnlKisiYonetimi.Visible = false;
			pnlKucukHesapYonetimi.Visible = true;
			pnlKucukAnaSayfa.Visible = false;
			pnlKucukFinansYonetimi.Visible = false;
			pnlKucukKisiYonetimi.Visible = false;
		}

		private void pnlAnasayfa_MouseHover(object sender, EventArgs e)
		{
			pnlFinansYonetimi.Visible = false;
			pnlKisiYonetimi.Visible = false;
			pnlHesapYonetimi.Visible = false;
			pnlKucukAnaSayfa.Visible = false;
			pnlKucukFinansYonetimi.Visible = false;
			pnlKucukHesapYonetimi.Visible = false;
			pnlKucukKisiYonetimi.Visible = false;
			
		}

		private void btnAyarlar_Click(object sender, EventArgs e)
		{
			pnlHesapYonetimi.Visible = false;

			pnlAna.Controls.Clear();
			Ayarlar Ayarlarform = new Ayarlar();
			Ayarlarform.TopLevel = false;
			pnlAna.Controls.Add(Ayarlarform);
			Ayarlarform.Show();
			Ayarlarform.Dock = DockStyle.Fill;
			Ayarlarform.SendToBack();
		}

		private void btnCikisYap_Click(object sender, EventArgs e)
		{
			pnlHesapYonetimi.Visible = false;

			KullaniciGiris kullaniciGiris = new KullaniciGiris();
			kullaniciGiris.Show();
			this.Hide();
		}

		private void pnlAnasayfa_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnAnasayfa_MouseLeave(object sender, EventArgs e)
		{
			
		}

		private void button1_MouseHover(object sender, EventArgs e)
		{
			pnlKucukAnaSayfa.Visible = true;
			pnlKucukFinansYonetimi.Visible = false;
			pnlKucukHesapYonetimi.Visible = false;
			pnlKucukKisiYonetimi.Visible = false;
		}

		private void panel1_MouseHover(object sender, EventArgs e)
		{
			
		}

		private void btnKucukFinansYonetimi_MouseHover(object sender, EventArgs e)
		{
			pnlKucukFinansYonetimi.Visible = true;
			pnlKucukAnaSayfa.Visible = false;
			pnlKucukHesapYonetimi.Visible = false;
			pnlKucukKisiYonetimi.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pnlAna.Controls.Clear();
			AnasayfaGuncelDurum anasayfagunceldurumform = new AnasayfaGuncelDurum();
			anasayfagunceldurumform.TopLevel = false;
			pnlAna.Controls.Add(anasayfagunceldurumform);
			anasayfagunceldurumform.Show();
			anasayfagunceldurumform.Dock = DockStyle.Fill;
			anasayfagunceldurumform.SendToBack();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void btnKucukFinansYonetimi_Click(object sender, EventArgs e)
		{
			pnlAna.Controls.Clear();
			GelirGider GelirGiderform = new GelirGider();
			GelirGiderform.TopLevel = false;
			pnlAna.Controls.Add(GelirGiderform);
			GelirGiderform.Show();
			GelirGiderform.Dock = DockStyle.Fill;
			GelirGiderform.SendToBack();
		}

		private void btnKucukKısıYonetimi_Click(object sender, EventArgs e)
		{
			pnlAna.Controls.Clear();
			Uyeler Uyelerform = new Uyeler();
			Uyelerform.TopLevel = false;
			pnlAna.Controls.Add(Uyelerform);
			Uyelerform.Show();
			Uyelerform.Dock = DockStyle.Fill;
			Uyelerform.SendToBack();
		}

		private void btnKucukHesapYonetimi_Click(object sender, EventArgs e)
		{
			pnlAna.Controls.Clear();
			Ayarlar Ayarlarform = new Ayarlar();
			Ayarlarform.TopLevel = false;
			pnlAna.Controls.Add(Ayarlarform);
			Ayarlarform.Show();
			Ayarlarform.Dock = DockStyle.Fill;
			Ayarlarform.SendToBack();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{

		}

		private void pnlAna_Paint(object sender, PaintEventArgs e)
		{

		}

		private void gelirGiderC_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
