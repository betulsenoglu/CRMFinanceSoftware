using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class FinansTakip : BaseEntity
	{
		public int GelirGiderKategoriID { get; set; }
		public int? UyeID { get; set; }
		public int? UrunID { get; set; }
		public int? CalisanID { get; set; }
		public int? SporcuID { get; set; }
		public bool GelirMiGiderMi { get; set; }
		public string Not { get; set; }
		public decimal Fiyat { get; set; }
		public int? UrunAdet { get; set; }
		public DateTime? OdemeTarihi { get; set; }
		public bool OdemeDurumu { get; set; }
		public DateTime? SonOdemeTarihi { get; set; }
		

	}
}
