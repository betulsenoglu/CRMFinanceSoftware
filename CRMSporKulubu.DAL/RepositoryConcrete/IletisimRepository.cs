using CRMSporKulubu.DAL.CRMDbContext;
using CRMSporKulubu.DAL.RepositoryAbstract;
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
    public class IletisimRepository : IIletisimRepository
    {
        int _etkilenenSatir;
        public int AddItem(Iletisim item)
        {
            try
            {
                using (CRMContext _db = new CRMContext())
                {
                    _db.Iletisim.Add(item);
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

        public int DeleteItem(Iletisim item)
        {
            using (var _db = new CRMContext())
            {
                _db.Iletisim.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;

            }

        }

        public ICollection<Iletisim> GetAllById(int? id = null)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.Iletisim.ToList();
            }
        }

        public Iletisim GetById(int id)
        {
            using (CRMContext _db = new CRMContext())
            {
                return _db.Iletisim.Where(x => x.ID == id).FirstOrDefault();
            }
        }

        public int UpdateCalisanItem(Iletisim item)
        {
            using (CRMContext _db = new CRMContext())
            {
                Iletisim eskiIletisim = _db.Iletisim.Where(x => x.CalisanID == item.CalisanID).FirstOrDefault();
                eskiIletisim.Adres = item.Adres;
                eskiIletisim.EMail = item.EMail;
                eskiIletisim.Telefon = item.Telefon;
                eskiIletisim.CalisanID = item.CalisanID;
                eskiIletisim.GuncellenmeTarihi = DateTime.Now;
              //  eskiIletisim.AktifMi = true;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;

            }
        }

        public int UpdateItem(Iletisim item)
        {
            throw new NotImplementedException();
        }

        public int UpdateSporcuItem(Iletisim item)
        {
            using (CRMContext _db = new CRMContext())
            {
                Iletisim eskiIletisim = _db.Iletisim.Where(x => x.ID == item.SporcuID).FirstOrDefault();
                eskiIletisim.Adres = item.Adres;
                eskiIletisim.EMail = item.EMail;
                eskiIletisim.Telefon = item.Telefon;
                eskiIletisim.SporcuID = item.SporcuID;
                eskiIletisim.GuncellenmeTarihi = DateTime.Now;

                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;

            }
        }

        public int UpdateUyeItem(Iletisim item)
        {
            using (CRMContext _db = new CRMContext())
            {
                Iletisim eskiIletisim = _db.Iletisim.Where(x => x.UyeID == item.UyeID).FirstOrDefault();
                eskiIletisim.Adres = item.Adres;
                eskiIletisim.EMail = item.EMail;
                eskiIletisim.Telefon = item.Telefon;
                eskiIletisim.GuncellenmeTarihi = DateTime.Now;
                eskiIletisim.AktifMi = true;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;

            }
        }
    }
}
