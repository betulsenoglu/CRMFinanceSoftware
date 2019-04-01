using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryAbstract
{
	interface ITakimRepository : IBaseRepository<Takim>
	{
        ICollection<int> SporcuTakimiGetir(int id);
         void SporcuTakiminiGuncelle(Sporcu sporcu,int takimid);
	}
}
