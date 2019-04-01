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
	public class KategoriRepository : IKategoriRepository
	{
		public int AddItem(Kategori item)
		{
			throw new NotImplementedException();
		}

		public int DeleteItem(Kategori item)
		{
			throw new NotImplementedException();
		}

		public ICollection<Kategori> GetAllById(int? id = null)
		{
			using (CRMContext _db = new CRMContext())
			{
				return _db.Kategori.ToList();
			}
		}

		public Kategori GetById(int id)
		{
			throw new NotImplementedException();
		}

		public int UpdateItem(Kategori item)
		{
			throw new NotImplementedException();
		}
	}
}

