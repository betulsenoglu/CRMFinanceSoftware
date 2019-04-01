using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class Calisan : BaseInsan
	{
		public Calisan()
		{
			GirisIslemleri = new List<GirisIslemleri>();
			CalisanIletisimleri = new List<Iletisim>();
			CalisanFinansTakipleri = new List<FinansTakip>();
		}
		public decimal Maas { get; set; }
		public bool KullaniciMi { get; set; }
		public virtual ICollection<GirisIslemleri> GirisIslemleri { get; set; }
		public virtual ICollection<Iletisim> CalisanIletisimleri { get; set; }
		public virtual ICollection<FinansTakip> CalisanFinansTakipleri { get; set; }

	}
}
