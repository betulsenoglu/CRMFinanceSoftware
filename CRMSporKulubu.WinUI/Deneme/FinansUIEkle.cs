using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.DAL.RepositoryConcrete;
using CRMSporKulubu.Entities.Models;
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
    public partial class FinansUIEkle : Form
    {
        FinansTakipService _finansTakipService;
        KategoriService _kategoriService;
        UyeService _uyeService;
        FinansTakip _finansTakip;
        Calisan calisanTakip;
        GelirGiderKategoriService _gelirGiderKategoriService;
        CalisanService _calisanService;
        SporcuService _sporcuService;
        UrunService _urunService;


        private readonly FinansUI finansUI1;

        public FinansUIEkle(FinansUI finansUI2)
        {
            finansUI1 = finansUI2;
            InitializeComponent();

            _finansTakipService = new FinansTakipService();
            _kategoriService = new KategoriService();
            _gelirGiderKategoriService = new GelirGiderKategoriService();
            _uyeService = new UyeService();
            _calisanService = new CalisanService();
            _sporcuService = new SporcuService();
            _urunService = new UrunService();
        }

        private void btnFinansEkleUI_Click(object sender, EventArgs e)
        {
            FinansTakip finansTakip = new FinansTakip();


            finansTakip.GelirGiderKategoriID = (int)cmbKategori1.SelectedValue;
           

            if (cmbCalisanAdi1.Enabled==true)
            {

            finansTakip.CalisanID = (int)cmbCalisanAdi1.SelectedValue;
            }
            if (cmbSporcu1.Enabled==true)
            {
            finansTakip.SporcuID = (int)cmbSporcu1.SelectedValue;

            }
            if (cmbUyeAdi1.Enabled==true)
            {

            finansTakip.UyeID = (int)cmbUyeAdi1.SelectedValue;
            }
            finansTakip.UrunAdet = Convert.ToInt32(nmrUrunAdet.Value);
            finansTakip.Not = txtNot.Text;
            finansTakip.Fiyat = Convert.ToInt32(txtTutar1.Text);
            finansTakip.SonOdemeTarihi = dtpOdemeTarihi1.Value;
            finansTakip.OdemeDurumu = false;
            finansTakip.OdemeTarihi = null;
            finansTakip.OlusturulmaTarihi = DateTime.Now;
            finansTakip.AktifMi = true;

            int etkilenen = _finansTakipService.AddFinansTakipService(finansTakip);
            if (etkilenen>0)
            {
                MessageBox.Show("Yeni Finans Eklendi...");
            }
            KontrolleriSil();
            finansUI1.FinansTakipDoldur();
        }

        public void KontrolleriSil()
        {
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cmb = item as ComboBox;
                    cmb.SelectedIndex =-1 ;
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
        public void GelirGiderDoldur()
        {
            _finansTakipService = new FinansTakipService();
            //cmbGelirGiderTip1.DataSource = _finansTakipService.TumFinansTakipTablosunuGetir();
            cmbGelirGiderTip1.Items.Add("Gelir");
            cmbGelirGiderTip1.Items.Add("Gider");

            //cmbKategori1.SelectedIndex = -1;

            //cmbKategori1.DataSource = _gelirGiderKategoriService.TumKategorileriGetir();
            //cmbKategori1.DisplayMember = "KategoriAdi";
            //cmbKategori1.ValueMember = "ID";
            ////cmbKategori1.DataSource = _finansTakip.GelirGiderKategoriID;



            cmbUyeAdi1.DataSource = _uyeService.TumUyeleriGetir();
            cmbUyeAdi1.DisplayMember = "Ad";
            cmbUyeAdi1.ValueMember = "ID";

            cmbSporcu1.SelectedIndex = -1;
            cmbCalisanAdi1.SelectedIndex = -1;



            cmbCalisanAdi1.DataSource = _calisanService.TumCalisanlariGetir();
            cmbCalisanAdi1.DisplayMember = "Ad";
            cmbCalisanAdi1.ValueMember = "ID";


            cmbSporcu1.DataSource = _sporcuService.TumSporculariGetir();
            cmbSporcu1.DisplayMember = "Ad";
            cmbSporcu1.ValueMember = "ID";

            cmbUrunAdi.DataSource = _urunService.TumurunleriGetir();
            cmbUrunAdi.DisplayMember = "UrunAd";
            cmbUrunAdi.ValueMember = "ID";

            nmrUrunAdet.Value = Convert.ToInt32(nmrUrunAdet.Value);

            cmbCalisanAdi1.Enabled = false;
            cmbSporcu1.Enabled = false;
            cmbUyeAdi1.Enabled = false;
            cmbUrunAdi.SelectedIndex = -1;


        }
        private void cmbGelirGiderTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGelirGiderTip1.SelectedItem == "Gider")
            {
                cmbKategori1.DataSource = _gelirGiderKategoriService.GiderKategorileriniGetir();
                cmbKategori1.DisplayMember = "GelirGiderKategoriAdi";
                cmbKategori1.ValueMember = "ID";


                cmbUyeAdi1.Enabled = false;
                cmbSporcu1.Enabled = true;

              
                cmbCalisanAdi1.Enabled = true;
                cmbCalisanAdi1.Enabled = true;
                   
               


            }
            else 
            {
                cmbKategori1.DataSource = _gelirGiderKategoriService.GelirKategorileriniGetir();
                cmbKategori1.DisplayMember = "GelirGiderKategoriAdi";
                cmbKategori1.ValueMember = "ID";

                cmbSporcu1.Enabled = false;
                cmbCalisanAdi1.Enabled = false;
                cmbUyeAdi1.Enabled = true;
                
               

            }
        }

        private void FinansUIEkle_Load(object sender, EventArgs e)
        {
            GelirGiderDoldur();
            
        }
       

        private void cmbKategori1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbGelirGiderTip1.SelectedItem == "Gider"&&cmbKategori1.SelectedIndex==1)
            {
                cmbUyeAdi1.Enabled = false;
                cmbSporcu1.Enabled = true;
                cmbCalisanAdi1.Enabled = true;
            }

            if (cmbGelirGiderTip1.SelectedItem == "Gelir" && cmbKategori1.SelectedIndex == 1)
            {
                cmbUyeAdi1.Enabled = true;
                cmbSporcu1.Enabled = false;
                cmbCalisanAdi1.Enabled = false;
                nmrUrunAdet.Enabled = false;

                
            }
            if (cmbGelirGiderTip1.SelectedItem == "Gider" && cmbKategori1.SelectedIndex != 1)
                {
                    cmbCalisanAdi1.Enabled = false;
                    cmbSporcu1.Enabled = false;
                    cmbUrunAdi.Enabled = false;
                }
            if (cmbGelirGiderTip1.SelectedItem == "Gelir" && cmbKategori1.SelectedIndex != 1)
            {
                cmbCalisanAdi1.Enabled = false;
                cmbSporcu1.Enabled = false;
                cmbUrunAdi.Enabled = false;
                cmbUyeAdi1.Enabled = false;
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbCalisanAdi1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCalisanAdi1.SelectedIndex>0)
            {
                cmbSporcu1.Enabled = false;
            }
            
        }

        private void cmbSporcu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSporcu1.SelectedIndex>0)
            {
                cmbCalisanAdi1.Enabled = false;
            }
        }
    }
}
