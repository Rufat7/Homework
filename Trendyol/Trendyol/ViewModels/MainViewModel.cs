using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using System;
using Trendyol.Messages;

namespace Trendyol.ViewModels
{
	class MainViewModel : ViewModelBase
	{
		private readonly IMessenger _messenger;

		private ViewModelBase _currentView;
		public ViewModelBase CurrentView
		{
			get => _currentView;
			set => Set(ref _currentView, value);
		}

		public MainViewModel(IMessenger messenger)
		{
			_messenger = messenger;
			CurrentView = App.Container.GetInstance<RegistrationViewModel>();

			_messenger.Register<NavigationMessage>(this, message =>
			{
				CurrentView = message.ViewModelType;
			});
		}
	}
}
