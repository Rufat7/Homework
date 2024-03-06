using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public DBContext _dbContext;
        public Order _selectedOrder;
        public List<string> Statuses = ["Order confirmed", "Received at the warehouse", "Shipped", "Under customs inspection", "At the post office"];
        public int StatusIndex = 0;
        public ObservableCollection<Order> orders;

        public ObservableCollection<Order> Orders
        {
            get { return orders; }
            set { Set(ref orders, value); }
        }
        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set { Set(ref _selectedOrder, value); }
        }


        public AdminMenuViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger,DBContext dBContext)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
            _dbContext = dBContext;
            Orders = new ObservableCollection<Order>(_dbContext.Orders.Include(x => x.Users).Include(x => x.Products).ToList());
        }



        public RelayCommand Exit
        {
            get => new(
                () =>
                {
                    _navigationService.NavigateTo<LogInViewModel>();
                });
        }

        public RelayCommand NextLevel
        {
            get => new(
                () =>
                {
                    if (SelectedOrder != null && StatusIndex <= 3)
                    {
                        StatusIndex += 1;
                        SelectedOrder.Status = Statuses[StatusIndex];
                        _dbContext.SaveChanges();
                        MessageBox.Show("Status Leveled up!");
                    }
                    else if (SelectedOrder == null)
                        MessageBox.Show("Please select order!");
                    else
                        MessageBox.Show("You order is already delievered!");
                });
        }
        public RelayCommand ToAddProduct
        {
            get => new(
                () =>
                {
                    _navigationService.NavigateTo<AddProductViewModel>();
                });
        }
    }
}
