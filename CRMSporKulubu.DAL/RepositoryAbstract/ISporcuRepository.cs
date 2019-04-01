using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryAbstract
{
	interface ISporcuRepository : IBaseRepository<Sporcu>
	{
		ICollection<Sporcu> ArananSporcu(string isim);
        ICollection<SporcuInfoDTO> sporcuIletisimBilgileriniGetir(int id);
        ICollection<Takim> SporcuTakimlari(Sporcu sporcu);
        Sporcu GetByID(int id);
        ICollection<SporcuInfoDTO> SporcuAllContactInfoIsmeGore(string isim);
		ICollection<MaasRaporDTO> MaasRapor(DateTime dateTime);

	}
}
