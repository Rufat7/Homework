using GalaSoft.MvvmLight.Messaging;
using System.Configuration;
using SimpleInjector;
using System.Data;
using System.Windows;
using System.Windows.Navigation;
using Trendyol.Services.Classes;
using Trendyol.Services.Interfaces;
using NavigationService = Trendyol.Services.Classes.NavigationService;
using Trendyol.ViewModels;
using Trendyol.Views;

namespace Trendyol
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container Container { get; set; } = new();

        public static string a;
        public void Register()
        {

            Container.RegisterSingleton<IMessenger, Messenger>();
            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<IDataService, DataService>();

            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<LogInViewModel>();
            Container.RegisterSingleton<RegistrationViewModel>();
            Container.RegisterSingleton<ProfileViewModel>();
            Container.RegisterSingleton<GoodsPageViewModel>();
            Container.RegisterSingleton<OrderPageViewModel>();
            Container.RegisterSingleton<SuperAdminMenuViewModel>();
            Container.RegisterSingleton<AdminMenuViewModel>();
            Container.RegisterSingleton<AddProductViewModel>();
            Container.RegisterSingleton<DBContext>();
            Container.RegisterSingleton<LogInService>();
            

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
