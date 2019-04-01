using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Mapping
{
	public class GelirGiderKategoriMapping : EntityTypeConfiguration<GelirGiderKategori>
	{
		public GelirGiderKategoriMapping()
		{
			this.ToTable("GelirGiderKategori");
			Property(x => x.GelirGiderKategoriAdi).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
			Property(x => x.GelirMiGiderMi).HasColumnType("bit").IsRequired();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.AktifMi).HasColumnType("bit").IsOptional();

			this.HasMany(x => x.GelirGiderKategoriFinansTakipleri)
				.WithRequired()
				.HasForeignKey(x => x.GelirGiderKategoriID)
				.WillCascadeOnDelete(true);
		}
	}
}
