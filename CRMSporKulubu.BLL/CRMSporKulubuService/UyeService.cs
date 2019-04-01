using CRMSporKulubu.DAL.RepositoryConcrete;
using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSporKulubu.BLL.CRMSporKulubuService
{
	public class UyeService
	{
		UyeRepository _uyeRepository;
		public UyeService()
		{
			_uyeRepository = new UyeRepository();
		}

		public int AddUyeService(Uye uye)
		{
			try
			{
				return _uyeRepository.AddItem(uye);
			}
			catch (Exception e)
			{
				MessageBox.Show("Hata : " + e.Message);
				return 0;
			}
		}
        public List<Uye> TumUyeleriGetir()
		{
			return _uyeRepository.GetAllById().ToList();
		}	 
		public Uye UyeGetirById(int ID)
		{
			return _uyeRepository.GetById(ID);
		}

		public int UyeUpdate(Uye uye)
		{
			return _uyeRepository.UpdateItem(uye);
		}

		public int UyeSil(Uye uye)
		{
			return _uyeRepository.DeleteItem(uye);
		}
		public ICollection<AidatRaporDTO> AidatRaporla(DateTime dateTime)
		{
			return _uyeRepository.AidatRapor(dateTime).ToList();
		}
        public List<UyeInfoDTO> UyeAllContactInfo()	  //Uye sayfasindaki DTOyu dolduruyor
        {
            return _uyeRepository.UyeAllContactInfo().ToList();
        }
        public List<UyeInfoDTO> UyeAllContactInfoIsmeGore(string isim)	 //Arama txtsine gore DTOya uye getirir
        {
            return _uyeRepository.UyeAllContactInfoIsmeGore(isim).ToList();
        }
        public Uye getByTC(string tc)	   //DTO dan cekerken cift tikladigimda tc yakaliyorum ona gore txtleri dolduruyorum.
        {
            return _uyeRepository.getByTC(tc);
        }
        public List<UyeIletisimleriDTO> uyeIletisimBilgileriniGetir(int id)	//uye iletisimini guncellerken seciliUyeIletisimini bununla yakaliyorum
        {
            return _uyeRepository.uyeIletisimBilgileriniGetir(id).ToList();
        }
        public List<UyeDonemDagilimiDTO> UyeDonemDagilimiGetir()	
        {
            return _uyeRepository.uyeDonemDagilimi().ToList();
        }

    }
}
