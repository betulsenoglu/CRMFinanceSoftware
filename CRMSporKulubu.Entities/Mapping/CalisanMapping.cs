using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRMSporKulubu.Entities.Mapping
{
	public class CalisanMapping : EntityTypeConfiguration<Calisan>
	{
		public CalisanMapping()
		{
			this.ToTable("Calisan");
            HasIndex(x => x.TCKimlikNo).IsClustered(false).IsUnique();
            Property(x => x.TCKimlikNo).HasColumnType("char").HasMaxLength(11).IsRequired();
			Property(x => x.Ad).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
			Property(x => x.Soyad).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
			Property(x => x.Cinsiyet).HasColumnType("int").IsRequired();
			Property(x => x.Maas).IsOptional();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.AktifMi).HasColumnType("bit").IsOptional();
            Property(x => x.KullaniciMi).HasColumnType("bit").IsRequired();


            this.HasMany(x => x.CalisanFinansTakipleri)
				.WithOptional()
				.HasForeignKey(x => x.CalisanID)
				.WillCascadeOnDelete(true);
			this.HasMany(x => x.CalisanIletisimleri)
				.WithOptional()
				.HasForeignKey(x => x.CalisanID)
				.WillCascadeOnDelete(true);



		}
	}
}
