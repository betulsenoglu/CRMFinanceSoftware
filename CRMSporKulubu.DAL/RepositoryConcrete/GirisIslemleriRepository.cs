using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.DAL.RepositoryAbstract;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryConcrete
{
	public class GirisIslemleriRepository : IGirisIslemleriRepository
	{
		public int AddItem(GirisIslemleri item)
		{
			using (CRMContext _db =new CRMContext())
			{
				try
				{
					var entry = _db.Entry(item);
					if (entry.State == EntityState.Detached)
					{ _db.GirisIslemleri.Attach(item); }
					_db.GirisIslemleri.Add(item);
					int _etkilenenSatir = _db.SaveChanges();
					return _etkilenenSatir;
				}
				catch (Exception e)
				{

					System.Windows.Forms.MessageBox.Show("Hata : " + e.Message);
					return 0;
				}
			}
		}

		public int DeleteItem(GirisIslemleri item)
		{
			using (CRMContext _db = new CRMContext())
			{
				try
				{
					var entry = _db.Entry(item);
					if (entry.State == EntityState.Detached)
					{ _db.GirisIslemleri.Attach(item); }
					_db.GirisIslemleri.Remove(item);
					int _etkilenenSatir = _db.SaveChanges();
					return _etkilenenSatir;		  
				}
				catch (Exception e)
				{

					System.Windows.Forms.MessageBox.Show("Hata : " + e.Message);
					return 0;
				}

			}
		}

		public ICollection<GirisIslemleri> GetAllById(int? id = null)
		{
			throw new NotImplementedException();
		}

		public GirisIslemleri GetById(int id)
		{
			using (CRMContext _db = new CRMContext())
			{
				return _db.GirisIslemleri.Where(x => x.CalisanID == id && x.AktifMi == true).FirstOrDefault();
			}
		}

		public int KullaniciSifreDegistir(int id, string sifre)
		{
			using (CRMContext _db = new CRMContext())
			{
				GirisIslemleri girisIslemleri = _db.GirisIslemleri.Where(x => x.CalisanID == id).FirstOrDefault();
				GirisIslemleri yeniGiris = new GirisIslemleri();

				yeniGiris.AktifMi = true;
				yeniGiris.Sifre = sifre;
				yeniGiris.OlusturulmaTarihi = DateTime.Now;
				yeniGiris.KullaniciMi = true;
				yeniGiris.KullaniciAdi = girisIslemleri.KullaniciAdi;
				yeniGiris.GizliSoruID = girisIslemleri.GizliSoruID;
				yeniGiris.GizliSoruCevap = girisIslemleri.GizliSoruCevap;
				yeniGiris.CalisanID = girisIslemleri.CalisanID;
				_db.GirisIslemleri.Add(yeniGiris);
				return _db.SaveChanges();
			}
		}

		public int UpdateItem(GirisIslemleri item)
		{
			using (CRMContext _db = new CRMContext())
			{
				GirisIslemleri girisIslemleri = _db.GirisIslemleri.Where(x => x.ID == item.ID).FirstOrDefault();
				girisIslemleri.AktifMi = false;
				return _db.SaveChanges();
			}
		}
		public bool LoginKontrol(string kullaniciAdi, string sifre)
		{
			using (CRMContext _db = new CRMContext())
			{
				GirisIslemleri girisIslemleri = _db.GirisIslemleri.Where(x => x.KullaniciAdi == kullaniciAdi
				  && x.AktifMi == true
				  && x.Sifre == sifre
				  && x.KullaniciMi == true).FirstOrDefault();
				if (girisIslemleri != null)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		public Calisan girisYapanKullaniciGetir(string kullaniciAdi, string sifre)
		{
			using (CRMContext _db = new CRMContext())
			{
				GirisIslemleri g = _db.GirisIslemleri.Where(x => x.KullaniciAdi == kullaniciAdi
									 && x.AktifMi == true
									 && x.Sifre == sifre).FirstOrDefault();

				return g.Calisan;
			}
		}
		//public bool GizliSoruCevapKontrol(int id)
		//{
		//	using (CRMContext _db = new CRMContext())
		//	{
		//		  GirisIslemleri girisIslemleriKontrol = _db.Calisan.Where(x=>x.ID==id).Where(x=>x.GirisIslemleri.FirstOrDefault().GizliSoruCevap==)
		//	}
		//}



	}
}
