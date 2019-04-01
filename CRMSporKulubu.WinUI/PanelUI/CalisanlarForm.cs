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

namespace CRMSporKulubu.WinUI.PanelUI
{
	public partial class CalisanlarForm : Form
	{
        CalisanService _calisanService;
        IletisimService _IletisimService;
        Calisan seciliCalisan;
        List<CalisanIletisimleriDTO> seciliCalisanIletisimleri;
		
        public CalisanlarForm()
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

        private void btnUyeEkle_Click(object sender, EventArgs e)
		{
			YeniCalisanEkle YeniCalisanEkle = new YeniCalisanEkle(this);
			YeniCalisanEkle.Show();
		}

		private void CalisanlarForm_Load(object sender, EventArgs e)
		{
            GridCalisanlarDoldur();

        }

        private void dgvCalisanlar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int seciliCalisanId = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells["ID"].Value);
            seciliCalisan = _calisanService.CalisanGetirById(seciliCalisanId);
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
         //   nmrMaasBilgisi.Value = seciliCalisan.Maas;
            if (seciliCalisan.KullaniciMi == true)
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
                MessageBox.Show("Çalışan Bilgisi Güncellendi.");
                GridCalisanlarDoldur();
                Helper.Temizle(this);
            }
            else
                MessageBox.Show("Bir Çalışan Seçmelisiniz!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (seciliCalisan != null)
            {
                int etkilenen = _calisanService.CalisanSil(seciliCalisan);
                if (etkilenen > 0)
                {
                    GridCalisanlarDoldur();
                    MessageBox.Show("Çalışan Başarıyla Kaldırıldı.");
                    Helper.Temizle(this);
                }
                else
                    MessageBox.Show("Bir Hata Oluştu");
            }
            else
                MessageBox.Show("Bir Çalışan Seçmelisiniz!");
        }

        private void txtCalisanAra_TextChanged(object sender, EventArgs e)
        {
            dgvCalisanlar.DataSource = _calisanService.CalisanAllContactInfoIsmeGore(txtCalisanAra.Text);
        }

        private void dgvCalisanlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void dgvCalisanlar_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dgvCalisanlar.ClearSelection();
		}

		private void txtCalisanAra_Click(object sender, EventArgs e)
		{
			txtCalisanAra.Text = "";
		}

        private void txtCalisanAra_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
