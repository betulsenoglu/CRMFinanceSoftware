using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.DAL.RepositoryAbstract;
using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryConcrete
{
	public class SporcuRepository : ISporcuRepository
	{
        CRMContext _db1 = new CRMContext();


        int _etkilenenSatir;
		public int AddItem(Sporcu item)
		{
			using (CRMContext _db = new CRMContext())
			{
				_db.Sporcu.Add(item);
				_etkilenenSatir = _db.SaveChanges();
				return _etkilenenSatir;
			}
		}

		public ICollection<Sporcu> ArananSporcu(string isim)
		{
			using (CRMContext _db = new CRMContext())
			{
				return isim == null ?
			 _db.Sporcu.ToList() :
			 _db.Sporcu.SqlQuery("select * from Sporcu where Adi Like '%" + isim + "%'").ToList();
			}
		}

		public int DeleteItem(Sporcu item)
		{
			using (CRMContext _db = new CRMContext())
			{
                var entry = _db.Entry(item);
                if (entry.State == EntityState.Detached)
                { _db.Sporcu.Attach(item); }
                _db.Sporcu.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
				return _etkilenenSatir;
			}
		}

		public ICollection<Sporcu> GetAllById(int? id = default(int?))
		{
			using (CRMContext _db = new CRMContext())
			{
				return _db.Sporcu.ToList();
			}
		}

		public Sporcu GetByID(int id)
		{
            using (CRMContext _db = new CRMContext())
            {
                return _db.Sporcu.Where(x => x.ID == id).FirstOrDefault();
            }
		}


        public int UpdateItem(Sporcu item)
		{
			
				Sporcu eskiSporcu = _db1.Sporcu.Where(x => x.ID == item.ID).FirstOrDefault();
				eskiSporcu.TCKimlikNo = item.TCKimlikNo;
				eskiSporcu.Maas = item.Maas;
				eskiSporcu.Ad = item.Ad;
				eskiSporcu.Soyad = item.Soyad;
				eskiSporcu.Cinsiyet = item.Cinsiyet;
				eskiSporcu.DogumTarihi = item.DogumTarihi;
            //	eskiSporcu.SporcuFinansTakipleri = item.SporcuFinansTakipleri;
            //	eskiSporcu.SporcuIletisimleri = item.SporcuIletisimleri;
            //	eskiSporcu.SporcuTakimlari = item.SporcuTakimlari;
            eskiSporcu.AktifMi = true;
				eskiSporcu.GuncellenmeTarihi = DateTime.Now;
				_etkilenenSatir = _db1.SaveChanges();
				return _etkilenenSatir;
			

		}
        public ICollection<SporcuInfoDTO> SporcuAllContactInfo()
        {
            using (CRMContext _db = new CRMContext())
            {
                // Bitmap img=new Bitmap(_db.Sporcu.Select(x=>x.PhotoPath).ToString());


                return (from sporcu in _db.Sporcu
                             join takim in _db.Takim on sporcu.TakimID equals takim.ID
                        where sporcu.AktifMi == true
                        select new SporcuInfoDTO
                        {
                           // PhotoPath = sporcu.PhotoPath,
                           ID=sporcu.ID,
                            TCKimlikNo = sporcu.TCKimlikNo,
                            Ad = sporcu.Ad,
                            Soyad = sporcu.Soyad,
                            Takimi = takim.TakimAdi,
                            Cinsiyet = sporcu.Cinsiyet,
                            DogumTarihi = sporcu.DogumTarihi,
                            Telefon = sporcu.SporcuIletisimleri.FirstOrDefault().Telefon,
                            Email = sporcu.SporcuIletisimleri.FirstOrDefault().EMail,
                            Adres = sporcu.SporcuIletisimleri.FirstOrDefault().Adres,
                            MaasBilgisi = sporcu.Maas,
                            KayitTarihi = sporcu.OlusturulmaTarihi.Value
                        }).ToList();
            }
        }

        public ICollection<SporcuInfoDTO> sporcuIletisimBilgileriniGetir(int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.Iletisim.Where(x => x.SporcuID == id).Where(x => x.AktifMi == true).Select(x => new SporcuInfoDTO
                {
                    Email = x.EMail,
                    Telefon = x.Telefon,
                    Adres = x.Adres

                }).ToList();
            }
        }

        public ICollection<Takim> SporcuTakimlari(Sporcu sporcu)
        {
            throw new NotImplementedException();
        }

        public Sporcu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<SporcuInfoDTO> SporcuAllContactInfoIsmeGore(string isim)
        {
           
            using (CRMContext _db = new CRMContext())
            {
                return (from sporcu in _db.Sporcu
                       join takim in _db.Takim on sporcu.TakimID equals takim.ID
                        where sporcu.AktifMi == true
                        select new SporcuInfoDTO
                        {
                            ID = sporcu.ID,
                            TCKimlikNo = sporcu.TCKimlikNo,
                            Ad = sporcu.Ad,
                            Soyad = sporcu.Soyad,
                            Takimi = takim.TakimAdi,
                            Cinsiyet = sporcu.Cinsiyet,
                            DogumTarihi = sporcu.DogumTarihi,
                            Telefon = sporcu.SporcuIletisimleri.FirstOrDefault().Telefon,
                            Email = sporcu.SporcuIletisimleri.FirstOrDefault().EMail,
                            Adres = sporcu.SporcuIletisimleri.FirstOrDefault().Adres,
                            MaasBilgisi = sporcu.Maas,
                            KayitTarihi = sporcu.OlusturulmaTarihi.Value
                        }).Where((x => x.Ad.Contains(isim) || x.Soyad.Contains(isim))).ToList();
            }
        }

		public ICollection<MaasRaporDTO> MaasRapor(DateTime dateTime)
		{
			using (CRMContext _db = new CRMContext())
			{
				return (from sporcu in _db.Sporcu
						join finansTakip in _db.FinansTakip on sporcu.ID equals finansTakip.SporcuID
						select new MaasRaporDTO
						{
							ID = sporcu.ID,
							Ad = sporcu.Ad,
							Soyad = sporcu.Soyad,
							Maas = sporcu.Maas,
							OdemeDurumu = finansTakip.OdemeDurumu,
							OdemeTarihi = finansTakip.OdemeTarihi,
							SonOdemeTarihi = finansTakip.SonOdemeTarihi.Value

						}).Where(x => x.SonOdemeTarihi.Month == dateTime.Month && x.SonOdemeTarihi.Year == dateTime.Year).ToList();

			}
		}
	}
}
