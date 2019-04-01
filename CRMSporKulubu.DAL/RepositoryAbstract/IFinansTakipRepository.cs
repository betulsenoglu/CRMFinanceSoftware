using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSporKulubu.Entities.DTO;

namespace CRMSporKulubu.DAL.RepositoryAbstract
{
    interface IFinansTakipRepository : IBaseRepository<FinansTakip>
    {
        FinansTakip ArananFinansTakipUye(DateTime dateTime, int id);
        ICollection<Uye> FinansTakipOlmayanUyeler(DateTime dateTime);
        ICollection<Calisan> FinansTakipOlmayanCalisanlar(DateTime dateTime);
        FinansTakip ArananFinansTakipCalisan(DateTime dateTime, int id);
        ICollection<FinansTakip> UrunSatislariGetir();
        ICollection<UrunRaporDTO> UrunSatisRaporla(DateTime dateTime);
        FinansTakip ArananFinansTakipUrun(DateTime dateTime, int id);
        ICollection<GelirGiderAylıkDTO> AylikRapor(DateTime dateTime, bool kontrol);
        ICollection<GelirGiderAylıkDTO> GecikenOdemeleriGetir(DateTime dateTime, bool kontrol);
        ICollection<Sporcu> FinansTakipOlmayanSporcular(DateTime dateTime);
        FinansTakip ArananFinansTakipSporcu(DateTime dateTime, int id);
        ICollection<FinansTakipDTO> TariheGoreGetir(DateTime dateTime1, DateTime dateTime2);
        ICollection<AylikGelirGiderDTO> TumGecikenOdemeleriGetir();
        ICollection<AylikGelirGiderDTO> KategoriBilgileriniGetir(string ad);
        double GelirYuzdeligiGetir();
        double GiderYuzdeligiGetir();
        double AidatGelirYuzdeligiGetir();
        double UrunSatisiGelirYuzdeligiGetir();
        double DigerGelirGelirYuzdeligiGetir();
        double KiralamaGelirYuzdeligiGetir();
        ICollection<FinansTakipDTO> FinansBilgileriniGetir(string ad);
		//  ICollection<AyaGoreGelirGiderYuzdelikleriDTO> GelirGiderYuzdelikleriGetir();
		ICollection<GelirYillikChartDTO> GelirYillikGrafikGetir(DateTime dateTime);
		ICollection<GiderYillikChartDTO> GiderYillikGrafikGetir(DateTime dateTime);
        ICollection<BulundugumAyinGelirGiderMiktarlariDTO> BulundugumAyinGelirGiderMiktarlari();


    }
}
