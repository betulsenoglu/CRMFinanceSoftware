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

namespace CRMSporKulubu.WinUI.Deneme
{
    public partial class YeniCalisanEkle : Form
    {
        private readonly Calisanlar calisan;
        CalisanService _calisanService;
        IletisimService _iletisimService;
        public YeniCalisanEkle(Calisanlar calisan1)
        {
            calisan = calisan1;
            InitializeComponent();
            _calisanService = new CalisanService();
            _iletisimService = new IletisimService();
        }

        private void YeniCalisanEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Iletisim yeniCalisanIletisimBilgileri = new Iletisim();

                Calisan yeniCalisan = new Calisan();

                yeniCalisan.TCKimlikNo = txtTCNo.Text;
                yeniCalisan.Ad = txtAd.Text;
                yeniCalisan.Soyad = txtSoyad.Text;
                yeniCalisan.DogumTarihi = dtpDogumTarihi.Value;
                yeniCalisan.Cinsiyet = rdbErkek.Checked == true ? Cinsiyet.Erkek : Cinsiyet.Kadin;
                yeniCalisan.OlusturulmaTarihi = DateTime.Now;
                yeniCalisan.Maas = nmrMaasBilgisi.Value;
                yeniCalisan.AktifMi = true;
                yeniCalisan.KullaniciMi = chkRegisterYetkisi.Checked == true ? true : false;
                _calisanService.AddCalisanService(yeniCalisan);

                yeniCalisanIletisimBilgileri.CalisanID = yeniCalisan.ID;
                yeniCalisanIletisimBilgileri.Adres = txtAdres.Text;
                yeniCalisanIletisimBilgileri.Telefon = txtTel.Text;
                yeniCalisanIletisimBilgileri.EMail = txtEmail.Text;
                yeniCalisanIletisimBilgileri.OlusturulmaTarihi = DateTime.Now;
                yeniCalisanIletisimBilgileri.AktifMi = true;

                _iletisimService.AddIletisimService(yeniCalisanIletisimBilgileri);
                MessageBox.Show("Eklendi");
                KontrolleriSil();
            }
            catch
            {
                MessageBox.Show("Bir Hata Olustu!");
            }

            calisan.GridCalisanlarDoldur();

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
    }
}
