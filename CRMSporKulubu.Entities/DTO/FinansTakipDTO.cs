using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.DTO
{
    public class FinansTakipDTO
    {
        public int ID { get; set; }
        public string GelirGiderAdi { get; set; }
        public string UyeAdi { get; set; }
        public string CalisanAdi { get; set; }
        public string SporcuAdi { get; set; }
        public string UrunAdi { get; set; }
        public string Not { get; set; }
        public decimal? UrunFiyat { get; set; }
        public int? UrunAdet { get; set; }
        public DateTime? OdemeTarihi { get; set; }
        public DateTime? SonOdemeTarihi { get; set; }
        public bool OdemeDurumu { get; set; }

        //public bool?  AktifMi { get; set; }
    }
}
