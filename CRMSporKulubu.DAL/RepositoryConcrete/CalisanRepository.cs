using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.DAL.RepositoryAbstract;
using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryConcrete
{
	public class CalisanRepository : ICalisanRepository
	{
		int _etkilenenSatir;
		public int AddItem(Calisan item)
		{
			using (CRMContext _db = new CRMContext())
			{

				_db.Calisan.Add(item);
				_etkilenenSatir = _db.SaveChanges();
				return _etkilenenSatir;

			}
		}
		public int DeleteItem(Calisan item)
		{
			using (CRMContext _db = new CRMContext())
			{
				var entry = _db.Entry(item);
				if (entry.State == EntityState.Detached)
				{ _db.Calisan.Attach(item); }
				_db.Calisan.Remove(item);
				_etkilenenSatir = _db.SaveChanges();
				return _etkilenenSatir;
			}
		}
		public ICollection<Calisan> GetAllById(int? id = null)
		{
			using (CRMContext _db = new CRMContext())
			{
				return _db.Calisan.ToList();
			}
		}
		public Calisan GetById(int id)
		{
			using (CRMContext _db = new CRMContext())
			{
				return _db.Calisan.Where(x => x.ID == id).FirstOrDefault();
			}
		}
		public bool LoginKontrol(string kullaniciAdi, string sifre)
		{
			using (CRMContext _db = new CRMContext())
			{
				Calisan calisan = _db.Calisan.Where(x => x.GirisIslemleri.FirstOrDefault().KullaniciAdi == kullaniciAdi
				  && x.GirisIslemleri.FirstOrDefault().AktifMi == true
				  && x.GirisIslemleri.FirstOrDefault().Sifre == sifre
				  && x.KullaniciMi == true).FirstOrDefault();
				if (calisan != null)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		public int UpdateItem(Calisan item)
		{
			using (CRMContext _db = new CRMContext())
			{
				Calisan eskiCalisan = _db.Calisan.Where(x => x.ID == item.ID).FirstOrDefault();
				eskiCalisan.Ad = item.Ad;
				eskiCalisan.Soyad = item.Soyad;
				eskiCalisan.TCKimlikNo = item.TCKimlikNo;
				eskiCalisan.Maas = item.Maas;
				eskiCalisan.Cinsiyet = item.Cinsiyet;
				eskiCalisan.DogumTarihi = item.DogumTarihi;
				eskiCalisan.KullaniciMi = item.KullaniciMi;
				eskiCalisan.GuncellenmeTarihi = DateTime.Now;
				_etkilenenSatir = _db.SaveChanges();
				return _etkilenenSatir;
			}
		}
		public ICollection<Calisan> ArananCalisan(string isim)
		{
			using (CRMContext _db = new CRMContext())
			{
				return isim == null ?
				_db.Calisan.ToList() :
				_db.Calisan.SqlQuery("select * from Ogrenci where Adi Like '%" + isim + "%'").ToList();
			}
		}
		public ICollection<MaasRaporDTO> MaasRapor(DateTime dateTime)
		{
			using (CRMContext _db = new CRMContext())
			{
				return (from calisan in _db.Calisan
						join finansTakip in _db.FinansTakip on calisan.ID equals finansTakip.CalisanID
						select new MaasRaporDTO
						{
							ID = calisan.ID,
							Ad = calisan.Ad,
							Soyad = calisan.Soyad,
							Maas = calisan.Maas,
							OdemeDurumu = finansTakip.OdemeDurumu,
							OdemeTarihi = finansTakip.OdemeTarihi,
							SonOdemeTarihi = finansTakip.SonOdemeTarihi.Value

						}).Where(x => x.SonOdemeTarihi.Month == dateTime.Month && x.SonOdemeTarihi.Year == dateTime.Year).ToList();
			}
		}

		public ICollection<CalisanInfoDTO> CalisanAllContactInfo()
		{
			using (CRMContext _db = new CRMContext())
			{
				return (from calisan in _db.Calisan
						where calisan.AktifMi == true
						select new CalisanInfoDTO
						{
							ID = calisan.ID,
							TCKimlikNo = calisan.TCKimlikNo,
							Ad = calisan.Ad,
							Soyad = calisan.Soyad,
							Cinsiyet = calisan.Cinsiyet,
							DogumTarihi = calisan.DogumTarihi,
							Telefon = calisan.CalisanIletisimleri.FirstOrDefault().Telefon,
							Email = calisan.CalisanIletisimleri.FirstOrDefault().EMail,
							Adres = calisan.CalisanIletisimleri.FirstOrDefault().Adres,
							MaasBilgisi = calisan.Maas,
							KayitTarihi = calisan.OlusturulmaTarihi.Value
						}).ToList();
			}
		}

		public ICollection<CalisanIletisimleriDTO> CalisanIletisimBilgileriniGetir(int id)
		{
			using (CRMContext _db = new CRMContext())
			{
				return _db.Iletisim.Where(x => x.CalisanID == id).Where(x => x.AktifMi == true).Select(x => new CalisanIletisimleriDTO
                {
					Email = x.EMail,
					Telefon = x.Telefon,
					Adres = x.Adres

				}).ToList();
			}
		}
		public int getByTC(string tc)
		{
			using (CRMContext _db=new CRMContext())
			{
				try
				{
					Calisan calisan= _db.Calisan.Where(x => x.TCKimlikNo == tc).FirstOrDefault();
					if (calisan==null)
					{
						return 0;
					}
					else
					{
						return calisan.ID;
					}
				}
				catch (Exception e)
				{

					System.Windows.Forms.MessageBox.Show("Hata: "+e.Message);
					return 0;
				}
				
			}
		}

		ICollection<CalisanIletisimleriDTO> ICalisanRepository.CalisanIletisimBilgileriniGetir(int id)
		{
			throw new NotImplementedException();
		}
		public ICollection<CalisanInfoDTO> CalisanAllContactInfoIsmeGore(string isim)
		{

			using (CRMContext _db = new CRMContext())
			{
				return (from calisan in _db.Calisan
							//   join uye in _db.Uye on iletisim.UyeID equals uye.ID
						where calisan.AktifMi == true
						select new CalisanInfoDTO
						{
							ID = calisan.ID,
							TCKimlikNo = calisan.TCKimlikNo,
							Ad = calisan.Ad,
							Soyad = calisan.Soyad,
							Cinsiyet = calisan.Cinsiyet,
							DogumTarihi = calisan.DogumTarihi,
							Telefon = calisan.CalisanIletisimleri.FirstOrDefault().Telefon,
							Email = calisan.CalisanIletisimleri.FirstOrDefault().EMail,
							Adres = calisan.CalisanIletisimleri.FirstOrDefault().Adres,
							MaasBilgisi = calisan.Maas,
							KayitTarihi = calisan.OlusturulmaTarihi.Value
							// AktifMi = iletisim.AktifMi.Value

						}).Where((x => x.Ad.Contains(isim) || x.Soyad.Contains(isim))).ToList();
			}
		}
		public int emaileGoreGetir(string email)
		{
			using (CRMContext _db = new CRMContext())
			{
				Iletisim ıletisim = _db.Iletisim.Where(x => x.EMail == email && x.CalisanID != null && x.AktifMi == true).FirstOrDefault();
				if (ıletisim == null)
				{
					GirisIslemleri girisIslemleri = _db.GirisIslemleri.Where(x => x.KullaniciAdi == email && x.AktifMi == true).FirstOrDefault();
					if (girisIslemleri == null)
					{	 
						return 0;
					}
					else
					{
						return girisIslemleri.CalisanID;
					}
				}
				else
				{
					return ıletisim.CalisanID.Value; 
				}
			}
		}
	}
}
