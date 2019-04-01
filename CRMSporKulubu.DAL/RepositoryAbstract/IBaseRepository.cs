using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryAbstract
{
	interface IBaseRepository<T> where T : class
	{
		int AddItem(T item);
		int UpdateItem(T item);
		int DeleteItem(T item);
		T GetById(int id);
		ICollection<T> GetAllById(int? id = null);
	}
}
