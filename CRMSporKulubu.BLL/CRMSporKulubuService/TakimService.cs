using CRMSporKulubu.DAL.RepositoryConcrete;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.BLL.CRMSporKulubuService
{
	public class TakimService
	{
		TakimRepository _takimRespository;
		public TakimService()
		{
			_takimRespository = new TakimRepository();
		}
		public List<Takim> TumTakimlariGetir()
		{
			return _takimRespository.GetAllById().ToList();
		}
        public List<int> SporcuTakimiGetir(int id)
        {
            return _takimRespository.SporcuTakimiGetir(id).ToList();
        }
        public void SporcuTakiminiGuncelle(Sporcu sporcu,int takimid)
        {
            _takimRespository.SporcuTakiminiGuncelle( sporcu,  takimid);
        }

    }
}
