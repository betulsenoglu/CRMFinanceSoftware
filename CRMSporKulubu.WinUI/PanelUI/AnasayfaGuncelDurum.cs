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
using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.Entities.Models;
using CRMSporKulubu.Entities.Models.EnumTypes;
using LiveCharts;
using LiveCharts.Wpf;

namespace CRMSporKulubu.WinUI.PanelUI
{
	public partial class AnasayfaGuncelDurum : Form
	{

		FinansTakipService _finansTakipService;
		public AnasayfaGuncelDurum()
		{
			InitializeComponent();
			_finansTakipService = new FinansTakipService();
		}

		private void AnasayfaGuncelDurum_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _finansTakipService.GecikenleriGetir();
			#region CIZGI GRAFIK

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
				Foreground= System.Windows.Media.Brushes.Black,
			    FontWeight = System.Windows.FontWeights.Bold,
			    MinValue = 0,
				Title = "Toplam Tutar"
			});

			cartesianChart1.LegendLocation = LegendLocation.Top;




			#endregion
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

       

		private void txtFinansArama_TextChanged_1(object sender, EventArgs e)
		{
			dataGridView1.DataSource = _finansTakipService.KategoriBilgileriniGetir(txtFinansArama.Text);
		}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void txtFinansArama_Click(object sender, EventArgs e)
		{
			txtFinansArama.Text = "";
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.ClearSelection();
		}
	}
}
