using CRMSporKulubu.BLL.CRMSporKulubuService;
using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.Entities.DTO;
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

namespace CRMSporKulubu.WinUI.PanelUI
{
	public partial class Urunler : Form
	{
		UrunService _urunService;
		KategoriService _kategoriService;
		//CRMContext db = new CRMContext();
		Urun _secilenUrun;
		public Urunler()
		{
			_urunService = new UrunService();
			_kategoriService = new KategoriService();
			InitializeComponent();
			_secilenUrun = new Urun();
		}

		private void btnUrunEkle_Click(object sender, EventArgs e)
		{
			YeniUrunEkle YeniUrunEkle = new YeniUrunEkle(this);
			YeniUrunEkle.Show();
		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			dataGridView1.ClearSelection();
		}

		private void Urunler_Load(object sender, EventArgs e)
		{
			UrunDoldur();
			KategoriDoldur();
		}
		public void UrunDoldur()
		{
			dataGridView1.DataSource = null;
			List<UrunDTO> urunListesi = _urunService.UrunBilgileriRaporu();
			dataGridView1.DataSource = urunListesi;
		}
		public void KategoriDoldur()
		{
			cmbUrunKategori.DataSource = _kategoriService.TumKategorileriGetir();
			//cmbUrunKategori.DataSource = db.Kategori.ToList();
			cmbUrunKategori.DisplayMember = "KategoriAdi";
			cmbUrunKategori.ValueMember = "ID";
			cmbUrunKategori.SelectedIndex = -1;
		}

		private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int seciliUrunID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

			_secilenUrun = _urunService.UrunGetirById(seciliUrunID);

			txtUrunAdi.Text = _secilenUrun.UrunAd;
			txtAciklama.Text = _secilenUrun.Aciklama;
			txtMaaliyeti.Text = _secilenUrun.Maaliyet.ToString();
			txtSatisFiyati.Text = _secilenUrun.SatisFiyati.ToString();
			txtStokBilgisi.Text = _secilenUrun.StokBilgisi.ToString();
			cmbUrunKategori.SelectedValue = _secilenUrun.KategoriID;
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			int seciliUrunID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

			_secilenUrun = _urunService.UrunGetirById(seciliUrunID);


			int etkilenen = _urunService.UrunSil(_secilenUrun);
			if (etkilenen > 0)
			{
				MessageBox.Show("Urun Silindi");
				UrunDoldur();
				KontrolleriSil();
			}
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			int seciliUrunID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

			_secilenUrun = _urunService.UrunGetirById(seciliUrunID);

			_secilenUrun.UrunAd = txtUrunAdi.Text;
			_secilenUrun.KategoriID = (int)cmbUrunKategori.SelectedValue;
			_secilenUrun.SatisFiyati = Convert.ToDecimal(txtSatisFiyati.Text);
			_secilenUrun.Maaliyet = Convert.ToDecimal(txtMaaliyeti.Text);
			_secilenUrun.StokBilgisi = Convert.ToInt32(txtStokBilgisi.Text);
			_secilenUrun.Aciklama = txtAciklama.Text;

			int etkilenen = _urunService.UrunUpdate(_secilenUrun);

			if (etkilenen > 0)
			{
				MessageBox.Show("Ürün Güncellendi");
			}
			UrunDoldur();
			KontrolleriSil();
		}

		private void txtUrunAra_TextChanged(object sender, EventArgs e)
		{
			dataGridView1.DataSource = null;
			List<UrunDTO> urunuListedeAra = _urunService.ArananUrunService(txtUrunAra.Text);
			dataGridView1.DataSource = urunuListedeAra;
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
