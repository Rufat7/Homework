using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Trendyol.Messages;
using Trendyol.Models;
using Trendyol.Services.Classes;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels;
 class ProfileViewModel : ViewModelBase
{
    private readonly IMessenger _messenger;
    private readonly INavigationService _navigationService;
    private readonly IDataService _dataService;
    public DBContext _dbContext;
    public User _currentUser;
    public Order _selectedOrder;
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

    public User CurrentUser
    {
        get => _currentUser;
        set
        {
            Set(ref _currentUser, value);
        }
    }


    public ProfileViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger,DBContext dBContext)
    {
        _navigationService = navigationService;
        _dataService = dataService;
        _messenger = messenger;
        _dbContext = dBContext;
        Orders = new ObservableCollection<Order>(_dbContext.Orders.Include(x => x.Users).Include(x => x.Products).ToList());

        _messenger.Register<DataMessage>(this, message =>
        {
            if (message.Data as User != null)
            {
             CurrentUser = message.Data as User;

            }
        });
    }



    public RelayCommand ToGoodsPage
    {
        get => new(
            () =>
            {
                _navigationService.NavigateTo<GoodsPageViewModel>();
            });
    }












}

