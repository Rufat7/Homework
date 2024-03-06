using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Linq;
using System.Windows;
using Trendyol.Services.Classes;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
	class LoglnViewModel : ViewModelBase
	{
		private readonly IMessenger _messenger;
		private readonly INavigationService _navigationService;
		private readonly IDataService _dataService;
		private readonly DBContext _dbContext = new();
		private readonly LoglnService _loginService = new();
		private readonly VerificationService _verificationService = new();

		public string Email { get; set; }
		public string Password { get; set; }

		public LoglnViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger)
		{
			_navigationService = navigationService;
			_dataService = dataService;
			_messenger = messenger;
		}

		public RelayCommand LogIn => new(() =>
		{
			if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
			{
				MessageBox.Show("Please fill the fields!");
			}
			else
			{
				var currentUser = _dbContext.Users.FirstOrDefault(x => x.Email == Email);

				if (currentUser != null && _loginService.IsEmail(Email, _dbContext) && _loginService.PasswordIsTrue(Password, _dbContext, currentUser))
				{
					MessageBox.Show("Successfully Logged in!");

					if (currentUser.Membership == "User")
					{
						_dataService.SendData(currentUser);
						_navigationService.NavigateTo<GoodsViewModel>();
					}
					else if (currentUser.Membership == "SuperAdmin")
					{
						_navigationService.NavigateTo<SuperAdminMenuViewModel>();
					}
					else if (currentUser.Membership == "Admin")
					{
						_navigationService.NavigateTo<AdminMenuViewModel>();
					}

					Email = "";
					Password = "";
				}
				else
				{
					MessageBox.Show("Something went wrong! Please try again");
					Email = "";
					Password = "";
				}
			}
		});
	}
}
