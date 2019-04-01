using CRMSporKulubu.BLL.CRMSporKulubuService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMSporKulubu.WinUI.MenuUI;
using CRMSporKulubu.Entities.Models;
using CRMSporKulubu.WinUI.Deneme;

namespace CRMSporKulubu.WinUI.LoginUI
{
	public partial class KullaniciGiris : Form
	{
		Calisan girisYapanKullanici;
		public static Calisan _girisYapanKullanici;
		CalisanService _calisanService;
		GirisIslemleriService _girisIslemleriService;
		Iletisim girisYapanKullaniciIletisim;
		public KullaniciGiris()
		{
			InitializeComponent();
			_calisanService = new CalisanService();
			_girisIslemleriService = new GirisIslemleriService();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGirisYap_Click(object sender, EventArgs e)
		{

			bool Kontrol = _girisIslemleriService.KullaniciLoginKontrol(txtKullaniciAdi.Text, txtSifre.Text);

			label1.Visible = false;
			if (Kontrol)
			{
				girisYapanKullanici = _girisIslemleriService.girisYapanKullaniciGetir(txtKullaniciAdi.Text, txtSifre.Text);
				_girisYapanKullanici = girisYapanKullanici;
				//anasayfa açılacak.
				//MessageBox.Show("Test");
				Anasayfa anasayfa = new Anasayfa();
				anasayfa.Show();
				this.Hide();
			}
			else
			{
				label1.Visible = true;
				txtKullaniciAdi.Text = "Email-Kullanıcı Adı";
				txtSifre.Text = "Şifre";
			}

		}

		private void KullaniciGiris_Load(object sender, EventArgs e)
		{
			label1.Visible = false;
		}

		private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SifreGuncelle sifreGuncelle = new SifreGuncelle();
			sifreGuncelle.Show();
			this.Hide();
		}

		private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			KullaniciKayit kullaniciKayit = new KullaniciKayit();
			kullaniciKayit.Show();
			this.Hide();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtKullaniciAdi_Click(object sender, EventArgs e)
		{
			txtKullaniciAdi.Text = "";
		}

		private void txtSifre_Click(object sender, EventArgs e)
		{
			txtKullaniciAdi.Text = "";
		}
	}
}
