using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.DAL.RepositoryAbstract;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryConcrete
{
	public class TakimRepository : ITakimRepository
	{
		public int AddItem(Takim item)
		{
			throw new NotImplementedException();
		}

		public int DeleteItem(Takim item)
		{
			throw new NotImplementedException();
		}

		public ICollection<Takim> GetAllById(int? id = null)
		{
			using (CRMContext _db = new CRMContext())
			{
                return _db.Takim.ToList();
			}

		}
		public Takim GetById(int id)
		{
			throw new NotImplementedException();
		}

        public ICollection<Takim> SporcuTakimiGetir(string tc)
        {
            throw new NotImplementedException();
        }

        public ICollection<int> SporcuTakimiGetir(int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from sporcu in _db.Sporcu
                        join takim in _db.Takim on sporcu.TakimID equals takim.ID
                        where sporcu.ID==id
                        select takim.ID).ToList();


            }
            
        }

        public void SporcuTakiminiGuncelle(Sporcu sporcu, int takimid)
        {
            using (CRMContext _db = new CRMContext())
            {


                //Sporcu eskiSporcu = _db.Sporcu.Where(x => x.ID == sporcu.ID).FirstOrDefault();

                //var query = (from takim in _db.Takim
                // join sporcu1 in _db.Sporcu on takim.ID equals sporcu1.ID
                // where takim.TakimSporculari.Any(x => x.ID == sporcu.ID) == true
                // select takim.ID).ToList();
                //foreach (Takim item in query)
                //{
                //     item.= takimid;
                //}

                Sporcu eskiSporcu = _db.Sporcu.Where(x => x.ID == sporcu.ID).FirstOrDefault();
                eskiSporcu.AktifMi = true;
                eskiSporcu.TakimID = takimid;
                 _db.SaveChanges();
                //var query = from takim in _db.Takim
                //            join sporcu in _db.Sporcu on takim.ID equals sporcu.ID
                //            where takim.TakimSporculari.Any(x => x.ID == sporcuid) == true
                //            select sporcu.SporcuTakimlari.FirstOrDefault();
                //foreach (Takim stakim in query)
                //{
                //    stakim.ID = takimid;
                //}
                //return (from takim in _db.Takim
                //        join sporcu in _db.Sporcu on takim.ID equals sporcu.ID
                //        where takim.TakimSporculari.Any(x => x.ID == id) == true
                //        select takim.ID).ToList();

            }
        }

        public int UpdateItem(Takim item)
		{
			throw new NotImplementedException();
		}

        ICollection<Takim> IBaseRepository<Takim>.GetAllById(int? id)
        {
            throw new NotImplementedException();
        }
    }
}

