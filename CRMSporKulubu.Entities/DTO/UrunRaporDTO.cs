using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.DTO
{
	public class UrunRaporDTO
	{
		public int UrunID { get; set; }
		public string Ad { get; set; }
		public string Kategori { get; set; }
		public int Stok { get; set; }
		public int? SatısAdet { get; set; }
		public decimal? ToplamKazanc { get; set; }
		public bool OdemeDurumu { get; set; }
		public decimal BirimSatisFiyat { get; set; }
		public decimal BirimMaliyetFiyat { get; set; }
		public DateTime? OdemeTarihi { get; set; }
		public DateTime? SonOdemeTarihi  { get; set; }
	}
}
