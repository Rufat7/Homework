using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.Windows;
using Trendyol.Models;
using Trendyol.Services.Interfaces;
using Trendyol.Views;

namespace Trendyol.ViewModels
{
	class GoodsViewModel : ViewModelBase
	{
		private readonly IMessenger _messenger;
		private readonly INavigationService _navigationService;
		private readonly IDataService _dataService;
		private readonly DBContext _dbContext;

		public ObservableCollection<Product> Products { get; set; }
		public int ProductCount { get; set; }
		public Product SelectedProduct { get; set; }

		public GoodsViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger, DBContext dbContext)
		{
			_dbContext = dbContext;
			_navigationService = navigationService;
			_dataService = dataService;
			_messenger = messenger;
			Products = new ObservableCollection<Product>(_dbContext.Products);
		}

		public RelayCommand Buy => new(() =>
		{
			if (SelectedProduct != null)
			{
				_dataService.SendData(SelectedProduct);
				_navigationService.NavigateTo<OrderViewModel>();
			}
			else
			{
				MessageBox.Show("Please select a product!");
			}
		});

		public RelayCommand ToProfile => new(() =>
		{
			_navigationService.NavigateTo<ProfileViewModel>();
		});

		public RelayCommand Exit => new(() =>
		{
			_navigationService.NavigateTo<LoglnViewModel>();
		});
	}
}
