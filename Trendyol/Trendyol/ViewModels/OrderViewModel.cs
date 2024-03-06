using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Trendyol.Messages;
using Trendyol.Models;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
    class OrderViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        public DBContext _dbContext;
        public Product _selectedProduct;
        public User _currentUser;
        public List<string> Statuses = ["Order confirmed", "Received at the warehouse", "Shipped", "Under customs inspection", "At the post office"];
        public ObservableCollection<Warehouse> warehouses;
        public int _stockCount;
        public int _productCount = 0;
        public Warehouse _inStock;

		public Warehouse InStock
		{
			get { return _inStock; }
			set { Set(ref _inStock, value); }
		}

		public ObservableCollection<Warehouse> Warehouses

        {
            get { return warehouses; }
            set { Set(ref warehouses, value); }
        }
        public int ProductCount
        {
            get { return _productCount; }
            set { Set(ref _productCount, value); }
        }
        public int StockCount
        {
            get { return _stockCount; }
            set { Set(ref _stockCount, value); }
        }
        public User CurrentUser
        {
            get => _currentUser;
            set
            {
                Set(ref _currentUser, value); 
            }
        }

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set { Set(ref _selectedProduct, value); }
        }




        public OrderViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger,DBContext dBContext)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
            _dbContext = dBContext;
            Warehouses = new ObservableCollection<Warehouse>(_dbContext.Warehouse);
			_messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as Product != null)
                {
                   SelectedProduct  = message.Data as Product;
					InStock = Warehouses.First(x => x.ProductId == SelectedProduct.Id);
				}
            });
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as User != null)
                {
                    CurrentUser = message.Data as User;
                }
            });
        }


        public RelayCommand Buy
        {
            get => new(
                () =>
                {
                    if (ProductCount > 0)
                    {
                        Order newOrder = new()
                        {
                            UserId = CurrentUser.Id,
                            ProductId = SelectedProduct.Id,
                            Status = "Order confirmed",
                            TotalPrice = SelectedProduct.Price * ProductCount,
                            ProductsCount = ProductCount
                        };
                        InStock.count-=ProductCount;
                        ProductCount = 0;
                        _dbContext.Orders.Add(newOrder);
                        _dbContext.SaveChanges();
                        MessageBox.Show("Sucsessfully bought!");
                        _navigationService.NavigateTo<GoodsViewModel>();
                    }
                    else
                        MessageBox.Show("You must buy at least 1 product");

                });
        }


        public RelayCommand AddProduct
        {
            get => new(
                () =>
                {
                    ProductCount += 1;                
                });
        }

        public RelayCommand RemoveProduct
        {
            get => new(
                () =>
                {
                    if (ProductCount > 0)
                        ProductCount -= 1;
                });
        }

    }
}
