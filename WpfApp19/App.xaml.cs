using GalaSoft.MvvmLight.Messaging;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp19.ViewModels;
using SimpleInjector;
using WpfApp19.Services.Interfaces;
using WpfApp19.Services.Classes;
using WpfApp19.Views;


namespace WpfApp19
{

	public partial class App : Application
	{
		public static Container Container { get; set; } = new();

		public static string a;
		public void Register()
		{
			Container.RegisterSingleton<MainViewModel>();
			Container.RegisterSingleton<InfoViewModel>();

			Container.RegisterSingleton<IMessenger, Messenger>();
			Container.RegisterSingleton<INavigationService, NavigationService>();
			Container.RegisterSingleton<IDataService, DataService>();
			




			Container.Verify();
		}

		protected override void OnStartup(StartupEventArgs e)
		{
			Register();

			var window = new MainView();

			window.DataContext = Container.GetInstance<MainViewModel>();

			window.ShowDialog();
		}
	}
}

