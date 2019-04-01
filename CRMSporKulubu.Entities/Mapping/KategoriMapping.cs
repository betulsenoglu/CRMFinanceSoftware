using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Mapping
{
	public class KategoriMapping : EntityTypeConfiguration<Kategori>
	{
		public KategoriMapping()
		{
			this.ToTable("Kategori");
			Property(x => x.KategoriAdi).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.AktifMi).HasColumnType("bit").IsOptional();


		}
	}
}
