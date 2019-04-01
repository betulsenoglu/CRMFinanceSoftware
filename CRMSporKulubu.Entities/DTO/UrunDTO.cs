using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.DTO
{
    public class UrunDTO
    {
        public int ID { get; set; }
        public string Kategori { get; set; }
        public string  UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public decimal SatisFiyati { get; set; }
        public decimal Maaliyet { get; set; }
        public int StokBilgisi { get; set; }
        public DateTime? OlusturmaTarihi { get; set; }
        public DateTime? GuncelleTarihi { get; set; }
        //public bool AktifMi { get; set; }



    }
}
