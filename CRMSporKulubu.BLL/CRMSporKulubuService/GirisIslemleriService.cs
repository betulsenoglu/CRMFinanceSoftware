using CRMSporKulubu.DAL.RepositoryConcrete;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSporKulubu.BLL.CRMSporKulubuService
{
	public class GirisIslemleriService
	{
		GirisIslemleriRepository _girisIslemleriRepository;
		public GirisIslemleriService()
		{
			_girisIslemleriRepository = new GirisIslemleriRepository();
		}
		public int KullaniciSifreDegistir(int id, string sifre)
		{
			return _girisIslemleriRepository.KullaniciSifreDegistir(id, sifre);
		}
		public int GirisGuncelle(GirisIslemleri girisIslemleri)
		{
			return _girisIslemleriRepository.UpdateItem(girisIslemleri);
		}
		public GirisIslemleri GirisBilgileriGetir(int id)
		{
			return _girisIslemleriRepository.GetById(id);
		}
		public bool KullaniciLoginKontrol(string kullaniciAdi, string sifre)
		{
			try
			{
				return  _girisIslemleriRepository.LoginKontrol(kullaniciAdi, sifre);
			}
			catch (Exception e)
			{

				MessageBox.Show("Hata : Kullanici Bulunamadi.");
				return false;
			}
		}
        public Calisan girisYapanKullaniciGetir(string kullaniciAdi, string sifre)
        {
            try
            {
                 return _girisIslemleriRepository.girisYapanKullaniciGetir(kullaniciAdi,sifre);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata.");
                return null;
            }

        }
		public int HesabıSil(GirisIslemleri girisIslemleri)
		{
			return _girisIslemleriRepository.DeleteItem(girisIslemleri);
		}
		public int GirisBilgisiEkle(GirisIslemleri girisIslemleri)
		{
			return _girisIslemleriRepository.AddItem(girisIslemleri);
		}
    }
}
