using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class GirisIslemleri : BaseEntity
	{
		public int CalisanID { get; set; }
		public int GizliSoruID { get; set; }
		public string GizliSoruCevap { get; set; }
		public string KullaniciAdi { get; set; }
		public string Sifre { get; set; }
		public bool KullaniciMi { get; set; }

		public virtual Calisan Calisan { get; set; }
		public virtual GizliSoru GizliSoru { get; set; }
	}
}
