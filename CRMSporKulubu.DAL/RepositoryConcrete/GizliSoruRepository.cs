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
	public class GizliSoruRepository : IGizliSoruRepository
	{
		public int AddItem(GizliSoru item)
		{
			throw new NotImplementedException();
		}

		public int DeleteItem(GizliSoru item)
		{
			throw new NotImplementedException();
		}

		public ICollection<GizliSoru> GetAllById(int? id = null)
		{
			using (CRMContext _db = new CRMContext())
			{
				return _db.GizliSoru.ToList();
			}
		}

		public GizliSoru GetById(int id)
		{
			using (CRMContext _db=new CRMContext())
			{
			    return	_db.GizliSoru.Where(x => x.ID == id).FirstOrDefault();
			}
		}

		public int UpdateItem(GizliSoru item)
		{
			throw new NotImplementedException();
		}
	}
}
