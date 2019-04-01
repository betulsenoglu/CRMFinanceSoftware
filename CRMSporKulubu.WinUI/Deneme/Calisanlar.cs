using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.Entities.DTO;
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
    public partial class Calisanlar : Form
    {
        CalisanService _calisanService;
        IletisimService _IletisimService;

        public Calisanlar()
        {
            InitializeComponent();
            _calisanService = new CalisanService();
            _IletisimService = new IletisimService();
        }
        public void GridCalisanlarDoldur()
        {
            List<CalisanInfoDTO> calisanListesi = _calisanService.CalisanAllContactInfo();
            dgvCalisanlar.DataSource = null;
            dgvCalisanlar.DataSource = calisanListesi;
        }
        private void Calisanlar_Load(object sender, EventArgs e)
        {
            GridCalisanlarDoldur();
            

        }

        private void dgvCalisanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Calisan seciliCalisan;
        List<CalisanIletisimleriDTO> seciliCalisanIletisimleri;
        private void dgvCalisanlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int seciliCalisanId =Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells["ID"].Value);
            seciliCalisan= _calisanService.CalisanGetirById(seciliCalisanId);
            seciliCalisanIletisimleri = _calisanService.CalisanIletisimBilgileriniGetir(seciliCalisanId);
            txtTCNo.Text = seciliCalisan.TCKimlikNo;
            txtAd.Text = seciliCalisan.Ad;
            txtSoyad.Text = seciliCalisan.Soyad;
            dtpDogumTarihi.Value = seciliCalisan.DogumTarihi;
            if (seciliCalisan.Cinsiyet == 0)
                rdbErkek.Checked = true;
            else
                rdbKadin.Checked = true;
            if (seciliCalisanIletisimleri.Count != 0)
            {
                txtEmail.Text = seciliCalisanIletisimleri.FirstOrDefault().Email;
                txtTel.Text = seciliCalisanIletisimleri.FirstOrDefault().Telefon;
                txtAdres.Text = seciliCalisanIletisimleri.FirstOrDefault().Adres;
            }
            else
            {
                txtEmail.Text = "";
                txtTel.Text = "";
                txtAdres.Text = "";
            }
            dtpKayitTarihi.Value = seciliCalisan.OlusturulmaTarihi.Value;
            nmrMaasBilgisi.Value = seciliCalisan.Maas;
            if (seciliCalisan.KullaniciMi==true)
            {
                chkRegisterYetkisi.Checked = true;
            }
            else
            chkRegisterYetkisi.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (seciliCalisan != null)
            {
                seciliCalisan.TCKimlikNo = txtTCNo.Text;
                seciliCalisan.Ad = txtAd.Text;
                seciliCalisan.Soyad = txtSoyad.Text;
                seciliCalisan.DogumTarihi = dtpDogumTarihi.Value;
                seciliCalisan.Cinsiyet = rdbErkek.Checked == true ? Cinsiyet.Erkek : Cinsiyet.Kadin;
                seciliCalisan.OlusturulmaTarihi = dtpKayitTarihi.Value;
                seciliCalisan.Maas = nmrMaasBilgisi.Value;
                seciliCalisan.KullaniciMi = chkRegisterYetkisi.Checked == true ? true : false;
                Iletisim iletisimBilgisi = new Iletisim();
                iletisimBilgisi.CalisanID = seciliCalisan.ID;
                iletisimBilgisi.Telefon = txtTel.Text;
                iletisimBilgisi.EMail = txtEmail.Text;
                iletisimBilgisi.Adres = txtAdres.Text;
                iletisimBilgisi.AktifMi = true;
                iletisimBilgisi.OlusturulmaTarihi = DateTime.Now;
                if (_calisanService.CalisanIletisimBilgileriniGetir(seciliCalisan.ID).Count == 0)
                {
                    _IletisimService.AddIletisimService(iletisimBilgisi);
                }
                else if (_calisanService.CalisanIletisimBilgileriniGetir(seciliCalisan.ID).Count > 0)
                {
                    _IletisimService.IletisimCalisanUpdate(iletisimBilgisi);
                }

                _calisanService.CalisanUpdate(seciliCalisan);
                MessageBox.Show("Calisan Bilgisi Guncellendi.");
                GridCalisanlarDoldur();
                KontrolleriSil();
            }
            else
                MessageBox.Show("Bir Calisan Secmelisiniz!");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (seciliCalisan != null)
            {
                int etkilenen = _calisanService.CalisanSil(seciliCalisan);
                if (etkilenen > 0)
                {
                    GridCalisanlarDoldur();
                    MessageBox.Show("Calisan Basariyla Kaldirildi.");
                    KontrolleriSil();
                }
                else
                    MessageBox.Show("Bir Hata Olustu");
            }
            else
                MessageBox.Show("Bir Calisan Secmelisiniz!");
        }

        private void txtSporcuAra_TextChanged(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = _calisanService.CalisanAllContactInfoIsmeGore(txtSporcuAra.Text);
        }
        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            YeniCalisanEkle yeniCalisanEkleform = new YeniCalisanEkle(this);
            yeniCalisanEkleform.Show();
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
