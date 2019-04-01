using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class GizliSoru : BaseEntity
	{
		public GizliSoru()
		{
			GirisIslemleri = new List<GirisIslemleri>();
		}
		public string Soru { get; set; }
		public virtual ICollection<GirisIslemleri> GirisIslemleri { get; set; }

	}
}
