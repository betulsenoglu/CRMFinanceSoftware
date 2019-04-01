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

namespace CRMSporKulubu.WinUI.LoginUI
{
    public partial class KullaniciKayit : Form
    {
		GirisIslemleriService _girisIslemleriService;
		CalisanService _calisanService;
		GizliSoruService _gizliSoruService;
        public KullaniciKayit()
        {
            InitializeComponent();
			_calisanService = new CalisanService();
			_gizliSoruService = new GizliSoruService();
			_girisIslemleriService = new GirisIslemleriService();
        }

		private void label4_Click(object sender, EventArgs e)
		{

		}
		Calisan calisan = new Calisan();
		GirisIslemleri giris = new GirisIslemleri();

		private void btnKayitOl_Click(object sender, EventArgs e)
		{
			
			if (txtSifre.Text!=txtSifreTekrar.Text)
			{
				errorProvider1.SetError(txtSifreTekrar, "Şifre Hatalı!");
				
			}
			else
			{
				if (_calisanService.TcIleAra(txtTcKimlikNo.Text)!=0 )
				{
					
					giris.GizliSoruID = Convert.ToInt32(cmbGizliSoru.SelectedValue);
					giris.GizliSoruCevap = txtGizliSoruCevabi.Text;
					giris.KullaniciAdi = txtKullaniciAdi.Text;
					giris.OlusturulmaTarihi = DateTime.Now;
					giris.Sifre = txtSifre.Text;
					giris.AktifMi = true;
					giris.KullaniciMi = true;
					calisan=_calisanService.CalisanGetirById(_calisanService.TcIleAra(txtTcKimlikNo.Text));
					giris.CalisanID = calisan.ID;
					if (calisan.GirisIslemleri.Count>0 || calisan.KullaniciMi==false)
					{
						MessageBox.Show("Kayıt Başarısız! Kullanıcı yetkiniz olmayabilir veya halihazırda bir kaydınız var!");
					}
					else
					{

					    _girisIslemleriService.GirisBilgisiEkle(giris);
						MessageBox.Show("Kayıt Başarıyla Gerçekleşti.");
					}
					
				}
				else
				{
					MessageBox.Show("Yetkiniz Yok! Manager ile görüşün!","YETKILENDIRME HATASI");
				}
				
				
				
				
			}
		}

		private void KullaniciKayit_Load(object sender, EventArgs e)
		{
			cmbGizliSoru.DataSource = _gizliSoruService.TumGizliSorulariGetir();
			cmbGizliSoru.DisplayMember = "Soru";
			cmbGizliSoru.ValueMember = "ID";
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			KullaniciGiris kullaniciGiris = new KullaniciGiris();
			kullaniciGiris.Show();
			this.Close();
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void txtSifre_Click(object sender, EventArgs e)
		{
			txtSifre.PasswordChar = '*';
		}

		private void txtSifreTekrar_Click(object sender, EventArgs e)
		{
			txtSifreTekrar.PasswordChar = '*';
		}

		private void txtKullaniciAdi_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData == Keys.Tab)
			{
				txtSifre.Text = "";
				txtSifre.PasswordChar = '*';
			}
		}

		private void txtSifre_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData == Keys.Tab)
			{
				txtSifreTekrar.Text = "";
				txtSifreTekrar.PasswordChar = '*';
			}
		}

		private void txtTcKimlikNo_Click(object sender, EventArgs e)
		{
			txtTcKimlikNo.Text = "";
		}

		private void txtTcKimlikNo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			
			
		}

		private void txtAd_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			
		}

		private void txtSoyad_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			
		}

		private void txtYeniKayitOlEmail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			
		}
	}
}
