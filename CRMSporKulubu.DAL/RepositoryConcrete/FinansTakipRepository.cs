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
    public class FinansTakipRepository : IFinansTakipRepository
    {
        int _etkilenenSatir;
        int _kontrol = 0;
        List<FinansTakip> _liste;
        List<Uye> _listeUye;
        List<Calisan> _listeCalisan;
        List<Sporcu> _listeSporcu;
        public FinansTakipRepository()
        {
            _liste = new List<FinansTakip>();
            _listeUye = new List<Uye>();
            _listeCalisan = new List<Calisan>();
            _listeSporcu = new List<Sporcu>();
        }
        public int AddItem(FinansTakip item)
        {
            using (CRMContext _db = new CRMContext())
            {
                _db.FinansTakip.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public FinansTakip ArananFinansTakipCalisan(DateTime dateTime, int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.FinansTakip.Where(x => x.CalisanID == id && x.SonOdemeTarihi == dateTime).FirstOrDefault();
            }
        }

        public FinansTakip ArananFinansTakipUrun(DateTime dateTime, int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.FinansTakip.Where(x => x.UrunID == id && x.SonOdemeTarihi.Value == dateTime).FirstOrDefault();
            }
        }

        public FinansTakip ArananFinansTakipUye(DateTime dateTime, int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.FinansTakip.Where(x => x.UyeID == id && x.SonOdemeTarihi == dateTime).FirstOrDefault();
            }
        }

        public ICollection<GelirGiderAylıkDTO> AylikRapor(DateTime dateTime, bool kontrol)
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from finans in _db.FinansTakip
                        join urun in _db.Urun on finans.UrunID equals urun.ID into urunfinans
                        from Urun in urunfinans.DefaultIfEmpty()
                        join sporcu in _db.Sporcu on finans.SporcuID equals sporcu.ID into sporcufinans
                        from Sporcu in sporcufinans.DefaultIfEmpty()
                        join calisan in _db.Calisan on finans.CalisanID equals calisan.ID into calisanfinans
                        from Calisan in calisanfinans.DefaultIfEmpty()
                        join uye in _db.Uye on finans.UyeID equals uye.ID into uyefinans
                        from Uye in uyefinans.DefaultIfEmpty()
                        join kat in _db.GelirGiderKategori on finans.GelirGiderKategoriID equals kat.ID
                        where finans.GelirMiGiderMi == kontrol
                        select new GelirGiderAylıkDTO
                        {
                            ID = finans.ID,
                            KategoriAdi = kat.GelirGiderKategoriAdi,
                            UyeAdi = Uye.Ad,
                            CalisanAdi = Calisan.Ad,
                            SporcuAdi = Sporcu.Ad,
                            UrunAdi = Urun.UrunAd,
                            Fiyat = finans.Fiyat,
                            OdemeDurumu = finans.OdemeDurumu,
                            OdemeTarihi = finans.OdemeTarihi.Value,
                            SonOdemeTarihi = finans.SonOdemeTarihi.Value
                        }).Where(x => x.SonOdemeTarihi.Value.Month == dateTime.Month && x.SonOdemeTarihi.Value.Year == dateTime.Year).ToList();
            }
        }

        public int DeleteItem(FinansTakip item)
        {
            using (CRMContext _db = new CRMContext())
            {
                var entry = _db.Entry(item);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    _db.FinansTakip.Attach(item);
                }
                _db.FinansTakip.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;

            }


        }

        public ICollection<Calisan> FinansTakipOlmayanCalisanlar(DateTime dateTime)
        {
            using (CRMContext _db = new CRMContext())
            {
                _listeCalisan.Clear();
                foreach (Calisan item in _db.Calisan.ToList())
                {
                    _liste = _db.FinansTakip.Where(x => x.CalisanID == item.ID && x.SonOdemeTarihi.Value.Month == dateTime.Month && x.SonOdemeTarihi.Value.Year == dateTime.Year).ToList();
                    if (_liste.Count == 0)
                    {
                        if (_listeCalisan.Count > 0)
                        {
                            foreach (Calisan item2 in _listeCalisan)
                            {
                                if (item.ID == item2.ID)
                                {
                                    _kontrol++;
                                }
                            }
                            if (_kontrol == 0)
                            {
                                _listeCalisan.Add(item);
                            }
                        }
                        else if (_listeCalisan.Count == 0)
                        {
                            _listeCalisan.Add(item);
                        }
                    }
                }
                return _listeCalisan;
            }
        }

        public ICollection<Uye> FinansTakipOlmayanUyeler(DateTime dateTime)
        {
            using (CRMContext _db = new CRMContext())
            {
                _listeUye.Clear();
                foreach (Uye item in _db.Uye.ToList())
                {
                    _liste = _db.FinansTakip.Where(x => x.UyeID == item.ID && x.SonOdemeTarihi.Value.Month == dateTime.Month && x.SonOdemeTarihi.Value.Year == dateTime.Year).ToList();
                    if (_liste.Count == 0)
                    {
                        if (_listeUye.Count > 0)
                        {
                            foreach (Uye item2 in _listeUye)
                            {
                                if (item.ID == item2.ID)
                                {
                                    _kontrol++;
                                }
                            }
                            if (_kontrol == 0)
                            {
                                _listeUye.Add(item);
                            }
                        }
                        else if (_listeUye.Count == 0)
                        {
                            _listeUye.Add(item);
                        }
                    }
                }
                return _listeUye;
            }
        }

        public ICollection<GelirGiderAylıkDTO> GecikenOdemeleriGetir(DateTime dateTime, bool kontrol)
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from finans in _db.FinansTakip
                        join urun in _db.Urun on finans.UrunID equals urun.ID into urunfinans
                        from Urun in urunfinans.DefaultIfEmpty()
                        join sporcu in _db.Sporcu on finans.SporcuID equals sporcu.ID into sporcufinans
                        from Sporcu in sporcufinans.DefaultIfEmpty()
                        join calisan in _db.Calisan on finans.CalisanID equals calisan.ID into calisanfinans
                        from Calisan in calisanfinans.DefaultIfEmpty()
                        join uye in _db.Uye on finans.UyeID equals uye.ID into uyefinans
                        from Uye in uyefinans.DefaultIfEmpty()
                        join kat in _db.GelirGiderKategori on finans.GelirGiderKategoriID equals kat.ID
                        where finans.GelirMiGiderMi == kontrol && finans.OdemeDurumu == false
                        select new GelirGiderAylıkDTO
                        {
                            ID = finans.ID,
                            KategoriAdi = kat.GelirGiderKategoriAdi,
                            UyeAdi = Uye.Ad,
                            CalisanAdi = Calisan.Ad,
                            SporcuAdi = Sporcu.Ad,
                            UrunAdi = Urun.UrunAd,
                            Fiyat = finans.Fiyat,
                            OdemeDurumu = finans.OdemeDurumu,
                            OdemeTarihi = finans.OdemeTarihi.Value,
                            SonOdemeTarihi = finans.SonOdemeTarihi.Value
                        }).Where(x => x.SonOdemeTarihi.Value.Month == dateTime.Month && x.SonOdemeTarihi.Value.Year == dateTime.Year
                        && DbFunctions.DiffDays(x.SonOdemeTarihi, DateTime.Now) > 0).ToList();

            }
        }

        public ICollection<FinansTakip> GetAllById(int? id = null)
        {

            using (CRMContext _db = new CRMContext())
            {
                return _db.FinansTakip.ToList();
            }

        }

        public FinansTakip GetById(int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.FinansTakip.Where(x => x.ID == id).FirstOrDefault();
            }

        }

        public int UpdateItem(FinansTakip item)
        {
            using (CRMContext _db = new CRMContext())
            {
                FinansTakip eskiFinans = _db.FinansTakip.Where(x => x.ID == item.ID).FirstOrDefault();
                eskiFinans.ID = item.ID;
                eskiFinans.SporcuID = item.SporcuID;
                eskiFinans.CalisanID = item.CalisanID;
                eskiFinans.UrunAdet = item.UrunAdet;
                eskiFinans.GuncellenmeTarihi = DateTime.Now;
                eskiFinans.OdemeDurumu = item.OdemeDurumu;
                eskiFinans.Fiyat = item.Fiyat;
                eskiFinans.OdemeTarihi = item.OdemeTarihi;
                eskiFinans.SonOdemeTarihi = item.SonOdemeTarihi;
                eskiFinans.OlusturulmaTarihi = item.OlusturulmaTarihi;
                eskiFinans.UrunID = item.UrunID;
                eskiFinans.UyeID = item.UyeID;
                eskiFinans.Not = item.Not;

                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<FinansTakip> UrunSatislariGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.FinansTakip.Where(x => x.UrunID != null).ToList();
            }
        }

        public ICollection<UrunRaporDTO> UrunSatisRaporla(DateTime dateTime)
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from urun in _db.Urun
                        join finans in _db.FinansTakip on urun.ID equals finans.UrunID
                        join kategori in _db.Kategori on urun.KategoriID equals kategori.ID
                        select new UrunRaporDTO
                        {
                            UrunID = urun.ID,
                            Ad = urun.UrunAd,
                            Kategori = urun.Kategori.KategoriAdi,
                            Stok = urun.StokBilgisi,
                            SatısAdet = finans.UrunAdet,
                            ToplamKazanc = finans.Fiyat,
                            OdemeDurumu = finans.OdemeDurumu,
                            BirimSatisFiyat = urun.SatisFiyati,
                            BirimMaliyetFiyat = urun.Maaliyet,
                            OdemeTarihi = finans.OdemeTarihi,
                            SonOdemeTarihi = finans.SonOdemeTarihi.Value

                        }).Where(x => x.SonOdemeTarihi.Value.Month == dateTime.Month && x.SonOdemeTarihi.Value.Year == dateTime.Year).ToList();
            }
        }
        public ICollection<Sporcu> FinansTakipOlmayanSporcular(DateTime dateTime)
        {
            using (CRMContext _db = new CRMContext())
            {
                _listeSporcu.Clear();
                foreach (Sporcu item in _db.Sporcu.ToList())
                {
                    _liste = _db.FinansTakip.Where(x => x.SporcuID == item.ID && x.SonOdemeTarihi.Value.Month == dateTime.Month
                    && x.SonOdemeTarihi.Value.Year == dateTime.Year).ToList();
                    if (_liste.Count == 0)
                    {
                        if (_listeSporcu.Count > 0)
                        {
                            foreach (Sporcu item2 in _listeSporcu)
                            {
                                if (item.ID == item2.ID)
                                {
                                    _kontrol++;
                                }
                            }
                            if (_kontrol == 0)
                            {
                                _listeSporcu.Add(item);
                            }
                        }
                        else if (_listeSporcu.Count == 0)
                        {
                            _listeSporcu.Add(item);
                        }
                    }
                }
                return _listeSporcu;
            }
        }

        public FinansTakip ArananFinansTakipSporcu(DateTime dateTime, int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.FinansTakip.Where(x => x.SporcuID == id && x.SonOdemeTarihi == dateTime).FirstOrDefault();
            }
        }

		public ICollection<FinansTakipDTO> TariheGoreGetir(DateTime dateTime1, DateTime dateTime2)
		{
			using (CRMContext _db = new CRMContext())
			{
				return (from finans in _db.FinansTakip
						join urun in _db.Urun on finans.UrunID equals urun.ID into urunfinans
						from Urun in urunfinans.DefaultIfEmpty()
						join sporcu in _db.Sporcu on finans.SporcuID equals sporcu.ID into sporcufinans
						from Sporcu in sporcufinans.DefaultIfEmpty()
						join calisan in _db.Calisan on finans.CalisanID equals calisan.ID into calisanfinans
						from Calisan in calisanfinans.DefaultIfEmpty()
						join uye in _db.Uye on finans.UyeID equals uye.ID into uyefinans
						from Uye in uyefinans.DefaultIfEmpty()
						join kat in _db.GelirGiderKategori on finans.GelirGiderKategoriID equals kat.ID
						where finans.AktifMi == true 
						select new FinansTakipDTO
						{
							ID = finans.ID,
							UrunAdi = Urun.UrunAd,
							UyeAdi = Uye.Ad,
							CalisanAdi = Calisan.Ad,
							SporcuAdi = Sporcu.Ad,
							UrunFiyat = Urun.SatisFiyati,
							UrunAdet = Urun.StokBilgisi,
							Not = finans.Not,
							OdemeTarihi = finans.OdemeTarihi.Value,
							SonOdemeTarihi = finans.SonOdemeTarihi.Value,
							GelirGiderAdi = kat.GelirGiderKategoriAdi,
							OdemeDurumu = finans.OdemeDurumu


						}).Where(x=>dateTime1< x.SonOdemeTarihi.Value && dateTime2>x.SonOdemeTarihi.Value).ToList();
			}
		}

        public ICollection<FinansTakipDTO> FinansTakipListesiRaporu()
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from finans in _db.FinansTakip
                        join urun in _db.Urun on finans.UrunID equals urun.ID into urunfinans
                        from Urun in urunfinans.DefaultIfEmpty()
                        join sporcu in _db.Sporcu on finans.SporcuID equals sporcu.ID into sporcufinans
                        from Sporcu in sporcufinans.DefaultIfEmpty()
                        join calisan in _db.Calisan on finans.CalisanID equals calisan.ID into calisanfinans
                        from Calisan in calisanfinans.DefaultIfEmpty()
                        join uye in _db.Uye on finans.UyeID equals uye.ID into uyefinans
                        from Uye in uyefinans.DefaultIfEmpty()
                        join kat in _db.GelirGiderKategori on finans.GelirGiderKategoriID equals kat.ID
                        where finans.AktifMi == true
                        select new FinansTakipDTO
                        {
                            ID = finans.ID,
                            UrunAdi = Urun.UrunAd,
                            UyeAdi = Uye.Ad,
                            CalisanAdi = Calisan.Ad,
                            SporcuAdi = Sporcu.Ad,
                            UrunFiyat = Urun.SatisFiyati,
                            UrunAdet = Urun.StokBilgisi,
                            Not = finans.Not,
                            OdemeTarihi = finans.OdemeTarihi.Value,
                            SonOdemeTarihi = finans.SonOdemeTarihi.Value,
                            GelirGiderAdi = kat.GelirGiderKategoriAdi,
                            OdemeDurumu = finans.OdemeDurumu


                        }).ToList();
            }

            //return isim == null ?
            //    _db.Urun.ToList() :
            //    _db.Urun.SqlQuery("select * from Urun where UrunAd Like '%" + isim + "%'").ToList();
            //return (from urun in _db.Urun join finansTakip in _db.FinansTakip on urun.ID equals finansTakip.UrunID
            //       from sporcu in _db.Sporcu join finansTakip1 in _db.FinansTakip on sporcu.ID equals finansTakip1.SporcuID
            //       from calisan in _db.Calisan join finansTakip2 in _db.FinansTakip on calisan.ID equals finansTakip2.CalisanID
            //       from uye in _db.Uye join finansTakip3 in _db.FinansTakip on uye.ID equals finansTakip3.UyeID




        }

        public ICollection<AylikGelirGiderDTO> TumGecikenOdemeleriGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from finans in _db.FinansTakip
                        join urun in _db.Urun on finans.UrunID equals urun.ID into urunfinans
                        from Urun in urunfinans.DefaultIfEmpty()
                        join sporcu in _db.Sporcu on finans.SporcuID equals sporcu.ID into sporcufinans
                        from Sporcu in sporcufinans.DefaultIfEmpty()
                        join calisan in _db.Calisan on finans.CalisanID equals calisan.ID into calisanfinans
                        from Calisan in calisanfinans.DefaultIfEmpty()
                        join uye in _db.Uye on finans.UyeID equals uye.ID into uyefinans
                        from Uye in uyefinans.DefaultIfEmpty()
                        join kat in _db.GelirGiderKategori on finans.GelirGiderKategoriID equals kat.ID
                        where finans.AktifMi == true
                        where finans.OdemeDurumu == false
                        select new AylikGelirGiderDTO
                        {
                            ID = finans.ID,
                            KategoriAdi = kat.GelirGiderKategoriAdi,
                            UyeAdi = Uye.Ad,
                            CalisanAdi = Calisan.Ad,
                            SporcuAdi = Sporcu.Ad,
                            UrunAdi = Urun.UrunAd,
                            Fiyat = finans.Fiyat,
                            SonOdemeTarihi = finans.SonOdemeTarihi.Value
                        }).Where(x => DbFunctions.DiffDays(x.SonOdemeTarihi, DateTime.Now) > 0).ToList();
            }
        }

        public double GelirYuzdeligiGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
                //double a = (_db.FinansTakip.Where(x=>x.OdemeDurumu==true).Where(x=>x.AktifMi==true).Where(x=>x.OdemeTarihi.Value.Month==DateTime.Now.Month).Count());
                double percentage =Convert.ToDouble( (_db.FinansTakip.Where(x => x.GelirMiGiderMi == true).Where(x => x.OdemeTarihi != null && x.OdemeDurumu==true && x.OdemeTarihi.Value.Month == DateTime.Now.Month).Where(x => x.AktifMi == true).Sum(x=>x.Fiyat)));
                return percentage;
            }
        }
        public double GiderYuzdeligiGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
                //double a = (_db.FinansTakip.Where(x => x.OdemeDurumu == true).Where(x => x.AktifMi == true).Where(x => x.OdemeTarihi.Value.Month == DateTime.Now.Month).Count());
                double percentage = Convert.ToDouble((_db.FinansTakip.Where(x => x.GelirMiGiderMi == false).Where(x => x.OdemeTarihi != null && x.OdemeDurumu == true && x.OdemeTarihi.Value.Month == DateTime.Now.Month).Where(x => x.AktifMi == true).Sum(x=>x.Fiyat)));
                return percentage;
            }
        }

        public double AidatGelirYuzdeligiGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
                //double a = (_db.FinansTakip.Where(x => x.OdemeDurumu == true).Where(x => x.AktifMi == true).Where(x => x.OdemeTarihi.Value.Month == DateTime.Now.Month).Count());
				double percentage =Convert.ToDouble( (_db.FinansTakip.Where(x => x.GelirMiGiderMi == true).Where(x => x.OdemeTarihi != null && x.OdemeDurumu == true && x.OdemeTarihi.Value.Month == DateTime.Now.Month).Where(x => x.AktifMi == true).Where(x=>x.GelirGiderKategoriID==4).Sum(x=>x.Fiyat)))	;
				return percentage;
            }
        }

        public double UrunSatisiGelirYuzdeligiGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
				//double a=(_db.FinansTakip.Where(x => x.OdemeDurumu == true).Where(x => x.AktifMi == true).Where(x => x.OdemeTarihi.Value.Month == DateTime.Now.Month).Count());
				double percentage =Convert.ToDouble( (_db.FinansTakip.Where(x => x.GelirMiGiderMi == true).Where(x => x.OdemeTarihi != null && x.OdemeDurumu == true && x.OdemeTarihi.Value.Month == DateTime.Now.Month).Where(x => x.AktifMi == true).Where(x => x.GelirGiderKategoriID == 2).Sum(x=>x.Fiyat)));
				return percentage;
            }
        }

        public double DigerGelirGelirYuzdeligiGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
				//double a = (_db.FinansTakip.Where(x => x.OdemeDurumu == true).Where(x => x.AktifMi == true).Where(x => x.OdemeTarihi.Value.Month == DateTime.Now.Month).Count());
				double percentage = Convert.ToDouble((_db.FinansTakip.Where(x => x.GelirMiGiderMi == true).Where(x => x.OdemeTarihi != null && x.OdemeDurumu == true && x.OdemeTarihi.Value.Month == DateTime.Now.Month).Where(x => x.AktifMi == true).Where(x => x.GelirGiderKategoriID == 8).Sum(x=>x.Fiyat)));
				return percentage;
            }
        }

        public double KiralamaGelirYuzdeligiGetir()
        {
            using (CRMContext _db = new CRMContext())
            {
				//double a =Convert.ToDouble( (_db.FinansTakip.Where(x => x.OdemeDurumu == true).Where(x => x.AktifMi == true).Where(x => x.OdemeTarihi.Value.Month == DateTime.Now.Month).Sum(x=>x.Fiyat)));
				double percentage =Convert.ToDouble( (_db.FinansTakip.Where(x => x.GelirMiGiderMi == true).Where(x => x.OdemeTarihi != null && x.OdemeDurumu == true && x.OdemeTarihi.Value.Month == DateTime.Now.Month).Where(x => x.AktifMi == true).Where(x => x.GelirGiderKategoriID == 7).Sum(x=>x.Fiyat)));
				return percentage;
            }
        }




        public ICollection<GelirYillikChartDTO> GelirYillikGrafikGetir(DateTime dateTime)
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from finans in _db.FinansTakip.Where(x => x.GelirMiGiderMi == true && x.OdemeDurumu == true && x.AktifMi == true && x.OdemeTarihi.Value.Year == dateTime.Year)
                        group finans by finans.OdemeTarihi.Value.Month into g
                        select new GelirYillikChartDTO
                        {
                            Ay = g.Key,
                            ToplamTutar = g.Sum(x => x.Fiyat)
                        }).ToList();
            }

        }

        public ICollection<AylikGelirGiderDTO> KategoriBilgileriniGetir(string ad)
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from finans in _db.FinansTakip
                        join urun in _db.Urun on finans.UrunID equals urun.ID into urunfinans
                        from Urun in urunfinans.DefaultIfEmpty()
                        join sporcu in _db.Sporcu on finans.SporcuID equals sporcu.ID into sporcufinans
                        from Sporcu in sporcufinans.DefaultIfEmpty()
                        join calisan in _db.Calisan on finans.CalisanID equals calisan.ID into calisanfinans
                        from Calisan in calisanfinans.DefaultIfEmpty()
                        join uye in _db.Uye on finans.UyeID equals uye.ID into uyefinans
                        from Uye in uyefinans.DefaultIfEmpty()
                        join kat in _db.GelirGiderKategori on finans.GelirGiderKategoriID equals kat.ID
                        where finans.AktifMi == true
                        where finans.OdemeDurumu == false
                        select new AylikGelirGiderDTO
                        {
                            ID = finans.ID,
                            KategoriAdi = kat.GelirGiderKategoriAdi,
                            UyeAdi = Uye.Ad,
                            CalisanAdi = Calisan.Ad,
                            SporcuAdi = Sporcu.Ad,
                            UrunAdi = Urun.UrunAd,
                            Fiyat = finans.Fiyat,
                            SonOdemeTarihi = finans.SonOdemeTarihi.Value
                        }).Where(x => x.KategoriAdi.Contains(ad) && DbFunctions.DiffDays(x.SonOdemeTarihi, DateTime.Now) > 0).ToList();
            }
        }

        public ICollection<FinansTakipDTO> FinansBilgileriniGetir(string ad)
        {
            using (CRMContext _db = new CRMContext())
            {

                return (from finans in _db.FinansTakip
                        join kategori in _db.GelirGiderKategori on finans.GelirGiderKategoriID equals kategori.ID
                        join sporcu in _db.Sporcu on finans.SporcuID equals sporcu.ID
                        join calisan in _db.Calisan on finans.CalisanID equals calisan.ID
                        join uye in _db.Uye on finans.UyeID equals uye.ID
                        join urun in _db.Urun on finans.UrunID equals urun.ID
                        select new FinansTakipDTO
                        {
                            ID = finans.ID,
                            GelirGiderAdi = kategori.GelirGiderKategoriAdi,
                            UyeAdi = uye.Ad,
                            CalisanAdi = calisan.Ad,
                            SporcuAdi = sporcu.Ad,
                            UrunAdi = urun.UrunAd,
                            Not = finans.Not,
                            UrunFiyat = urun.SatisFiyati,
                            UrunAdet = urun.StokBilgisi,
                            OdemeTarihi = finans.OdemeTarihi,
                            SonOdemeTarihi = finans.SonOdemeTarihi
                        }).Where(x => x.GelirGiderAdi.Contains(ad) || x.CalisanAdi.Contains(ad) || x.SporcuAdi.Contains(ad) || x.UrunAdi.Contains(ad)).ToList();
            }
        }


        //  public ICollection<AyaGoreGelirGiderYuzdelikleriDTO> GelirYuzdeligiGetir()
        // {
        //    using (CRMContext _db = new CRMContext())
        //    {
        //        var gelirYuzde = _db.FinansTakip.Where(x => x.GelirMiGiderMi =)
        //    }

        // }
        public ICollection<GiderYillikChartDTO> GiderYillikGrafikGetir(DateTime dateTime)
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from finans in _db.FinansTakip.Where(x => x.GelirMiGiderMi == false && x.OdemeDurumu == true && x.AktifMi == true && x.OdemeTarihi.Value.Year == dateTime.Year)
                        group finans by finans.OdemeTarihi.Value.Month into g
                        select new GiderYillikChartDTO
                        {
                            Ay = g.Key,
                            ToplamTutar = g.Sum(x => x.Fiyat)
                        }).ToList();
            }

        }

        public ICollection<BulundugumAyinGelirGiderMiktarlariDTO> BulundugumAyinGelirGiderMiktarlari()
        {
            using (CRMContext _db = new CRMContext())
            {
                var gelirToplami = _db.FinansTakip.Where(x => x.AktifMi == true).Where(x => x.OdemeDurumu == true).Where(x => x.GelirMiGiderMi == true).Where(x=>x.OdemeTarihi.Value.Month==DateTime.Now.Month).Sum(x => x.Fiyat);
                var giderToplami = _db.FinansTakip.Where(x => x.AktifMi == true).Where(x => x.OdemeDurumu == true).Where(x => x.GelirMiGiderMi == false).Where(x => x.OdemeTarihi.Value.Month == DateTime.Now.Month).Sum(x => x.Fiyat);
                return _db.FinansTakip.Select(x => new BulundugumAyinGelirGiderMiktarlariDTO
                {
                    GelirMiktari = gelirToplami,
                    GiderMiktari=giderToplami

                }).ToList();
            }

        }
    }
}
