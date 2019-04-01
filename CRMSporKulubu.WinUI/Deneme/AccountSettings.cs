using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.Entities.Models;
using CRMSporKulubu.WinUI.LoginUI;
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
    public partial class AccountSettings : Form
    {
        GizliSoruService _gizliSoru;
        GirisIslemleriService _girisIslemleriService;

        CalisanService _calisanService;
        IletisimService _iletisimService;

        private readonly KullaniciGiris KullaniciGuncellenecekBilgileri;

        public AccountSettings(KullaniciGiris KullaniciGuncellenecekBilgileri1)
        {
            KullaniciGuncellenecekBilgileri = KullaniciGuncellenecekBilgileri1;
            _gizliSoru = new GizliSoruService();
            _girisIslemleriService = new GirisIslemleriService();
            _calisanService = new CalisanService();
            _iletisimService = new IletisimService();


            InitializeComponent();
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            //int seciliCalisanID = Convert.ToInt32(KullaniciGiris._girisYapanKullanici.ID);
            //seciliCalisan = _calisanService.CalisanGetirById(seciliCalisanID);

            //if (cbGizliSoru.Checked == true && KullaniciGiris._girisYapanKullaniciGizliSoru.GizliSoruCevap == txtGizliSoruCevap.Text)
            //{
            //    cmbYeniGizliSoru.Enabled = true;
            //    txtYeniGizliSoruCevabı.Enabled = true;


            //}
            //if (cbGizliSoru.Checked == false)
            //{
            //    cmbYeniGizliSoru.Enabled = false;
            //    txtYeniGizliSoruCevabı.Enabled = false;
            //}
            //CalisanDoldur();
            //GizliSoruDoldur();

        }

        public void GizliSoruDoldur()
        {


            cmbGizliSoru.DataSource = _gizliSoru.TumGizliSorulariGetir();
            cmbGizliSoru.DisplayMember = "Soru";
            cmbGizliSoru.ValueMember = "ID";

            cmbYeniGizliSoru.DataSource = _gizliSoru.TumGizliSorulariGetir();
            cmbYeniGizliSoru.DisplayMember = "Soru";
            cmbYeniGizliSoru.ValueMember = "ID";
        }


        public void CalisanDoldur()
        {
            ////Kullanici Bilgileri
            //txtTCNo.Text = KullaniciGiris._girisYapanKullanici.TCKimlikNo;
            //txtAd.Text = KullaniciGiris._girisYapanKullanici.Ad;
            //txtSoyad.Text = KullaniciGiris._girisYapanKullanici.Soyad;
            //dtpDogumTarihi.Value = KullaniciGiris._girisYapanKullanici.DogumTarihi;
            //txtAdres.Text = KullaniciGiris._girisYapanKullanciIletisim.Adres;
            ////Kullanici İletisimleri İletisim Tablosundan Çağırıldı
            //txtEmail.Text = KullaniciGiris._girisYapanKullanciIletisim.EMail;
            //txtTelefon.Text = KullaniciGiris._girisYapanKullanciIletisim.Telefon;


            dtpDogumTarihi.Value = KullaniciGiris._girisYapanKullanici.DogumTarihi;

            cmbGizliSoru.DataSource = null;
            cmbGizliSoru.SelectedValue = KullaniciGiris._girisYapanKullanici.ID + 1;



        }
        Calisan seciliCalisan;

        GirisIslemleri girisIslemleri;
        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            int seciliCalisanID = Convert.ToInt32(KullaniciGiris._girisYapanKullanici.ID);
            seciliCalisan = _calisanService.CalisanGetirById(seciliCalisanID);

			
							
            if (seciliCalisan != null)
            {

				

				seciliCalisan.TCKimlikNo = txtTCNo.Text;
                seciliCalisan.Ad = txtAd.Text;
                seciliCalisan.Soyad = txtSoyad.Text;
                seciliCalisan.DogumTarihi = dtpDogumTarihi.Value;
                seciliCalisan.AktifMi = true;


                Iletisim iletisimBilgisi = new Iletisim();

                iletisimBilgisi.CalisanID = seciliCalisan.ID;
                iletisimBilgisi.Telefon = txtTelefon.Text;
                iletisimBilgisi.EMail = txtEmail.Text;
                iletisimBilgisi.Adres = txtAdres.Text;
                iletisimBilgisi.AktifMi = true;
                iletisimBilgisi.OlusturulmaTarihi = DateTime.Now;

                _iletisimService.IletisimCalisanUpdate(iletisimBilgisi);

                girisIslemleri = _girisIslemleriService.GirisBilgileriGetir(seciliCalisanID);


                //if (cbGizliSoru.Checked == true && KullaniciGiris._girisYapanKullaniciGizliSoru.GizliSoruCevap == txtGizliSoruCevap.Text)
                //{
                //    cmbYeniGizliSoru.Enabled = true;
                //    txtYeniGizliSoruCevabı.Enabled = true;

                //    if ((int)cmbYeniGizliSoru.SelectedValue > 0)
                //    {
                //        girisIslemleri.CalisanID = seciliCalisan.ID;
                //        girisIslemleri.GizliSoruID = (int)cmbYeniGizliSoru.SelectedValue;
                //        //girisIslemleri.CalisanID = (int)cmbYeniGizliSoru.SelectedValue;
                //        girisIslemleri.GizliSoruCevap = txtYeniGizliSoruCevabı.Text;

                //    }
                //}

                               

                _girisIslemleriService.GirisGuncelle(girisIslemleri);

                if (_calisanService.CalisanIletisimBilgileriniGetir(seciliCalisan.ID).Count > 0)
                {
                    _girisIslemleriService.GirisGuncelle(girisIslemleri);
                }
                else if (_calisanService.CalisanIletisimBilgileriniGetir(seciliCalisan.ID).Count > 0)
                {
                    _iletisimService.IletisimCalisanUpdate(iletisimBilgisi);
                }

                _calisanService.CalisanUpdate(seciliCalisan);

                MessageBox.Show("Calisan Bilgisi Guncellendi.");

            }




            else
            {
                MessageBox.Show("Hata");

            }


        }

    }
}

