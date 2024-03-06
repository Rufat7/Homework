using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Messages;
using Trendyol.Services.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace Trendyol.Services.Classes
{
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
                ViewModelType = App.Container.GetInstance<T>()
            });
        }
    }
}
