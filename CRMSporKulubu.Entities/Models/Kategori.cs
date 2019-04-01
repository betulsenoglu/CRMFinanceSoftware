using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class Kategori : BaseEntity
	{
		public Kategori()
		{
			KategoriUrunleri = new List<Urun>();
		}
		public string KategoriAdi { get; set; }
		public virtual ICollection<Urun> KategoriUrunleri { get; set; }
	}
}
