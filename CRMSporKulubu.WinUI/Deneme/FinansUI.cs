using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.Entities.Models;

namespace CRMSporKulubu.WinUI.Deneme
{
    public partial class FinansUI : Form
    {
        FinansTakip _finansTakip;
        FinansTakipService _finansTakipService;
        GelirGiderKategoriService _gelirGiderKategoriService;
        CalisanService _calisanService;
        SporcuService _sporcuService;
        UyeService _uyeService;
        UrunService _urunService;
        public FinansUI()
        {
            InitializeComponent();
            _gelirGiderKategoriService = new GelirGiderKategoriService();
            _calisanService = new CalisanService();
            _sporcuService = new SporcuService();
            _uyeService = new UyeService();
            _finansTakip = new FinansTakip();
            _urunService = new UrunService();
            _finansTakipService = new FinansTakipService();
        }


        //private void dgvFinans_MouseDoubleClickk(object sender, MouseEventArgs e)
        //{
        //    int finansTakipID = Convert.ToInt32(dgvFinans.SelectedRows[0].Cells["ID"].Value);
        //    _finansTakip = _finansTakipService.FinansTakipGetirById(finansTakipID);

        //    txtTutar.Text = _finansTakip.Fiyat.ToString();
        //    txtNot.Text = _finansTakip.Not;
        //    dtpOdemeTarihi.Value = _finansTakip.OdemeTarihi.Value;


        //    if (!_finansTakip.GelirMiGiderMi)
        //    {
        //        cmbGelirGiderTip.SelectedIndex = 1;
        //        cmbKategori.DataSource = _gelirGiderKategoriService.TumKategorileriGetir();
        //        cmbKategori.DisplayMember = "GelirGiderKategoriAdi";
        //        cmbKategori.ValueMember = "ID";
        //        cmbKategori.SelectedValue = _finansTakip.GelirGiderKategoriID;
        //        if (cmbKategori.SelectedText == "Aidat")
        //        {
        //            cmbUye.DataSource = _uyeService.TumUyeleriGetir();
        //            cmbUye.DisplayMember = "Ad";
        //            cmbUye.ValueMember = "ID";
        //            cmbUye.SelectedValue = _finansTakip.UyeID;


        //        }
        //    }
        //    else
        //    {
        //        cmbGelirGiderTip.SelectedIndex = 0;
        //        cmbKategori.DataSource = _gelirGiderKategoriService.TumKategorileriGetir();
        //        cmbKategori.DisplayMember = "GelirGiderKategoriAdi";
        //        cmbKategori.ValueMember = "ID";
        //        cmbKategori.SelectedValue = _finansTakip.GelirGiderKategoriID;
        //        if (cmbKategori.SelectedText == "Maaş" && _finansTakip.CalisanID != null)
        //        {
        //            cmbCalisan.DataSource = _calisanService.TumCalisanlariGetir();
        //            cmbCalisan.DisplayMember = "Ad";
        //            cmbCalisan.ValueMember = "ID";

        //        }
        //        else if (cmbKategori.SelectedText == "Maaş" && _finansTakip.SporcuID != null)
        //        {
        //            cmbSporcu.DataSource = _sporcuService.TumSporculariGetir();
        //            cmbSporcu.DisplayMember = "Ad";
        //            cmbSporcu.ValueMember = "ID";
        //        }

        //    }

        //}


        private void btnFinansGuncelle_Click(object sender, EventArgs e)
        {
            int finansTakipID = Convert.ToInt32(dgvFinans.SelectedRows[0].Cells["ID"].Value);
            _finansTakip = _finansTakipService.FinansTakipGetirById(finansTakipID);
            if (_finansTakip != null)
            {
                _finansTakip.GelirMiGiderMi = (bool)cmbGelirGiderTip.SelectedItem;


            }

        }



