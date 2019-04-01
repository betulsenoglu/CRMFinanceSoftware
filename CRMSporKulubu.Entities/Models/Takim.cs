using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class Takim : BaseEntity
	{
		public Takim()
		{
            TakimSporculari = new List<Sporcu>();
        }
		public string TakimAdi { get; set; }
		public string Tur { get; set; }
        public virtual ICollection<Sporcu> TakimSporculari { get; set; }
    }
}
