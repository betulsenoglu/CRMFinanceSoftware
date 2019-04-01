using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.Entities.Models;
using CRMSporKulubu.Entities.Models.EnumTypes;
using CRMSporKulubu.WinUI.PanelUI;
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
    public partial class YeniSporcuEkle : Form
    {
        private readonly Sporcular sporcular;
        SporcuService _sporcuService;
        IletisimService _sporcuIletisimService;
        TakimService _takimService;

        public YeniSporcuEkle(Sporcular sporcularform)
        {
            sporcular = sporcularform;
            InitializeComponent();
            _sporcuService = new SporcuService();
            _sporcuIletisimService = new IletisimService();
            _takimService = new TakimService();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Iletisim yeniSporcuIletisimBilgileri = new Iletisim();

                Sporcu yeniSporcu = new Sporcu();

                yeniSporcu.TCKimlikNo = txtTCNo.Text;
                yeniSporcu.Ad = txtAd.Text;
                yeniSporcu.Soyad = txtSoyad.Text;
                yeniSporcu.DogumTarihi = dtpDogumTarihi.Value;
                yeniSporcu.Cinsiyet = rdbErkek.Checked == true ? Cinsiyet.Erkek : Cinsiyet.Kadin;
                yeniSporcu.OlusturulmaTarihi = DateTime.Now;
                yeniSporcu.Maas = nmrMaasBilgisi.Value;
                yeniSporcu.AktifMi = true;
                yeniSporcu.TakimID = cmbTakimlar.SelectedIndex+1;
                _sporcuService.AddSporcuService(yeniSporcu);

                yeniSporcuIletisimBilgileri.SporcuID = yeniSporcu.ID;
                yeniSporcuIletisimBilgileri.Adres = txtAdres.Text;
                yeniSporcuIletisimBilgileri.Telefon = txtTel.Text;
                yeniSporcuIletisimBilgileri.EMail = txtEmail.Text;
                yeniSporcuIletisimBilgileri.OlusturulmaTarihi = DateTime.Now;
                yeniSporcuIletisimBilgileri.AktifMi = true;

                _sporcuIletisimService.AddIletisimService(yeniSporcuIletisimBilgileri);
                MessageBox.Show("Eklendi");
                KontrolleriSil();

            }
            catch
            {
                MessageBox.Show("Bir Hata Olustu!");
            }

            //sporcular.SporcuGridDoldur();

        }

        private void YeniSporcuEkle_Load(object sender, EventArgs e)
        {
           cmbTakimlar.DataSource= _takimService.TumTakimlariGetir();
            cmbTakimlar.DisplayMember = "TakimAdi";
            cmbTakimlar.ValueMember = "ID";
            cmbTakimlar.SelectedIndex = -1;
            
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
