using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Windows;
using Trendyol.Models;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
	internal class AdminMenuViewModel : ViewModelBase
	{
		private readonly IMessenger _messenger;
		private readonly INavigationService _navigationService;
		private readonly IDataService _dataService;
		private readonly DBContext _dbContext;
		private Order _selectedOrder;
		private readonly string[] _statuses = { "Order confirmed", "Received at the warehouse", "Shipped", "Under customs inspection", "At the post office" };
		private int _statusIndex = 0;
		private ObservableCollection<Order> _orders;

		public ObservableCollection<Order> Orders
		{
			get => _orders;
			set => Set(ref _orders, value);
		}

		public Order SelectedOrder
		{
			get => _selectedOrder;
			set => Set(ref _selectedOrder, value);
		}

		public AdminMenuViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger, DBContext dbContext)
		{
			_navigationService = navigationService;
			_dataService = dataService;
			_messenger = messenger;
			_dbContext = dbContext;
			Orders = new ObservableCollection<Order>(_dbContext.Orders.Include(x => x.Users).Include(x => x.Products).ToList());
		}

		public RelayCommand Exit => new(() => _navigationService.NavigateTo<LoglnViewModel>());

		public RelayCommand NextLevel => new(() =>
		{
			if (SelectedOrder != null && _statusIndex <= 3)
			{
				_statusIndex++;
				SelectedOrder.Status = _statuses[_statusIndex];
				_dbContext.SaveChanges();
				MessageBox.Show("Status Leveled up!");
			}
			else if (SelectedOrder == null)
			{
				MessageBox.Show("Please select an order!");
			}
			else
			{
				MessageBox.Show("Your order is already delivered!");
			}
		});

		public RelayCommand ToAddProduct => new(() => _navigationService.NavigateTo<AddProductViewModel>());
	}
}
