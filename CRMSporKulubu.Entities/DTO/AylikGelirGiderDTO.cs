using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.DTO
{
	public class AylikGelirGiderDTO
	{
		public int ID { get; set; }
		public string KategoriAdi { get; set; }
		public string UyeAdi { get; set; }
		public string CalisanAdi { get; set; }
		public string SporcuAdi { get; set; }
		public string UrunAdi { get; set; }
		public decimal Fiyat { get; set; } 		
		public DateTime? SonOdemeTarihi { get; set; }
	}
}
