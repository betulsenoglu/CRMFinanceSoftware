using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.Entities.DTO;
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
	public partial class Calisanİslemleri : Form
	{
		CalisanService _calisanService;
		IletisimService _iletisimService;
		public Calisanİslemleri()
		{
			InitializeComponent();
			_calisanService = new CalisanService();
			_iletisimService = new IletisimService();
		}

		public void CalisanGridDoldur()
		{
			List<CalisanInfoDTO> calisanListesi = _calisanService.CalisanAllContactInfo();
			//BindingList<UyeInfoDTO> uyeListesi1 =
			//new BindingList<UyeInfoDTO>(uyeListesi.ToList());
			dgvCalisan.DataSource = null;
			dgvCalisan.DataSource = calisanListesi;
			//List<UyeInfoDTO> bs = new BindingSource();
			//bs.DataSource = uyeListesi;
			//dgv.DataSource = bs;
			// AdvancedList(uyeListesi);

		}
		private void Calisanİslemleri_Load(object sender, EventArgs e)
		{
			CalisanGridDoldur();
		}

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
