using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class Sporcu : BaseInsan
	{
		public Sporcu()
		{
			SporcuIletisimleri = new List<Iletisim>();

			SporcuFinansTakipleri = new List<FinansTakip>();
		}
        public int? TakimID { get; set; }
        public decimal Maas { get; set; }
        public string PhotoPath { get; set; }
        public virtual ICollection<Iletisim> SporcuIletisimleri { get; set; }

		public virtual ICollection<FinansTakip> SporcuFinansTakipleri { get; set; }
	}
}
