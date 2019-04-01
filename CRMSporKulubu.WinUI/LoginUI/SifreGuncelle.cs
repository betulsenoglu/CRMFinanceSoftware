using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSporKulubu.WinUI.LoginUI
{
	public partial class SifreGuncelle : Form
	{
		private SifreGuncelle settings;
		GizliSoruService _gizliSoruService;
		GirisIslemleriService _girisIslemleriService;
		CalisanService _calisanService;
		public SifreGuncelle()
		{
			InitializeComponent();
			_calisanService = new CalisanService();
			_gizliSoruService = new GizliSoruService();
			_girisIslemleriService = new GirisIslemleriService();
		}


		private void btnSifreGuncelle_Click(object sender, EventArgs e)
		{
			int id = _calisanService.emaileGoreGetir(txtEmail.Text);			
			GirisIslemleri kullaniciGirisBilgisi = _girisIslemleriService.GirisBilgileriGetir(id);
			GirisIslemleri yeniGiris = new GirisIslemleri();
			if (txtCevap.Text == kullaniciGirisBilgisi.GizliSoruCevap)
			{

				if (txtSifre.Text == txtSifreTekrar.Text)
				{
					int a = _girisIslemleriService.KullaniciSifreDegistir(id, txtSifre.Text);
					if (a > 0)
					{
						MessageBox.Show("Şifre Değiştirildi");
						_girisIslemleriService.GirisGuncelle(kullaniciGirisBilgisi);
						this.Close();
						KullaniciGiris kullaniciGiris = new KullaniciGiris();
						kullaniciGiris.Show();
					}
				}
				else
				{
					MessageBox.Show("Şifreler Aynı Değil!");
					txtCevap.Text = "Gizli Cevap";
					txtSifre.Text = "Şifre";
					txtSifreTekrar.Text = "Şifre Tekrar";
				} 
			}
			else
			{
				MessageBox.Show("Cevap Hatalı! Güncelleme Başarısız!");
				txtCevap.Text = "Gizli Cevap";
				txtSifre.Text = "Şifre";
				txtSifreTekrar.Text = "Şifre Tekrar";
			}
		}

		private void SifreGuncelle_Load(object sender, EventArgs e)
		{

		}

		private void btnİlerle_Click_1(object sender, EventArgs e)
		{
			int KullaniciID = _calisanService.emaileGoreGetir(txtEmail.Text);
			if (KullaniciID == 0)
			{
				MessageBox.Show("Kullanıcı Bulunamadı!");
				txtEmail.Text = "Email-Kullanıcı Adı";
			}
			else
			{
				GirisIslemleri kullaniciGirisBilgisi = _girisIslemleriService.GirisBilgileriGetir(KullaniciID);
				GizliSoru kullaniciGizliSoru = _gizliSoruService.GizliSoruGetirById(kullaniciGirisBilgisi.GizliSoruID);
				label4.Text = kullaniciGizliSoru.Soru;
			}

		}

		private void txtCevap_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData==Keys.Tab)
			{
				txtSifre.Text = "";
			}
		}

		private void txtSifre_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData==Keys.Tab)
			{
				txtSifreTekrar.Text = "";
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			KullaniciGiris kullaniciGiris = new KullaniciGiris();
			kullaniciGiris.Show();
			this.Close();
		}
	}
}
