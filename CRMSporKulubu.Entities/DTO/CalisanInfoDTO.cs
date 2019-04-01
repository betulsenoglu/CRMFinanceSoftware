using CRMSporKulubu.Entities.Models.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.DTO
{
	public class CalisanInfoDTO
	{
        public int ID { get; set; }
        public string TCKimlikNo { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public Cinsiyet Cinsiyet { get; set; }
		public DateTime DogumTarihi { get; set; }
		public string Telefon { get; set; }
		public string Email { get; set; }
		public string Adres { get; set; }
		public decimal? MaasBilgisi { get; set; }
		public DateTime? KayitTarihi { get; set; }
	}
}
