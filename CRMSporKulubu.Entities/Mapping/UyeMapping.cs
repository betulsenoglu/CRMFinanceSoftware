using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Mapping
{
	public class UyeMapping : EntityTypeConfiguration<Uye>
	{
		public UyeMapping()
		{
			this.ToTable("Uye");
            HasIndex(x => x.TCKimlikNo).IsClustered(false).IsUnique();
            Property(x => x.TCKimlikNo).HasColumnType("char").HasMaxLength(11).IsRequired();
            Property(x => x.Ad).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
			Property(x => x.Soyad).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
			Property(x => x.Cinsiyet).HasColumnType("int").IsRequired();
			Property(x => x.Aidat).IsRequired();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.AktifMi).HasColumnType("bit").IsOptional();

			this.HasMany(x => x.UyeFinansTakipleri)
				.WithOptional()
				.HasForeignKey(x => x.UyeID)
				.WillCascadeOnDelete(true);

			this.HasMany(x => x.UyeIletisimleri)
				.WithOptional()
				.HasForeignKey(x => x.UyeID)
				.WillCascadeOnDelete(true);


		}
	}
}
