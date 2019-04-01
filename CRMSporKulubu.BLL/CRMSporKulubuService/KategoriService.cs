using CRMSporKulubu.DAL.RepositoryConcrete;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.BLL.CRMSporKulubuService
{
	public class KategoriService
	{
		KategoriRepository _kategoriRepository;
		public KategoriService()
		{
			_kategoriRepository = new KategoriRepository();
		}

		public List<Kategori> TumKategorileriGetir()
		{
			return _kategoriRepository.GetAllById().ToList();
		}
	}
}
