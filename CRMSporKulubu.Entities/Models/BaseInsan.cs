using CRMSporKulubu.Entities.Models.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Models
{
	public class BaseInsan : BaseEntity
	{
		public string TCKimlikNo { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public Cinsiyet Cinsiyet { get; set; }
		public DateTime DogumTarihi { get; set; }
	}
}
