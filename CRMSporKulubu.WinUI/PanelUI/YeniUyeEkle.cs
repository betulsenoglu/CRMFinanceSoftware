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

namespace CRMSporKulubu.WinUI.PanelUI
{
	public partial class YeniUyeEkle : Form
	{
		UyeService _uyeService;
		IletisimService _uyeIletisimService;
		private readonly Uyeler uyeler;
		public YeniUyeEkle(Uyeler uyeler1)
		{
			InitializeComponent();
			_uyeService = new UyeService();
			_uyeIletisimService = new IletisimService();
			uyeler = uyeler1;
		}

		

		private void btnUyeEkle_Click_1(object sender, EventArgs e)
		{
			try
			{
				Iletisim yeniUyeIletisimBilgileri = new Iletisim();

				Uye yeniUye = new Uye();

				yeniUye.TCKimlikNo = txtTCNo.Text;
				yeniUye.Ad = txtAd.Text;
				yeniUye.Soyad = txtSoyad.Text;
				yeniUye.DogumTarihi = dtpDogumTarihi.Value;
				yeniUye.Cinsiyet = rdbErkek.Checked == true ? Cinsiyet.Erkek : Cinsiyet.Kadin;
				yeniUye.OlusturulmaTarihi = DateTime.Now;
				yeniUye.Aidat = nmrAidatBilgisi.Value;
				yeniUye.AktifMi = true;
				_uyeService.AddUyeService(yeniUye);

				yeniUyeIletisimBilgileri.UyeID = yeniUye.ID;
				yeniUyeIletisimBilgileri.Adres = txtAdres.Text;
				yeniUyeIletisimBilgileri.Telefon = txtTel.Text;
				yeniUyeIletisimBilgileri.EMail = txtEmail.Text;
				yeniUyeIletisimBilgileri.OlusturulmaTarihi = DateTime.Now;
				yeniUyeIletisimBilgileri.AktifMi = true;

				_uyeIletisimService.AddIletisimService(yeniUyeIletisimBilgileri);
				MessageBox.Show("Eklendi");
				KontrolleriSil();

			}
			catch
			{
				MessageBox.Show("Bir Hata Olustu!");
			}

			uyeler.UyeGridDoldur();
			this.Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void YeniUyeEkle_Load(object sender, EventArgs e)
		{

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
				if (item is RadioButton)
				{
					RadioButton rdb = item as RadioButton;
					rdb.Checked = false;
				}
				if (item is CheckBox)
				{
					CheckBox cb = item as CheckBox;
					cb.Checked = false;
				}
			}
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
