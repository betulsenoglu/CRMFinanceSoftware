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
	public partial class Uyeler : Form
	{
        UyeService _uyeService;
        IletisimService _iletisimService;
        Uye seciliUye;
        List<UyeIletisimleriDTO> seciliUyeIletisimleri;
        public Uyeler()
		{
            InitializeComponent();
            _uyeService = new UyeService();
            _iletisimService = new IletisimService();
        }
        public void UyeGridDoldur()
        {
            List<UyeInfoDTO> uyeListesi = _uyeService.UyeAllContactInfo();
            dataGridView1.DataSource = null;
			dataGridView1.DataSource = uyeListesi;

        }
        public void UyeGridAramayaGoreDoldur()
        {
			dataGridView1.DataSource = null;
            List<UyeInfoDTO> uyeList = _uyeService.UyeAllContactInfoIsmeGore(txtUyeAra.Text);
			dataGridView1.DataSource = uyeList;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		private void btnUyeEkle_Click(object sender, EventArgs e)
		{
			YeniUyeEkle YeniUyeEkle = new YeniUyeEkle(this);
			YeniUyeEkle.Show();
		}
		private void Uyeler_Load(object sender, EventArgs e)
		{
            UyeGridDoldur();
        }
		private void pictureBox1_Click(object sender, EventArgs e)
		{

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
                    _iletisimService.AddIletisimService(iletisimBilgisi);
                }
                else if (_uyeService.uyeIletisimBilgileriniGetir(seciliUye.ID).Count > 0)
                {
                    _iletisimService.IletisimUyeUpdate(iletisimBilgisi);
                }

                _uyeService.UyeUpdate(seciliUye);
                MessageBox.Show("Üye Bilgisi Güncellendi.");
                UyeGridDoldur();
                Helper.Temizle(this);
            }
            else
                MessageBox.Show("Bir Üye Seçmelisiniz!");
        }

        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            UyeGridAramayaGoreDoldur();
        }

        private void dgvUyeler_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string seciliUyeTC = dataGridView1.SelectedRows[0].Cells["TCKimlikNo"].Value.ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (seciliUye != null)
            {
                int etkilenen = _uyeService.UyeSil(seciliUye);
                if (etkilenen > 0)
                {
                    UyeGridDoldur();
                    MessageBox.Show("Üye Başarıyla Kaldırıldı.");
                    Helper.Temizle(this);
                }
                else
                    MessageBox.Show("Bir Hata Oluştu");
            }
            else
                MessageBox.Show("Bir Üye Seçmelisiniz!");
        }

		private void txtUyeAra_Click(object sender, EventArgs e)
		{
			txtUyeAra.Text = "";
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.ClearSelection();
		}

		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string seciliUyeTC = dataGridView1.SelectedRows[0].Cells["TCKimlikNo"].Value.ToString();
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

		private void txtUyeAra_TextChanged_1(object sender, EventArgs e)
		{
			UyeGridAramayaGoreDoldur();
		}
	}
}
