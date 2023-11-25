using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using WpfApp19.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp19.Services.Interfaces;
using WpfApp19.Messages;
using WpfApp19;

namespace WpfApp19.Services.Classes;
class NavigationService : INavigationService
{
	private readonly IMessenger _messenger;
	public NavigationService(IMessenger messenger)
	{
		_messenger = messenger;
	}
	public void NavigateTo<T>() where T : ViewModelBase
	{

		_messenger.Send(new NavigationMessage()
		{
		
		});
	}
}