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
	public class UrunService
	{
		UrunRepository _urunRepository;
		public UrunService()
		{
			_urunRepository = new UrunRepository();
		}

		public int AddUrunService(Urun urun)
		{
			try
			{
				return _urunRepository.AddItem(urun);
			}
			catch (Exception e)
			{
				MessageBox.Show("Hata : " + e.Message);
				return 0;
			}
		}

		public List<UrunDTO> ArananUrunService(string isim)
		{
			return _urunRepository.ArananUrun(isim).ToList();
		}

		public List<Urun> TumurunleriGetir()
		{
			return _urunRepository.GetAllById().ToList();
		}
		public Urun UrunGetirById(int ID)
		{
			return _urunRepository.GetById(ID);
		}
		public int UrunUpdate(Urun urun)
		{
			return _urunRepository.UpdateItem(urun);
		}
		public int UrunSil(Urun urun)
		{
			return _urunRepository.DeleteItem(urun);
		}
        public List<UrunDTO> UrunBilgileriRaporu()
        {
            return _urunRepository.UrunBilgileriniListele().ToList();
        }
        public List<YillikUrunSatisDTO> YillikUrunSatisGrafigi()
        {
            return _urunRepository.YillikUrunSatisGrafigi().ToList();
        }
        public List<UrunStokDagilimiDTO> UrunStokDagilimiGrafigi()
        {
            return _urunRepository.UrunStokDagilimiGrafigi().ToList();
        }
        public List<YillikUrunKazancDTO> UrunKazancGrafigi()
        {
            return _urunRepository.UrunKazancGrafigi().ToList();
        }
    }
}
