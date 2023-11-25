using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp19.Services.Interfaces;

namespace WpfApp19.ViewModels
{
    class InfoViewModel : ViewModelBase
    {
		private readonly INavigationService _navigationService;


		public RelayCommand<Button> Add
		{


			get => new(button =>
			{

				
				_navigationService.NavigateTo<>;
			});
		}

	}
}
