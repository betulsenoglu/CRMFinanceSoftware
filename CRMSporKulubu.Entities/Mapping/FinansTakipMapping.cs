using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Mapping
{
	public class FinansTakipMapping : EntityTypeConfiguration<FinansTakip>
	{
		public FinansTakipMapping()
		{
			this.ToTable("FinansTakip");
			Property(x => x.Fiyat).IsRequired();
			Property(x => x.OdemeDurumu).HasColumnType("bit").IsRequired();
			Property(x => x.OdemeTarihi).IsOptional();
			Property(x => x.UrunAdet).IsOptional();			
			Property(x => x.GelirMiGiderMi).HasColumnType("bit").IsRequired();
			Property(x => x.Not).HasColumnType("nvarchar").HasMaxLength(400); 
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.AktifMi).IsOptional();
			Property(x => x.SonOdemeTarihi).IsOptional();





		}
	}
}
