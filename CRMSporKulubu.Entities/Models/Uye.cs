using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class Uye : BaseInsan
	{
		public Uye()
		{
			UyeIletisimleri = new List<Iletisim>();
			UyeFinansTakipleri = new List<FinansTakip>();
		}
		public decimal Aidat { get; set; }
		public virtual ICollection<Iletisim> UyeIletisimleri { get; set; }
		public virtual ICollection<FinansTakip> UyeFinansTakipleri { get; set; }

	}
}
