using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.Entities.Models.EnumTypes;
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
using System.Windows.Forms.DataVisualization.Charting;
using Axis = LiveCharts.Wpf.Axis;

namespace CRMSporKulubu.WinUI.Deneme
{
	public partial class YillikUrunSatisGrafigi : Form
	{
		UrunService _urunService;
		public YillikUrunSatisGrafigi()
		{
			InitializeComponent();
			_urunService = new UrunService();
		}

		private void YillikUrunSatisGrafigi_Load(object sender, EventArgs e)
		{
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

	}
}

