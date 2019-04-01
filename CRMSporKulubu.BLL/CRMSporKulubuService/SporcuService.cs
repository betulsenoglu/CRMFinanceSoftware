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
	public class SporcuService
	{
		SporcuRepository _sporcuRepository;
		public SporcuService()
		{
			_sporcuRepository = new SporcuRepository();
		}

		public int AddSporcuService(Sporcu sporcu)
		{
			try
			{
				return _sporcuRepository.AddItem(sporcu);
			}
			catch (Exception e)
			{
				MessageBox.Show("Hata Detayi : " + e.Message);
				return 0;
			}
		}

		public List<Sporcu> ArananSporcuService(string isim)
		{
			return _sporcuRepository.ArananSporcu(isim).ToList();
		}

		public List<Sporcu> TumSporculariGetir()
		{
			return _sporcuRepository.GetAllById().ToList();
		}

		public Sporcu SporcuGetirById(int ID)
		{
			return _sporcuRepository.GetById(ID);
		}
        public Sporcu SporcuGetirByID(int ID)
        {
            return _sporcuRepository.GetByID(ID);
        }

        public int SporcuUpdate(Sporcu sporcu)
		{
			return _sporcuRepository.UpdateItem(sporcu);
		}

		public int SporcuSil(Sporcu sporcu)
		{
			return _sporcuRepository.DeleteItem(sporcu);
		}
        public List<SporcuInfoDTO> SporcuAllContactInfo()	  //Sporcu sayfasindaki DTOyu dolduruyor
        {
            return _sporcuRepository.SporcuAllContactInfo().ToList();
        }
        public List<SporcuInfoDTO> SporcuGridAramayaGoreDoldur(string isim)	  //Sporcu sayfasindaki DTOyu dolduruyor isme gore
        {
            return _sporcuRepository.SporcuAllContactInfoIsmeGore(isim).ToList();
        }
        public List<SporcuInfoDTO> sporcuIletisimBilgileriniGetir(int id)	//sporcu iletisimini guncellerken seciliUyeIletisimini bununla yakaliyorum
        {
            return _sporcuRepository.sporcuIletisimBilgileriniGetir(id).ToList();
        }
		public ICollection<MaasRaporDTO> MaasRaporla(DateTime dateTime)
		{
			return _sporcuRepository.MaasRapor(dateTime).ToList();
		}

	}
}
