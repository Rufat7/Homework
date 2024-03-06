using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System.IO;
using System.Windows;
using Trendyol.Models;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
	class AddProductViewModel : ViewModelBase
	{
		private readonly IMessenger _messenger;
		private readonly INavigationService _navigationService;
		private readonly IDataService _dataService;
		private readonly DBContext _dbContext;

		private int _count;
		private byte[] _selectedImage;
		private string _name;
		private string _description;
		private float _price;

		public int Count
		{
			get => _count;
			set => Set(ref _count, value);
		}

		public byte[] SelectedImage
		{
			get => _selectedImage;
			set => Set(ref _selectedImage, value);
		}

		public string Name
		{
			get => _name;
			set => Set(ref _name, value);
		}

		public string Description
		{
			get => _description;
			set => Set(ref _description, value);
		}

		public float Price
		{
			get => _price;
			set => Set(ref _price, value);
		}

		public AddProductViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger, DBContext dbContext)
		{
			_navigationService = navigationService;
			_dataService = dataService;
			_messenger = messenger;
			_dbContext = dbContext;
		}

		public RelayCommand BrowseImage => new(() =>
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif; *.tif; ..."
			};

			if (openFileDialog.ShowDialog() == true)
			{
				SelectedImage = File.ReadAllBytes(openFileDialog.FileName);
			}
		});

		public RelayCommand AddProduct => new(() =>
		{
			if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Description) && Price != 0 && SelectedImage != null)
			{
				Product newProduct = new Product
				{
					Name = Name,
					Description = Description,
					Price = Price,
					Image = SelectedImage
				};

				_dbContext.Products.Add(newProduct);
				_dbContext.SaveChanges();

				Warehouse newWarehouse = new Warehouse
				{
					count = Count,
					ProductId = newProduct.Id,
				};

				_dbContext.Warehouse.Add(newWarehouse);
				_dbContext.SaveChanges();

				MessageBox.Show("Successfully added a new product!");
			}
			else
			{
				MessageBox.Show("Something went wrong! Please try again");
			}

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