        public void FinansTakipDoldur()
        {

            dgvFinans.DataSource = _finansTakipService.finansTakipListesiRaporu();
            cmbGelirGiderTip.Items.Add("Gelir");
            cmbGelirGiderTip.Items.Add("Gider");
            cmbGelirGiderTip.SelectedIndex = 0;

            cmbKategori.SelectedValue = -1;

        }
        private void FinansUI_Load(object sender, EventArgs e)
        {
           FinansTakipDoldur();
            nmrUrunAdet.Maximum = 10000;
           
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
            }
        }

        private void btnFinansSil_Click_1(object sender, EventArgs e)
        {
            int finansTakipID = Convert.ToInt32(dgvFinans.SelectedRows[0].Cells["ID"].Value);
            _finansTakip = _finansTakipService.FinansTakipGetirById(finansTakipID);


            int etkilenen = _finansTakipService.FinansTakipSil(_finansTakip);
            if (etkilenen > 0)
            {
                MessageBox.Show("Urun Silindi");
                dgvFinans.DataSource = _finansTakipService.TumFinansTakipTablosunuGetir();
            }
            FinansTakipDoldur();
            KontrolleriSil();
        }
        private void btnFinansGuncelle_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dgvFinans_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

            int finansTakipID = Convert.ToInt32(dgvFinans.SelectedRows[0].Cells["ID"].Value);
            _finansTakip = _finansTakipService.FinansTakipGetirById(finansTakipID);

            if (_finansTakip.Not==null)
            {
                txtNot.Text = "Not Bulunmuyor.. ";
            }
            else
            {
            txtNot.Text = _finansTakip.Not.ToString();
                    
            }
            txtTutar.Text = _finansTakip.Fiyat.ToString();

           
            if (!_finansTakip.GelirMiGiderMi)
            {
                cmbGelirGiderTip.SelectedIndex = 1;
                cmbKategori.DataSource = _gelirGiderKategoriService.TumKategorileriGetir();
                cmbKategori.DisplayMember = "GelirGiderKategoriAdi";
                cmbKategori.ValueMember = "ID";
                cmbKategori.SelectedValue = _finansTakip.GelirGiderKategoriID;

                //cmbUyeAdi.SelectedIndex = -1;
                //cmbSporcu.SelectedIndex = -1;
                //cmbKategori.SelectedIndex = -1;
                //cmbCalisan.SelectedIndex = -1;


                if (_finansTakip.CalisanID >= 1)
                {
                    cmbCalisanAdi.DataSource = _calisanService.TumCalisanlariGetir();
                    cmbCalisanAdi.DisplayMember = "Ad";
                    cmbCalisanAdi.ValueMember = "ID";
                    cmbCalisanAdi.SelectedValue = _finansTakip.CalisanID;

                   

                    cmbUyeAdi.SelectedIndex = -1;
                    cmbSporcu.SelectedIndex = -1;
                    cmbUrunAdi.SelectedIndex = -1;
                    nmrUrunAdet.Value = 0;
                    //cmbKategori.SelectedIndex = -1;
                    

                }
                if (_finansTakip.SporcuID >= 1)
                {
                    cmbSporcu.DataSource = _sporcuService.TumSporculariGetir();
                    cmbSporcu.DisplayMember = "Ad";
                    cmbSporcu.ValueMember = "ID";
                    cmbSporcu.SelectedValue = _finansTakip.SporcuID;

                    //cmbCalisan.Enabled = false;
                    nmrUrunAdet.Value = 0;
                    cmbUyeAdi.SelectedIndex = -1;            
                    cmbCalisanAdi.SelectedIndex = -1;
                    cmbUrunAdi.SelectedIndex = -1;


                }
                if (_finansTakip.UyeID >= 1)
                {

                    cmbUyeAdi.DataSource = _uyeService.TumUyeleriGetir();
                    cmbUyeAdi.DisplayMember = "Ad";
                    cmbUyeAdi.ValueMember = "ID";
                    cmbUyeAdi.SelectedValue = _finansTakip.UyeID;

                    cmbSporcu.SelectedIndex = -1;
                    //cmbKategori.SelectedIndex = -1;
                    cmbCalisanAdi.SelectedIndex = -1;
                    cmbUrunAdi.SelectedIndex = -1;
                }
                if (_finansTakip.UrunID>=1)
                {

                    cmbUrunAdi.DataSource = _urunService.TumurunleriGetir();
                    cmbUrunAdi.DisplayMember = "UrunAd";
                    cmbUrunAdi.ValueMember = "ID";
                    cmbUrunAdi.SelectedValue = _finansTakip.UrunID;
                    nmrUrunAdet.Value = _finansTakip.UrunAdet.Value;
                    cmbSporcu.SelectedIndex = -1;
                    cmbUyeAdi.SelectedIndex = -1;
                    cmbCalisanAdi.SelectedIndex = -1;
                }
                

            }
            else
            {
                cmbGelirGiderTip.SelectedIndex = 0;
                cmbKategori.DataSource = _gelirGiderKategoriService.TumKategorileriGetir();
                cmbKategori.DisplayMember = "GelirGiderKategoriAdi";
                cmbKategori.ValueMember = "ID";
                cmbKategori.SelectedValue = _finansTakip.GelirGiderKategoriID;

                if (cmbKategori.SelectedText == "Maaş" && _finansTakip.CalisanID != null)
                {
                    cmbUyeAdi.DisplayMember = "Ad";
                    cmbUyeAdi.ValueMember = "ID";
                    cmbUyeAdi.DataSource = _uyeService.TumUyeleriGetir();
                    

                }
                else if (cmbKategori.SelectedText == "Maaş" && _finansTakip.SporcuID != null)
                {
                   
                    cmbSporcu.DisplayMember = "Ad";
                    cmbSporcu.ValueMember = "ID";
                    cmbSporcu.DataSource = _sporcuService.TumSporculariGetir();
                }
                if (Convert.ToInt32( cmbKategori.SelectedValue) ==_finansTakip.GelirGiderKategoriID &&_finansTakip.UrunID!=null)
                {
                    cmbUrunAdi.DataSource = _urunService.TumurunleriGetir();
                    cmbUrunAdi.DisplayMember = "UrunAd";
                    cmbUrunAdi.ValueMember = "ID";
                    cmbUrunAdi.SelectedValue = _finansTakip.UrunID;
                    nmrUrunAdet.Value = _finansTakip.UrunAdet.Value;

                }
               

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FinansUIEkle finansEkle = new FinansUIEkle(this);
            finansEkle.Show();

        }


