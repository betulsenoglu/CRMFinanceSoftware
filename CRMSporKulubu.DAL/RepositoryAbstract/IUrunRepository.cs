using CRMSporKulubu.Entities.DTO;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.RepositoryAbstract
{
	interface IUrunRepository : IBaseRepository<Urun>
	{
        ICollection<YillikUrunSatisDTO> YillikUrunSatisGrafigi();
        ICollection<UrunStokDagilimiDTO> UrunStokDagilimiGrafigi();
        ICollection<YillikUrunKazancDTO> UrunKazancGrafigi();

    }
}
