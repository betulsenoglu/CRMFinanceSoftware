using CRMSporKulubu.DAL.RepositoryConcrete;
using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSporKulubu.BLL.CRMSporKulubuService
{
	public class CalisanService
	{
		CalisanRepository _calisanRepository;
		public CalisanService()
		{
			_calisanRepository = new CalisanRepository();
		}

		public int AddCalisanService(Calisan calisan)
		{
			try
			{
				return _calisanRepository.AddItem(calisan);
			}
			catch (Exception e)
			{
				MessageBox.Show("Hata : " + e.Message);
				return 0;
			}
		}
		public List<CalisanInfoDTO> CalisanAllContactInfo()
		{
			return _calisanRepository.CalisanAllContactInfo().ToList();
		}
		public bool CalisanLoginKontrolService(string kullaniciAdi, string sifre)
		{
            try
            {
                return _calisanRepository.LoginKontrol(kullaniciAdi, sifre);
            }
            catch (Exception e)
            {

                MessageBox.Show("Hata : Kullanici Bulunamadi.");
                return false;
            }
		}
		public List<Calisan> ArananCalisanService(string isim)
		{
			return _calisanRepository.ArananCalisan(isim).ToList();
		}

		public List<Calisan> TumCalisanlariGetir()
		{
			return _calisanRepository.GetAllById().ToList();
		}

		public Calisan CalisanGetirById(int ID)
		{
			return _calisanRepository.GetById(ID);
		}
		public int CalisanUpdate(Calisan calisan)
		{
			return _calisanRepository.UpdateItem(calisan);
		}
		public int CalisanSil(Calisan calisan)
		{
			return _calisanRepository.DeleteItem(calisan);
		}
		public List<MaasRaporDTO> MaasRaporla(DateTime dateTime)
		{
			return _calisanRepository.MaasRapor(dateTime).ToList();
		}
        public List<CalisanIletisimleriDTO> CalisanIletisimBilgileriniGetir(int id)
        {
            return _calisanRepository.CalisanIletisimBilgileriniGetir(id).ToList();
        }
        public List<CalisanInfoDTO> CalisanAllContactInfoIsmeGore(string isim)
        {
            return _calisanRepository.CalisanAllContactInfoIsmeGore(isim).ToList();
        }
		public int emaileGoreGetir(string email)
		{
			return _calisanRepository.emaileGoreGetir(email);
		}
		public int TcIleAra(string tc)
		{
			return _calisanRepository.getByTC(tc);
		}
	}
}