        private void btnGelirGiderEkle_Click(object sender, EventArgs e)
        {
            //FinansEkle urunEkle = new FinansEkle(this);
            //urunEkle.Show();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           dgvFinans.DataSource= _finansTakipService.OdemeTarihineGoreGetir(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void btnFinansGuncelle_Click_2(object sender, EventArgs e)
        {
            int finansTakipID = Convert.ToInt32(dgvFinans.SelectedRows[0].Cells["ID"].Value);
            _finansTakip = _finansTakipService.FinansTakipGetirById(finansTakipID);


            if (_finansTakip != null && (int)cmbKategori.SelectedValue > 0)
            {
                if (_finansTakip.CalisanID > 0)
                {
                    _finansTakip.Not = txtNot.Text;
                    _finansTakip.Fiyat = Convert.ToDecimal(txtTutar.Text);
                    _finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
                    _finansTakip.CalisanID = (int)cmbCalisanAdi.SelectedValue;
                    _finansTakip.SonOdemeTarihi = dtpSonOdemeTarihi.Value;
                    _finansTakip.CalisanID = (int)cmbCalisanAdi.SelectedValue;
                    _finansTakip.UyeID = null;
                    _finansTakip.SporcuID = null;
                    _finansTakip.GuncellenmeTarihi = DateTime.Now;
                    _finansTakip.AktifMi = true;
                    _finansTakip.GuncellenmeTarihi = DateTime.Now;
                    _finansTakip.AktifMi = true;

                    int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Finans Takip Güncellendi..");
                    }
                }
                if (_finansTakip.SporcuID > 0)
                {
                    _finansTakip.Not = txtNot.Text;
                    _finansTakip.Fiyat = Convert.ToDecimal(txtTutar.Text);
                    _finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
                    _finansTakip.SporcuID = (int)cmbSporcu.SelectedValue;
                    _finansTakip.SonOdemeTarihi = dtpSonOdemeTarihi.Value;
                    _finansTakip.GuncellenmeTarihi = DateTime.Now;
                    _finansTakip.AktifMi = true;


                    int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Finans Takip Güncellendi..");
                    }
                }
                if (_finansTakip.UyeID > 0)
                {
                    _finansTakip.Not = txtNot.Text;
                    _finansTakip.Fiyat = Convert.ToDecimal(txtTutar.Text);
                    _finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
                    _finansTakip.UyeID = (int)cmbUyeAdi.SelectedValue;
                    _finansTakip.SonOdemeTarihi = dtpSonOdemeTarihi.Value;
                    _finansTakip.GuncellenmeTarihi = DateTime.Now;
                    _finansTakip.AktifMi = true;


                    int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Finans Takip Güncellendi..");
                    }
                }
                if (_finansTakip.UrunID > 0)
                {

                    _finansTakip.UrunAdet = (int)nmrUrunAdet.Value;
                    _finansTakip.Not = txtNot.Text;
                    _finansTakip.Fiyat = Convert.ToDecimal(txtTutar.Text);
                    _finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
                    _finansTakip.UrunID = (int)cmbUrunAdi.SelectedValue;
                    _finansTakip.SonOdemeTarihi = dtpSonOdemeTarihi.Value;
                    _finansTakip.GuncellenmeTarihi = DateTime.Now;
                    _finansTakip.AktifMi = true;

                    int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
                    if (etkilenen > 0)
                    {
                        MessageBox.Show("Finans Takip Güncellendi..");
                    }

                }

