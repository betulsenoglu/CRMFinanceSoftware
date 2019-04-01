//using CRMSporKulubu.WinUI.Deneme;
using CRMSporKulubu.WinUI.LoginUI;
using CRMSporKulubu.WinUI.MenuUI;
using CRMSporKulubu.WinUI.PanelUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMSporKulubu.WinUI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new UrunUI());
			//Application.Run(new Sporcular1());
			// Application.Run(new FinansUI());
			//Application.Run(new Calisanlar());
			//Application.Run(new Calisanİslemleri());
		Application.Run(new Anasayfa());
			//Application.Run(new RaporTest());
			//Application.Run(new KullaniciKayit());
			//Application.Run(new KullaniciGiris());
			//Application.Run(new yillaraGoreUyeDagilimi());
			// Application.Run(new AccountSettings());
			//Application.Run(new YillikGelirGiderChart());
			//Application.Run(new SifreGuncelle());
			//Application.Run(new AnasayfaGuncelDurum());
			//Application.Run(new Raporlar());
			//Application.Run(new YeniUyeEkle());
			//Application.Run(new CalisanlarForm());
			//Application.Run(new Sporcular());
			//Application.Run(new Uyeler());
		}
    }
}
    