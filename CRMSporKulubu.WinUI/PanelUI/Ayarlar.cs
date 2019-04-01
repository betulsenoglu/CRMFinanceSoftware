using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using CRMSporKulubu.Entities.Models.EnumTypes;
using CRMSporKulubu.WinUI.LoginUI;
using CRMSporKulubu.WinUI.MenuUI;
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
	public partial class Ayarlar : Form
	{
		GizliSoruService _gizliSoru;
		GirisIslemleriService _girisIslemleriService;
		CalisanService _calisanService;
		CalisanIletisimleriDTO _calisanIletisim;
		IletisimService _iletisimService;
		// private readonly KullaniciGiris KullaniciGuncellenecekBilgileri;
		public Ayarlar()
		{
			// KullaniciGuncellenecekBilgileri = KullaniciGuncellenecekBilgileri1;
			_gizliSoru = new GizliSoruService();
			_girisIslemleriService = new GirisIslemleriService();
			_calisanService = new CalisanService();
			_calisanIletisim = new CalisanIletisimleriDTO();
			_iletisimService = new IletisimService();
			InitializeComponent();
		}

		private void Ayarlar_Load(object sender, EventArgs e)
		{
			GizliSoruDoldur();
			CalisanDoldur();
		}
		public void GizliSoruDoldur()
		{


			cmbGizliSoru.DataSource = _gizliSoru.TumGizliSorulariGetir();
			cmbGizliSoru.DisplayMember = "Soru";
			cmbGizliSoru.ValueMember = "ID";
		}
		public void CalisanDoldur()
		{
			txtAd.Text = KullaniciGiris._girisYapanKullanici.Ad;
			txtSoyad.Text = KullaniciGiris._girisYapanKullanici.Soyad;
			txtTCNo.Text = KullaniciGiris._girisYapanKullanici.TCKimlikNo;
			//txtEmail.Text = KullaniciGiris._girisYapanKullanici.CalisanIletisimleri.Where(x => x.AktifMi == true).FirstOrDefault().EMail;
			_calisanIletisim = _calisanService.CalisanIletisimBilgileriniGetir(KullaniciGiris._girisYapanKullanici.ID).FirstOrDefault();
			txtEmail.Text = _calisanIletisim.Email;
			txtTel.Text = _calisanIletisim.Telefon;
			txtAdres.Text = _calisanIletisim.Adres;
			dtpDogumTarihi.Value = KullaniciGiris._girisYapanKullanici.DogumTarihi;
			if (KullaniciGiris._girisYapanKullanici.Cinsiyet == Cinsiyet.Kadin)
			{
				rdbKadin.Checked = true;
			}
			else
			{
				rdbErkek.Checked = false;
			}

		}

		Calisan seciliCalisan;

		GirisIslemleri girisIslemleri;
		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			Calisan yeniCalisan = new Calisan();
			Iletisim calisanIletisim = new Iletisim();
			int seciliCalisanID = Convert.ToInt32(KullaniciGiris._girisYapanKullanici.ID);
			seciliCalisan = _calisanService.CalisanGetirById(seciliCalisanID);

			girisIslemleri = _girisIslemleriService.GirisBilgileriGetir(seciliCalisanID);

			if (seciliCalisan != null)
			{

				if (girisIslemleri.GizliSoruCevap == txtGizliSoruCevap.Text && girisIslemleri.AktifMi == true)
				{
					yeniCalisan.ID = KullaniciGiris._girisYapanKullanici.ID;
					yeniCalisan.TCKimlikNo = txtTCNo.Text;
					yeniCalisan.Ad = txtAd.Text;
					yeniCalisan.Soyad = txtSoyad.Text;
					yeniCalisan.Cinsiyet = rdbErkek.Checked == true ? Cinsiyet.Erkek : Cinsiyet.Kadin;
					yeniCalisan.DogumTarihi = dtpDogumTarihi.Value;
					yeniCalisan.AktifMi = true;
					yeniCalisan.OlusturulmaTarihi = DateTime.Now;
					yeniCalisan.GuncellenmeTarihi = DateTime.Now;

					calisanIletisim.CalisanID = KullaniciGiris._girisYapanKullanici.ID;
					calisanIletisim.Telefon = txtTel.Text;
					calisanIletisim.Adres = txtAdres.Text;
					calisanIletisim.EMail = txtEmail.Text;
					calisanIletisim.AktifMi = true;
					calisanIletisim.OlusturulmaTarihi = DateTime.Now;
					calisanIletisim.GuncellenmeTarihi = DateTime.Now;

					//yeniCalisan.CalisanIletisimleri.Add(calisanIletisim);

					if (_calisanService.CalisanIletisimBilgileriniGetir(KullaniciGiris._girisYapanKullanici.ID).Count == 0)
					{
						_iletisimService.AddIletisimService(calisanIletisim);
					}
					else if (_calisanService.CalisanIletisimBilgileriniGetir(KullaniciGiris._girisYapanKullanici.ID).Count > 0)
					{
						_iletisimService.IletisimCalisanUpdate(calisanIletisim);
					}

					_calisanService.CalisanUpdate(yeniCalisan);
					MessageBox.Show("Profil Bilgisi Güncellendi.");
				}
				else
				{
					MessageBox.Show("Gizli Cevap Yanlış! Bunu Yapmaya Yetkiniz Yok!");
				}



			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			Calisan yeniCalisan = new Calisan();
			Iletisim calisanIletisim = new Iletisim();
			int seciliCalisanID = Convert.ToInt32(KullaniciGiris._girisYapanKullanici.ID);
			seciliCalisan = _calisanService.CalisanGetirById(seciliCalisanID);

			girisIslemleri = _girisIslemleriService.GirisBilgileriGetir(seciliCalisanID);

			if (seciliCalisan != null)
			{

				if (girisIslemleri.GizliSoruCevap == txtGizliSoruCevap.Text && girisIslemleri.AktifMi == true)
				{
				 DialogResult dialog=	MessageBox.Show("Hesabı Silme İşlemi Geri Alınamaz. Yine de Silmek İstiyor Musunuz?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
					if (DialogResult.Yes==dialog)
					{

					   _girisIslemleriService.HesabıSil(girisIslemleri);
						MessageBox.Show("Hesap Silindi! Giriş Ekranına Yönlendiriliyorsunuz.");
						KullaniciGiris kullaniciGiris = new KullaniciGiris();
						kullaniciGiris.Show();
						Anasayfa ana = new Anasayfa();
						ana.Hide();

						
					}
					else
					{
						MessageBox.Show("İşlem İptal Edildi.");
					}
				}
		    }
		}
	}
}
