using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.Entities.Mapping
{
	public class GirisIslemleriMapping : EntityTypeConfiguration<GirisIslemleri>
	{
		public GirisIslemleriMapping()
		{
			this.ToTable("Girisİslemleri");
			Property(x => x.GizliSoruCevap).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
			Property(x => x.KullaniciAdi).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
			Property(x => x.Sifre).HasColumnType("char").HasMaxLength(8).IsRequired();
			Property(x => x.KullaniciMi).HasColumnType("bit").IsRequired();
			Property(x => x.GuncellenmeTarihi).IsOptional();
			Property(x => x.OlusturulmaTarihi).IsOptional();
			Property(x => x.AktifMi).HasColumnType("bit").IsOptional();
		}
	}
}
