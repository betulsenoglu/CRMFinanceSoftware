using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.DAL.CRMDbContext;
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
    public partial class UrunEkleUI : Form
    {
        UrunService _urunService;

        private readonly UrunUI Urun1;
        public UrunEkleUI(UrunUI UrunUI)
        {
            _urunService = new UrunService();
            InitializeComponent();
            Urun1=UrunUI;
        }

        CRMContext db = new CRMContext();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.UrunAd = txtUrunAdi.Text;
            urun.KategoriID = (int)cmbUrunKategori.SelectedValue;
            urun.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
            urun.Maaliyet = Convert.ToDecimal(txtMaaliyeti.Text);
            urun.StokBilgisi = Convert.ToInt32(txtStokBilgisi.Text);
            urun.Aciklama = txtAciklama.Text;
            urun.AktifMi = true;
            urun.OlusturulmaTarihi = DateTime.Now;

            int etkilenen = _urunService.AddUrunService(urun);
            if (etkilenen > 0)
            {
                MessageBox.Show("Ürün Kaydedildi..");

                Urun1.UrunDoldur();
                KontrolleriSil();
            }
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
        public void KategoriDoldur()
        {

            cmbUrunKategori.DataSource = db.Kategori.ToList();
            cmbUrunKategori.DisplayMember = "KategoriAdi";
            cmbUrunKategori.ValueMember = "ID";
            cmbUrunKategori.SelectedIndex = -1;
        }

        private void UrunEkleUI_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
        }
    }
}
