using CRMSporKulubu.DAL.RepositoryConcrete;
using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSporKulubu.BLL.CRMSporKulubuService
{
    public class FinansTakipService
    {
        FinansTakipRepository _finansTakipRepository;
        public FinansTakipService()
        {
            _finansTakipRepository = new FinansTakipRepository();
        }

        public int AddFinansTakipService(FinansTakip finansTakipItem)
        {
            try
            {
                return _finansTakipRepository.AddItem(finansTakipItem);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata Detayi : " + e.Message);
                return 0;
            }
        }

        public FinansTakip ArananFinansTakipUye(DateTime dateTime, int id)
        {
            return _finansTakipRepository.ArananFinansTakipUye(dateTime, id);
        }
        public FinansTakip ArananFinansTakipCalisan(DateTime dateTime, int id)
        {
            return _finansTakipRepository.ArananFinansTakipCalisan(dateTime, id);
        }

        public List<FinansTakip> TumFinansTakipTablosunuGetir()
        {
            return _finansTakipRepository.GetAllById().ToList();
        }

        public FinansTakip FinansTakipGetirById(int ID)
        {
            return _finansTakipRepository.GetById(ID);
        }

        public int FinansTakipUpdate(FinansTakip finansTakip)
        {
            return _finansTakipRepository.UpdateItem(finansTakip);
        }

        public int FinansTakipSil(FinansTakip finansTakip)
        {
            return _finansTakipRepository.DeleteItem(finansTakip);
        }
        public List<Uye> FinansTakipOlmayanUyeler(DateTime dateTime)
        {
            return _finansTakipRepository.FinansTakipOlmayanUyeler(dateTime).ToList();
        }
        public List<Calisan> FinansTakipOlmayanCalisanlar(DateTime dateTime)
        {
            return _finansTakipRepository.FinansTakipOlmayanCalisanlar(dateTime).ToList();
        }
        public List<FinansTakip> UrunSatislariniGetir()
        {
            return _finansTakipRepository.UrunSatislariGetir().ToList();
        }
        public List<UrunRaporDTO> UrunSatisRaporla(DateTime dateTime)
        {
            return _finansTakipRepository.UrunSatisRaporla(dateTime).ToList();
        }
        public FinansTakip ArananFinansTakipUrun(DateTime dateTime, int id)
        {
            return _finansTakipRepository.ArananFinansTakipUrun(dateTime, id);
        }
        public List<GelirGiderAylıkDTO> AylikRaporGetir(DateTime dateTime, bool kontrol)
        {
            return _finansTakipRepository.AylikRapor(dateTime, kontrol).ToList();
        }
        public List<GelirGiderAylıkDTO> GecikenOdemeleriGetir(DateTime dateTime, bool kontrol)
        {
            return _finansTakipRepository.GecikenOdemeleriGetir(dateTime, kontrol).ToList();
        }
        public List<Sporcu> FinansTakipOlmayanSporcular(DateTime dateTime)
        {
            return _finansTakipRepository.FinansTakipOlmayanSporcular(dateTime).ToList();
        }
        public FinansTakip ArananFinansTakipSporcu(DateTime dateTime, int id)
        {
            return _finansTakipRepository.ArananFinansTakipSporcu(dateTime, id);
        }
        public List<FinansTakipDTO> OdemeTarihineGoreGetir(DateTime dT1, DateTime dt2)
        {
            return _finansTakipRepository.TariheGoreGetir(dT1, dt2).ToList();
        }  
        public List<FinansTakipDTO> finansTakipListesiRaporu()
        {
            return _finansTakipRepository.FinansTakipListesiRaporu().ToList();
        }
		public List<AylikGelirGiderDTO> GecikenleriGetir()
		{
			return _finansTakipRepository.TumGecikenOdemeleriGetir().ToList();
		}
        public double GelirYuzdeligiGetir()
        {
            return _finansTakipRepository.GelirYuzdeligiGetir();
        }
        public double GiderYuzdeligiGetir()
        {
            return _finansTakipRepository.GiderYuzdeligiGetir();
        }
        public double AidatGelirYuzdeligiGetir()
        {
            return _finansTakipRepository.AidatGelirYuzdeligiGetir();
        }
        public double UrunGelirYuzdeligiGetir()
        {
            return _finansTakipRepository.UrunSatisiGelirYuzdeligiGetir();
        }
        public double KiralamaGelirYuzdeligiGetir()
        {
            return _finansTakipRepository.KiralamaGelirYuzdeligiGetir();
        }
        public double DigerGelirYuzdeligiGetir()
        {
            return _finansTakipRepository.DigerGelirGelirYuzdeligiGetir();
        }
        public List<AylikGelirGiderDTO> KategoriBilgileriniGetir(string ad)
        {
            return _finansTakipRepository.KategoriBilgileriniGetir(ad).ToList();
        }
        public List<FinansTakipDTO> FinansBilgileriniGetir(string ad)
        {
            return _finansTakipRepository.FinansBilgileriniGetir(ad).ToList();
        }
		public List<GelirYillikChartDTO> GelirYillikChart(DateTime dateTime)
		{
			return _finansTakipRepository.GelirYillikGrafikGetir(dateTime).ToList();
		}
		public List<GiderYillikChartDTO> GiderYillikChart(DateTime dateTime)
		{
			return _finansTakipRepository.GiderYillikGrafikGetir(dateTime).ToList();
		}

        public List<BulundugumAyinGelirGiderMiktarlariDTO> BulundugumAyinGelirGiderMiktarlari()
        {
            return _finansTakipRepository.BulundugumAyinGelirGiderMiktarlari().ToList();
        }

    }
}
