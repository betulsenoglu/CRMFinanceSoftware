using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Mapping
{
	public class GizliSoruMapping : EntityTypeConfiguration<GizliSoru>
	{
		public GizliSoruMapping()
		{
			this.ToTable("GizliSoru");
			Property(x => x.Soru).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.AktifMi).HasColumnType("bit").IsOptional();
		}
	}
}
