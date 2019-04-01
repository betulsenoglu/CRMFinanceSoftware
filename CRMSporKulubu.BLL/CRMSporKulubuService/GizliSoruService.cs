using CRMSporKulubu.DAL.RepositoryConcrete;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.BLL.CRMSporKulubuService
{
	public class GizliSoruService
	{
		GizliSoruRepository _gizliSoruRepository;
		public GizliSoruService()
		{
			_gizliSoruRepository = new GizliSoruRepository();
		}
		public List<GizliSoru> TumGizliSorulariGetir()
		{
			return _gizliSoruRepository.GetAllById().ToList();
		}
		public GizliSoru GizliSoruGetirById(int ID)
		{
			return _gizliSoruRepository.GetById(ID);
		}

	}
}
