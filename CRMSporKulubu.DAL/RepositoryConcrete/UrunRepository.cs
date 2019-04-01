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
    public class UrunRepository : IUrunRepository
    {
        int _etkilenenSatir;

        public UrunRepository()
        {

        }
        public int AddItem(Urun item)
        {
            using (CRMContext _db = new CRMContext())
            {
                _db.Urun.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }


        public int DeleteItem(Urun item)
        {
            using (CRMContext _db = new CRMContext())
            {
                var entry = _db.Entry(item);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    _db.Urun.Attach(item);
                }
                _db.Urun.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<Urun> GetAllById(int? id = null)
        {
            CRMContext _db = new CRMContext();

            return _db.Urun.ToList();

        }

        public object UrunBilgileriniGetir()
        {
            throw new NotImplementedException();
        }


        public Urun GetById(int id)

        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.Urun.Where(x => x.ID == id).FirstOrDefault();
            }
        }

        public int UpdateItem(Urun item)
        {
            using (CRMContext _db = new CRMContext())
            {
                Urun eskiUrun = _db.Urun.Where(x => x.ID == item.ID).FirstOrDefault();
                eskiUrun.ID = item.ID;
                eskiUrun.UrunAd = item.UrunAd;
                //eskiUrun.Kategori = item.Kategori;
                eskiUrun.KategoriID = item.KategoriID;
                eskiUrun.Maaliyet = item.Maaliyet;
                eskiUrun.GuncellenmeTarihi = DateTime.Now;
                eskiUrun.SatisFiyati = item.SatisFiyati;
                eskiUrun.StokBilgisi = item.StokBilgisi;
                eskiUrun.Aciklama = item.Aciklama;

                //eskiUrun.UrunFinansTakipleri = item.UrunFinansTakipleri;

                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }

        }

        public ICollection<UrunDTO> ArananUrun(string isim)
        {
            CRMContext _db = new CRMContext();

            //return isim == null ?
            //    _db.Urun.ToList() :
            //    _db.Urun.SqlQuery("select * from Urun where UrunAd Like '%" + isim + "%'").ToList();
            return (from urun in _db.Urun
                    join katagori in _db.Kategori on urun.KategoriID equals katagori.ID
                    where urun.AktifMi == true
                    select new UrunDTO
                    {
                        // ID=uye.ID,
                        UrunAdi = urun.UrunAd,
                        ID = urun.ID,
                        Kategori = katagori.KategoriAdi,
                        Maaliyet = urun.Maaliyet,
                        Aciklama = urun.Aciklama,
                        StokBilgisi = urun.StokBilgisi,
                        SatisFiyati = urun.SatisFiyati,
						OlusturmaTarihi = urun.OlusturulmaTarihi,
						GuncelleTarihi = urun.GuncellenmeTarihi
					}).Where((x => x.UrunAdi.Contains(isim))).ToList();


        }
        public ICollection<UrunDTO> UrunBilgileriniListele()
        {
            using (CRMContext _db = new CRMContext())
            {
				return (from urun in _db.Urun
						join katagori in _db.Kategori on urun.KategoriID equals katagori.ID
						select new UrunDTO
						{
							UrunAdi = urun.UrunAd,
							ID = urun.ID,
							Kategori = katagori.KategoriAdi,
							Aciklama = urun.Aciklama,
							Maaliyet = urun.Maaliyet,
							StokBilgisi = urun.StokBilgisi,
							SatisFiyati = urun.SatisFiyati,
							OlusturmaTarihi = urun.OlusturulmaTarihi,
							GuncelleTarihi = urun.GuncellenmeTarihi
							
							


                        }).ToList();
            }

        }

        public ICollection<YillikUrunSatisDTO> YillikUrunSatisGrafigi()
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from finansTakip in _db.FinansTakip.Where(x => x.UrunID != null && x.GelirMiGiderMi==true && x.OdemeTarihi.Value.Year == DateTime.Now.Year)
                        group finansTakip by finansTakip.OdemeTarihi.Value.Month into x
                        select new YillikUrunSatisDTO
                        {
                            Ay = x.Key,
                            SatisMiktari = x.Sum(a => a.UrunAdet).Value
                        }).ToList();
            }
        }

        public ICollection<UrunStokDagilimiDTO> UrunStokDagilimiGrafigi()
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.Urun.Select(x => new UrunStokDagilimiDTO
                {
                    UrunAdi = x.UrunAd,
                    UrunStok = x.StokBilgisi
                }).ToList();

            }
        }

        public ICollection<YillikUrunKazancDTO> UrunKazancGrafigi()
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from finansTakip in _db.FinansTakip.Where(x=> x.GelirMiGiderMi == true && x.OdemeTarihi.Value.Year == DateTime.Now.Year && x.UrunID!=null)
                                  
                        group finansTakip by finansTakip.OdemeTarihi.Value.Month into x
                        select new YillikUrunKazancDTO
                        {
                            Ay = x.Key,
                            Fiyat = x.Sum(y =>y.Fiyat*y.UrunAdet)
                        }).ToList();
            }
        }
    }
}

