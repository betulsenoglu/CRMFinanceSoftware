using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.DAL.RepositoryAbstract;
using CRMSporKulubu.Entities.Models;

namespace CRMSporKulubu.DAL.RepositoryConcrete
{
	public class GelirGiderKategoriRepository : IGelirGiderKategoriRepository
	{
		public int AddItem(GelirGiderKategori item)
		{
			throw new NotImplementedException();
		}

		public int DeleteItem(GelirGiderKategori item)
		{
			throw new NotImplementedException();
		}

        public ICollection<GelirGiderKategori> GelirKategorileriniGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.GelirGiderKategori.Where(x => x.GelirMiGiderMi == true).ToList();

            }
        }

        public ICollection<GelirGiderKategori> GetAllById(int? id = null)
		{
			using (CRMContext _db=new CRMContext())
			{
				return _db.GelirGiderKategori.ToList();

			}
		}

		public GelirGiderKategori GetById(int id)
		{
			throw new NotImplementedException();
		}

        public ICollection<GelirGiderKategori> GiderKategorileriniGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.GelirGiderKategori.Where(x => x.GelirMiGiderMi == false).ToList();

            }
        }

        public int UpdateItem(GelirGiderKategori item)
		{
			throw new NotImplementedException();
		}
	}
}
