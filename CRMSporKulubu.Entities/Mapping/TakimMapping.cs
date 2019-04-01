using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Mapping
{
	public class TakimMapping : EntityTypeConfiguration<Takim>
	{
		public TakimMapping()
		{
			this.ToTable("Takim");
			Property(x => x.TakimAdi).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
			Property(x => x.Tur).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.AktifMi).HasColumnType("bit").IsOptional();
            this.HasMany(x => x.TakimSporculari).WithOptional().HasForeignKey(x=>x.TakimID).WillCascadeOnDelete(true);


        }
	}
}
