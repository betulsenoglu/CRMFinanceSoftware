using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Mapping
{
	public class IletisimMapping : EntityTypeConfiguration<Iletisim>
	{
		public IletisimMapping()
		{
			this.ToTable("Iletisim");
			Property(x => x.Telefon).HasMaxLength(11).HasColumnType("char").IsRequired();
			Property(x => x.EMail).HasMaxLength(50).IsRequired();
			Property(x => x.Adres).IsRequired().HasMaxLength(500);
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.AktifMi).HasColumnType("bit").IsOptional();

		}
	}
}
