using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSporKulubu.DAL.RepositoryConcrete;
using CRMSporKulubu.Entities.Models;

namespace CRMSporKulubu.BLL.CRMSporKulubuService
{
	public class GelirGiderKategoriService 
	{
		GelirGiderKategoriRepository _gelirGiderKategoriRepository;
		public GelirGiderKategoriService()
		{
			_gelirGiderKategoriRepository = new GelirGiderKategoriRepository();
		}
		public List<GelirGiderKategori> TumKategorileriGetir()
		{
			return _gelirGiderKategoriRepository.GetAllById().ToList();
		}
        public List<GelirGiderKategori> GelirKategorileriniGetir()
        {
            return _gelirGiderKategoriRepository.GelirKategorileriniGetir().ToList();
        }
        public List<GelirGiderKategori> GiderKategorileriniGetir()
        {
            return _gelirGiderKategoriRepository.GiderKategorileriniGetir().ToList();
        }

    }
}
