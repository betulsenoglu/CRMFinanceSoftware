using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryAbstract
{
	interface IUyeRepository : IBaseRepository<Uye>
	{
		ICollection<AidatRaporDTO> AidatRapor(DateTime dateTime);	
		
        ICollection<UyeInfoDTO> UyeAllContactInfo();
        ICollection<UyeInfoDTO> UyeAllContactInfoIsmeGore(string isim);
        Uye getByTC(string tc);
        ICollection<UyeIletisimleriDTO> uyeIletisimBilgileriniGetir(int id);
      //  ICollection<UyeDonemDagilimiDTO> uyeDonemDagilimi();
    }
}
