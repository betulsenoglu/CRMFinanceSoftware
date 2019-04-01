using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Mapping
{
	public class UrunMapping : EntityTypeConfiguration<Urun>
	{
		public UrunMapping()
		{
			this.ToTable("Urun");
			Property(x => x.UrunAd).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
			Property(x => x.SatisFiyati).IsRequired();
			Property(x => x.Maaliyet).IsRequired();
			Property(x => x.StokBilgisi).IsRequired();
			Property(x => x.Aciklama).HasColumnType("nvarchar").HasMaxLength(300).IsOptional();
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.AktifMi).HasColumnType("bit").IsOptional();

			this.HasMany(x => x.UrunFinansTakipleri)
				.WithOptional()
				.HasForeignKey(x => x.UrunID)
				.WillCascadeOnDelete(true);

		}
	}
}
