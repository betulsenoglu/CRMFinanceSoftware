using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class Urun : BaseEntity
	{
		public Urun()
		{
			UrunFinansTakipleri = new List<FinansTakip>();
		}
		public int KategoriID { get; set; }
		public string UrunAd { get; set; }
		public decimal SatisFiyati { get; set; }
		public decimal Maaliyet { get; set; }
		public int StokBilgisi { get; set; }
		public string Aciklama { get; set; }
		public virtual Kategori Kategori { get; set; }
		public virtual ICollection<FinansTakip> UrunFinansTakipleri { get; set; }
	}
}
