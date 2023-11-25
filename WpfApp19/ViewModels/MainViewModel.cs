using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp19.Messages;

namespace WpfApp19.ViewModels
{
	class MainViewModel : ViewModelBase
	{
		private readonly IMessenger _messenger;

		private ViewModelBase _currentView;
		public ViewModelBase CurrentView
		{
			get => _currentView;
			set
			{
				Set(ref _currentView, value); // Функция Set() автоматически вызывает PropertyChanged.
			}
		}

		public MainViewModel(IMessenger messenger)
		{
			_messenger = messenger;
			CurrentView = App.Container.GetInstance<InfoViewModel>();

			_messenger.Register<NavigationMessage>(this, message =>
			{
				CurrentView = message.ViewModelType;
			});
		}

	}
}
