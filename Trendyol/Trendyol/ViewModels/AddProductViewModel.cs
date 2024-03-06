using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Trendyol.Models;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
    class AddProductViewModel : ViewModelBase
    {

        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        public string _name;
        public string _description;
        public float _price;
        public byte[] _selectedImage;
        DBContext _dbContext;

        public int _count;
		public int Count
		{
			get { return _count; }
			set { Set(ref _count, value); }
		}

		public byte[] SelectedImage
        {
            get { return _selectedImage; }
            set { Set(ref _selectedImage, value); }
        }
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }  
        public string Description
        {
            get { return _description; }
            set { Set(ref _description, value); }
        } 
        public float Price
        {
            get { return _price; }
            set { Set(ref _price, value); }
        }

        public AddProductViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger,DBContext dbContext)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
            _dbContext = dbContext;
            
        }

        public RelayCommand BrowseImage => new(() =>
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif; *.tif; ...";
            if (openFileDialog.ShowDialog() == true)
            {
                SelectedImage = File.ReadAllBytes(openFileDialog.FileName);
            }
        });

        public RelayCommand AddProduct => new(() =>
        {
            if (Name != null && Description != null && Price != 0 && SelectedImage != null)
            {
                Product newProduct = new()
                {
                    Name = Name,
                    Description = Description,
                    Price = Price,
                    Image = SelectedImage
                };
				_dbContext.Products.Add(newProduct);
				_dbContext.SaveChanges();
				Warehouse newWarehouse = new()
                {
                    count = Count,
                    ProductId = newProduct.Id,
                };
                _dbContext.Warehouse.Add(newWarehouse);
                _dbContext.SaveChanges();
                MessageBox.Show("Sucessfully added new product!");
            }
            else
                MessageBox.Show("Something wet wrong!Please try again");
            Name = "";
            Description = "";
            Price = 0;
        });

        public RelayCommand Exit => new(() =>
        {
            _navigationService.NavigateTo<AdminMenuViewModel>();
        });

    }
}
