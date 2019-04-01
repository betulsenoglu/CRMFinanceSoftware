using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.DAL.RepositoryConcrete;
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
    public partial class Uyeler : Form
    {
        UyeService _uyeService;
        IletisimService _iletisimService;
        public Uyeler()
        {
            InitializeComponent();
            _uyeService = new UyeService();
            _iletisimService = new IletisimService();
        }
        public void UyeGridDoldur()
        {
            List<UyeInfoDTO> uyeListesi = _uyeService.UyeAllContactInfo();
            dgvUyeler.DataSource = null;
            dgvUyeler.DataSource = uyeListesi;

        }

        public void UyeGridAramayaGoreDoldur()
        {
            dgvUyeler.DataSource = null;
            List<UyeInfoDTO> uyeList = _uyeService.UyeAllContactInfoIsmeGore(txtUyeAra.Text);
            dgvUyeler.DataSource = uyeList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Uyeler_Load(object sender, EventArgs e)
        {
            UyeGridDoldur();

        }

        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            UyeGridAramayaGoreDoldur();
        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvUyeler_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        Uye seciliUye;
        List<UyeIletisimleriDTO> seciliUyeIletisimleri;
        private void dgvUyeler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string seciliUyeTC = dgvUyeler.SelectedRows[0].Cells["TCKimlikNo"].Value.ToString();
            seciliUye = _uyeService.getByTC(seciliUyeTC);
            seciliUyeIletisimleri = _uyeService.uyeIletisimBilgileriniGetir(seciliUye.ID);
            txtTCNo.Text = seciliUye.TCKimlikNo;
            txtAd.Text = seciliUye.Ad;
            txtSoyad.Text = seciliUye.Soyad;
            dtpDogumTarihi.Value = seciliUye.DogumTarihi;
            if (seciliUye.Cinsiyet == 0)
                rdbErkek.Checked = true;
            else
                rdbKadin.Checked = true;
            if (seciliUyeIletisimleri.Count != 0)
            {
                txtEmail.Text = seciliUyeIletisimleri.FirstOrDefault().Email;
                txtTel.Text = seciliUyeIletisimleri.FirstOrDefault().Telefon;
                txtAdres.Text = seciliUyeIletisimleri.FirstOrDefault().Adres;
            }
            else
            {
                txtEmail.Text = "";
                txtTel.Text = "";
                txtAdres.Text = "";
            }
            dtpKayitTarihi.Value = seciliUye.OlusturulmaTarihi.Value;
            nmrAidatBilgisi.Value = seciliUye.Aidat;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (seciliUye != null)
            {
                seciliUye.TCKimlikNo = txtTCNo.Text;
                seciliUye.Ad = txtAd.Text;
                seciliUye.Soyad = txtSoyad.Text;
                seciliUye.DogumTarihi = dtpDogumTarihi.Value;
                seciliUye.Cinsiyet = rdbErkek.Checked == true ? Cinsiyet.Erkek : Cinsiyet.Kadin;
                seciliUye.OlusturulmaTarihi = dtpKayitTarihi.Value;
           //     seciliUye.GuncellenmeTarihi = DateTime.Now;
                seciliUye.Aidat = nmrAidatBilgisi.Value;
                Iletisim iletisimBilgisi = new Iletisim();
                iletisimBilgisi.UyeID = seciliUye.ID;
                iletisimBilgisi.Telefon = txtTel.Text;
                iletisimBilgisi.EMail = txtEmail.Text;
                iletisimBilgisi.Adres = txtAdres.Text;
                iletisimBilgisi.AktifMi = true;
                iletisimBilgisi.OlusturulmaTarihi = DateTime.Now;
                if (_uyeService.uyeIletisimBilgileriniGetir(seciliUye.ID).Count == 0)
                {
                  //  seciliUye.UyeIletisimleri.Add(iletisimBilgisi);
                    _iletisimService.AddIletisimService(iletisimBilgisi);
                }
                else if (_uyeService.uyeIletisimBilgileriniGetir(seciliUye.ID).Count > 0)
                {
                    _iletisimService.IletisimUyeUpdate(iletisimBilgisi);
                }

                _uyeService.UyeUpdate(seciliUye);
                MessageBox.Show("Uye Bilgisi Guncellendi.");
                UyeGridDoldur();
                KontrolleriSil();
            }
            else
                MessageBox.Show("Bir Uye Secmelisiniz!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (seciliUye != null)
            {
                int etkilenen = _uyeService.UyeSil(seciliUye);
                if (etkilenen > 0)
                {
                    UyeGridDoldur();
                    MessageBox.Show("Uye Basariyla Kaldirildi.");
                    KontrolleriSil();
                }
                else
                    MessageBox.Show("Bir Hata Olustu");
            }
            else
                MessageBox.Show("Bir Uye Secmelisiniz!");

        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            YeniUyeEkle yeniUyeEkleform = new YeniUyeEkle(this);
            yeniUyeEkleform.Show();
               
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
