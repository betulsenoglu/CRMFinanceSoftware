using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.DAL.RepositoryAbstract;
using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSporKulubu.DAL.RepositoryConcrete
{
    public class UyeRepository : IUyeRepository
    {
        int _etkilenenSatir;

        public int AddItem(Uye item)
        {
            try
            {
                using (CRMContext _db = new CRMContext())
                {
                    _db.Uye.Add(item);
                    _etkilenenSatir = _db.SaveChanges();
                    return _etkilenenSatir;
                }
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show(validationError.PropertyName.ToString(), validationError.ErrorMessage.ToString());
                    }
                }
                return 0;
            }

        }

        public ICollection<AidatRaporDTO> AidatRapor(DateTime dateTime)
        {
            using (CRMContext _db = new CRMContext())
            {

                return (from uye in _db.Uye
                        join finansTakip in _db.FinansTakip on uye.ID equals finansTakip.UyeID
                        select new AidatRaporDTO
                        {
                            UyeID = uye.ID,
                            Ad = uye.Ad,
                            Soyad = uye.Soyad,
                            Aidat = uye.Aidat,
                            OdemeDurumu = finansTakip.OdemeDurumu,
                            OdemeTarihi = finansTakip.OdemeTarihi,
                            SonOdemeTarihi = finansTakip.SonOdemeTarihi.Value

                        }).Where(x => x.SonOdemeTarihi.Month == dateTime.Month && x.SonOdemeTarihi.Year == dateTime.Year).ToList();

            }
        }
        public int DeleteItem(Uye item)
        {
            using (var _db = new CRMContext())
            {
                var entry = _db.Entry(item);
                if (entry.State == EntityState.Detached)
                { _db.Uye.Attach(item); }
                _db.Uye.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir; //not Detached hatasi alindi o yuzden burasi degisik. Baska entitylerde alinirsa bu kod kullanilir
            }
        }
        public ICollection<Uye> GetAllById(int? id = null)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.Uye.ToList();
            }
        }
        public Uye GetById(int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.Uye.Where(x => x.ID == id).FirstOrDefault();
            }
        }

        public Uye getByTC(string tc)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.Uye.Where(x => x.TCKimlikNo == tc).Where(x => x.AktifMi == true).FirstOrDefault();
            }
        }

        public int UpdateItem(Uye item)
        {
            CRMContext _db1 = new CRMContext();
            Uye eskiUye = _db1.Uye.Where(x => x.ID == item.ID).FirstOrDefault();
            eskiUye.Aidat = item.Aidat;
            eskiUye.TCKimlikNo = item.TCKimlikNo;
            eskiUye.Ad = item.Ad;
            eskiUye.Soyad = item.Soyad;
            eskiUye.Cinsiyet = item.Cinsiyet;
            eskiUye.DogumTarihi = item.DogumTarihi;
            //     eskiUye.UyeFinansTakipleri = item.UyeFinansTakipleri;
            //      eskiUye.UyeIletisimleri = item.UyeIletisimleri;
            eskiUye.GuncellenmeTarihi = DateTime.Now;
            _etkilenenSatir = _db1.SaveChanges();
            return _etkilenenSatir;
        }
        public ICollection<UyeInfoDTO> UyeAllContactInfo()
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from uye in _db.Uye
                            //   join uye in _db.Uye on iletisim.UyeID equals uye.ID
                        where uye.AktifMi == true
                        select new UyeInfoDTO
                        {
                            // ID=uye.ID,
                            TCKimlikNo = uye.TCKimlikNo,
                            Ad = uye.Ad,
                            Soyad = uye.Soyad,
                            Cinsiyet = uye.Cinsiyet,
                            DogumTarihi = uye.DogumTarihi,
                            Telefon = uye.UyeIletisimleri.FirstOrDefault().Telefon,
                            Email = uye.UyeIletisimleri.FirstOrDefault().EMail,
                            Adres = uye.UyeIletisimleri.FirstOrDefault().Adres,
                            AidatBilgisi = uye.Aidat,
                            KayitTarihi = uye.OlusturulmaTarihi.Value,
                            // AktifMi = iletisim.AktifMi.Value

                        }).ToList();

            }
        }

        public ICollection<UyeInfoDTO> UyeAllContactInfoIsmeGore(string isim)
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from uye in _db.Uye
                            //    join iletisim in _db.Iletisim on uye.ID equals iletisim.UyeID
                        where uye.AktifMi == true
                        select new UyeInfoDTO
                        {
                            // ID=uye.ID,
                            TCKimlikNo = uye.TCKimlikNo,
                            Ad = uye.Ad,
                            Soyad = uye.Soyad,
                            Cinsiyet = uye.Cinsiyet,
                            DogumTarihi = uye.DogumTarihi,
                            Telefon = uye.UyeIletisimleri.FirstOrDefault().Telefon,
                            Email = uye.UyeIletisimleri.FirstOrDefault().EMail,
                            Adres = uye.UyeIletisimleri.FirstOrDefault().Adres,
                            AidatBilgisi = uye.Aidat,
                            KayitTarihi = uye.OlusturulmaTarihi.Value
                        }).Where((x => x.Ad.Contains(isim) || x.Soyad.Contains(isim))).ToList();
            }
        }

        public ICollection<UyeDonemDagilimiDTO> uyeDonemDagilimi()
        {
            using (CRMContext _db = new CRMContext())
            {
                return (from uye in _db.Uye
                                      group uye by uye.OlusturulmaTarihi.Value.Year into g   // <-- group by category
                                      select new UyeDonemDagilimiDTO
                                      {
                                          Yil = g.Key,
                                          ToplamSayi = g.Count()
                                      }).ToList();


               // return UyelerDagilimi;
            }
        }
        public ICollection<UyeIletisimleriDTO> uyeIletisimBilgileriniGetir(int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.Iletisim.Where(x => x.UyeID == id).Where(x => x.AktifMi == true).Select(x => new UyeIletisimleriDTO
                {
                    Email = x.EMail,
                    Telefon = x.Telefon,
                    Adres = x.Adres


                }).ToList();
            }
        }
    }
}
