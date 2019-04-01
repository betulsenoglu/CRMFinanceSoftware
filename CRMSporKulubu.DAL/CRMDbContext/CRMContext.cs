using CRMSporKulubu.Entities.Mapping;
using CRMSporKulubu.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMSporKulubu.DAL.CRMDbContext
{
	public class CRMContext : DbContext
	{
		public CRMContext()
		{
           // Database.Connection.ConnectionString = @"server=ESHAT\SQLEXPRESS; database=CRMSporKulubuDB; integrated security=true";
            //Database.Connection.ConnectionString = @"server=WISSEN-PC\MSSQLSRV;Database=CRMSporKulubuDB;UID=sa; PWD=12345";
            //Database.Connection.ConnectionString = @"server=WISSEN-PC\MSSQLSRV;Database=CRMSporKulubuDB;UID=sa; PWD=12345";
            //Database.Connection.ConnectionString = @"server=WISSEN-PC\MSSQLSRV;Database=CRMSporKulubuDB;UID=sa; PWD=12345";
            //Database.Connection.ConnectionString = @"server=WISSEN-PC\MSSQLSRV;Database=CRMSporKulubuDB;UID=sa; PWD=12345";
            Database.Connection.ConnectionString = @"server=BETUL-WINDOWS\BETULMSSQL;Database=CRMSporKulubuDB;UID=sa; PWD=12345";
            //Database.Connection.ConnectionString = @"server=.; Database=CRMSporDB; integrated security=true";
         //   Database.Connection.ConnectionString = @"server=ASUSPC\SQLEXPRESS; database=CRMSporKulubuDB; integrated security=true";
		}
		public DbSet<Calisan> Calisan { get; set; }
		public DbSet<FinansTakip> FinansTakip { get; set; }
		public DbSet<GelirGiderKategori> GelirGiderKategori { get; set; }
		public DbSet<GirisIslemleri> GirisIslemleri { get; set; }
		public DbSet<GizliSoru> GizliSoru { get; set; }
		public DbSet<Iletisim> Iletisim { get; set; }
		public DbSet<Kategori> Kategori { get; set; }
		public DbSet<Sporcu> Sporcu { get; set; }
		public DbSet<Takim> Takim { get; set; }
		public DbSet<Urun> Urun { get; set; }
		public DbSet<Uye> Uye { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new CalisanMapping());
			modelBuilder.Configurations.Add(new FinansTakipMapping());
			modelBuilder.Configurations.Add(new GelirGiderKategoriMapping());
			modelBuilder.Configurations.Add(new GirisIslemleriMapping());
			modelBuilder.Configurations.Add(new GizliSoruMapping());
			modelBuilder.Configurations.Add(new IletisimMapping());
			modelBuilder.Configurations.Add(new KategoriMapping());
			modelBuilder.Configurations.Add(new SporcuMapping());
			modelBuilder.Configurations.Add(new TakimMapping());
			modelBuilder.Configurations.Add(new UrunMapping());
			modelBuilder.Configurations.Add(new UyeMapping());


        }
    }
}
