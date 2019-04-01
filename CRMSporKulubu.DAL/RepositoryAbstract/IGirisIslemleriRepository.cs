using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryAbstract
{
	interface IGirisIslemleriRepository : IBaseRepository<GirisIslemleri>
	{
		int KullaniciSifreDegistir(int id, string sifre);
		bool LoginKontrol(string kullaniciAdi, string sifre);
        Calisan girisYapanKullaniciGetir(string kullaniciAdi, string sifre);
		//bool GizliSoruCevapKontrol(int id);
	}
}
