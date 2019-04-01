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
	public class IletisimService
	{
		IletisimRepository _iletisimRepository;
		public IletisimService()
		{
			_iletisimRepository = new IletisimRepository();
		}

		public int AddIletisimService(Iletisim iletisim)
		{
			try
			{
				return _iletisimRepository.AddItem(iletisim);
			}
			catch (Exception e)
			{
				MessageBox.Show("Hata : " + e.Message);
				return 0;
			}
		}

		public List<Iletisim> TumIletisimleriGetir()
		{
			return _iletisimRepository.GetAllById().ToList();
		}

		public Iletisim IletisimGetirById(int ID)
		{
			return _iletisimRepository.GetById(ID);
		}
		public int IletisimUyeUpdate(Iletisim iletisim)
		{
			return _iletisimRepository.UpdateUyeItem(iletisim);
		}
        public int IletisimCalisanUpdate(Iletisim iletisim)
        {
            return _iletisimRepository.UpdateCalisanItem(iletisim);
        }
        public int IletisimSpocuUpdate(Iletisim iletisim)
        {
            return _iletisimRepository.UpdateSporcuItem(iletisim);
        }

        public int IletisimSil(Iletisim iletisim)
		{
			return _iletisimRepository.DeleteItem(iletisim);
		}
	}
}