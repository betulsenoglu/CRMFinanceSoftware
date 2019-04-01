using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.DTO
{
	public class MaasRaporDTO
	{
		public int ID { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public decimal Maas { get; set; }
		public bool OdemeDurumu { get; set; }
		public DateTime? OdemeTarihi { get; set; }
		public DateTime SonOdemeTarihi { get; set; }
	}
}
