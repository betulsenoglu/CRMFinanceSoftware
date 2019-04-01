using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class BaseEntity
	{
		public int ID { get; set; }
		public DateTime? OlusturulmaTarihi { get; set; }
		public DateTime? GuncellenmeTarihi { get; set; }
		public bool? AktifMi { get; set; }
	}
}
