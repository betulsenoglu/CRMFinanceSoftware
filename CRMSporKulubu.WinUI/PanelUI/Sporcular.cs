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
	public partial class Sporcular : Form
	{
        Sporcu seciliSporcu;
        List<SporcuInfoDTO> seciliSporcuIletisimleri;
        SporcuService _sporcuService;
        IletisimService _iletisimService;
        TakimService _takimService;
        public void SporcuGridDoldur()
        {
            List<SporcuInfoDTO> sporcuListesi = _sporcuService.SporcuAllContactInfo();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sporcuListesi;
            cmbTakimlar.DataSource = _takimService.TumTakimlariGetir();
            cmbTakimlar.DisplayMember = "TakimAdi";
            cmbTakimlar.ValueMember = "ID";
        }
        public Sporcular()
		{
			InitializeComponent();
            _sporcuService = new SporcuService();
            _takimService = new TakimService();
            _iletisimService = new IletisimService();
        }

		private void btnUyeEkle_Click(object sender, EventArgs e)
		{
			YeniSporcuEkle YeniSporcuEkle = new YeniSporcuEkle(this);
			YeniSporcuEkle.Show();
		}

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Sporcular_Load(object sender, EventArgs e)
        {
            SporcuGridDoldur();
        }

        private void dgvSporcular_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int seciliSporcuID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
            seciliSporcu = _sporcuService.SporcuGetirByID(seciliSporcuID);
            seciliSporcuIletisimleri = _sporcuService.sporcuIletisimBilgileriniGetir(seciliSporcuID);
            txtTCNo.Text = seciliSporcu.TCKimlikNo;
            txtAd.Text = seciliSporcu.Ad;
            txtSoyad.Text = seciliSporcu.Soyad;
            dtpDogumTarihi.Value = seciliSporcu.DogumTarihi;
            if (seciliSporcu.Cinsiyet == 0)
                rdbErkek.Checked = true;
            else
                rdbKadin.Checked = true;
            if (seciliSporcuIletisimleri.Count != 0)
            {
                txtEmail.Text = seciliSporcuIletisimleri.FirstOrDefault().Email;
                txtTel.Text = seciliSporcuIletisimleri.FirstOrDefault().Telefon;
                txtAdres.Text = seciliSporcuIletisimleri.FirstOrDefault().Adres;
            }
            else
            {
                txtEmail.Text = "";
                txtTel.Text = "";
                txtAdres.Text = "";
            }
            dtpKayitTarihi.Value = seciliSporcu.OlusturulmaTarihi.Value;
            nmrAidatBilgisi.Value = seciliSporcu.Maas;
            cmbTakimlar.SelectedValue = _takimService.SporcuTakimiGetir(seciliSporcuID).FirstOrDefault();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Takim yeniTakim = new Takim();
            yeniTakim.ID = cmbTakimlar.SelectedIndex + 1;

            if (seciliSporcu != null)
            {
                seciliSporcu.TCKimlikNo = txtTCNo.Text;
                seciliSporcu.Ad = txtAd.Text;
                seciliSporcu.Soyad = txtSoyad.Text;
                seciliSporcu.DogumTarihi = dtpDogumTarihi.Value;
                seciliSporcu.Cinsiyet = rdbErkek.Checked == true ? Cinsiyet.Erkek : Cinsiyet.Kadin;
                seciliSporcu.OlusturulmaTarihi = dtpKayitTarihi.Value;
                seciliSporcu.Maas = nmrAidatBilgisi.Value;

                // _takimService.SporcuTakiminiGuncelle(seciliSporcu.ID, Convert.ToInt32(cmbTakimlar.SelectedValue));
                _takimService.SporcuTakiminiGuncelle(seciliSporcu, yeniTakim.ID);

                Iletisim iletisimBilgisi = new Iletisim();
                iletisimBilgisi.SporcuID = seciliSporcu.ID;
                iletisimBilgisi.Telefon = txtTel.Text;
                iletisimBilgisi.EMail = txtEmail.Text;
                iletisimBilgisi.Adres = txtAdres.Text;
                iletisimBilgisi.AktifMi = true;
                iletisimBilgisi.OlusturulmaTarihi = DateTime.Now;
                if (_sporcuService.sporcuIletisimBilgileriniGetir(seciliSporcu.ID).Count == 0)
                {
                    _iletisimService.AddIletisimService(iletisimBilgisi);
                }
                else if (_sporcuService.sporcuIletisimBilgileriniGetir(seciliSporcu.ID).Count > 0)
                {
                    _iletisimService.IletisimUyeUpdate(iletisimBilgisi);
                }

                _sporcuService.SporcuUpdate(seciliSporcu);
                MessageBox.Show("Sporcu Bilgisi Güncellendi!");
                SporcuGridDoldur();
                Helper.Temizle(this);
                
            }
            else
                MessageBox.Show("Bir Sporcu Seçmelisiniz!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (seciliSporcu != null)
            {
                int etkilenen = _sporcuService.SporcuSil(seciliSporcu);
                if (etkilenen > 0)
                {
                    SporcuGridDoldur();
                    MessageBox.Show("Sporcu Basariyla Kaldirildi.");
                    Helper.Temizle(this);
                }
                else
                    MessageBox.Show("Bir Hata Olustu");
            }
            else
                MessageBox.Show("Bir Sporcu Secmelisiniz!");
        }

        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _sporcuService.SporcuGridAramayaGoreDoldur(txtUyeAra.Text);
        }

		private void txtUyeAra_Click(object sender, EventArgs e)
		{
			txtUyeAra.Text = "";
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.ClearSelection();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
