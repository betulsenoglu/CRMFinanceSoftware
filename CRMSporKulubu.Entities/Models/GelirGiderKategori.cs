using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class GelirGiderKategori : BaseEntity
	{
		public GelirGiderKategori()
		{
			GelirGiderKategoriFinansTakipleri = new List<FinansTakip>();
		}
		public string GelirGiderKategoriAdi { get; set; }
		public bool GelirMiGiderMi { get; set; }
		public virtual ICollection<FinansTakip> GelirGiderKategoriFinansTakipleri { get; set; }
	}
}
