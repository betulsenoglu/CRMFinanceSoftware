using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryAbstract
{
	interface ICalisanRepository : IBaseRepository<Calisan>
	{
		bool LoginKontrol(string kullaniciAdi, string sifre);
		ICollection<Calisan> ArananCalisan(string isim);
		ICollection<MaasRaporDTO> MaasRapor(DateTime dateTime);
		ICollection<CalisanInfoDTO> CalisanAllContactInfoIsmeGore(string isim);
		ICollection<CalisanInfoDTO> CalisanAllContactInfo();
		ICollection<CalisanIletisimleriDTO> CalisanIletisimBilgileriniGetir(int id);
		int getByTC(string tc);
		int emaileGoreGetir(string email);


	}
}