                for (int i = 0; i < dgvFinans.RowCount; i++)
                {
                    int finansTakipID1 = Convert.ToInt32(dgvFinans.Rows[i].Cells["ID"].Value);
                    FinansTakip _finansTakip1 = _finansTakipService.FinansTakipGetirById(finansTakipID1);
                    if (Convert.ToBoolean(dgvFinans.Rows[i].Cells["OdemeDurumu"].Value))
                    {
                        if (_finansTakip1.OdemeDurumu != true)
                        {
                            _finansTakip1.OdemeDurumu = true;
                            _finansTakip1.OdemeTarihi = DateTime.Now;
                            _finansTakipService.FinansTakipUpdate(_finansTakip1);
                        }
                    }
                    else
                    {
                        if (_finansTakip1.OdemeDurumu == true)
                        {
                            _finansTakip1.OdemeDurumu = false;
                            _finansTakip1.OdemeTarihi = null;
                            _finansTakipService.FinansTakipUpdate(_finansTakip1);
                        }
                    }
                }

            }
            //_finansTakip.Not = txtNot.Text;
            //_finansTakip.Fiyat =Convert.ToDecimal( txtTutar.Text);
            //_finansTakip.GelirGiderKategoriID = (int)cmbKategori.SelectedValue;
            //_finansTakip.CalisanID = (int)cmbCalisan.SelectedValue;
            //_finansTakip.SporcuID = (int)cmbSporcu.SelectedValue;
            //_finansTakip.UyeID = (int)cmbUyeAdi.SelectedValue;
            //_finansTakip.OdemeTarihi = dtpOdemeTarihi.Value;

            //int etkilenen = _finansTakipService.FinansTakipUpdate(_finansTakip);
            //if (etkilenen>0)
            //{
            //    MessageBox.Show("Finans Takip Güncellendi..");
            //}
            FinansTakipDoldur();
            KontrolleriSil();
        }
    }
}
