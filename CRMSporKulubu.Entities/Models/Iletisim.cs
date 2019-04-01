using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class Iletisim : BaseEntity
	{
		public int? CalisanID { get; set; }
		public int? UyeID { get; set; }
		public int? SporcuID { get; set; }
		public string Telefon { get; set; }
		public string EMail { get; set; }
		public string Adres { get; set; }

		
	}
}
