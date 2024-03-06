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
using System.Windows.Controls;
using Trendyol.Models;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels;

class SuperAdminMenuViewModel : ViewModelBase
{
    private readonly IMessenger _messenger;
    private readonly INavigationService _navigationService;
    private readonly IDataService _dataService;
    public DBContext _dbContext;
    public User _selectedUser;
    public ObservableCollection<User> users;



    public ObservableCollection<User> Users
    {
        get { return users; }
        set { Set(ref users, value); }
    }
    public User SelectedUser
    {
        get { return _selectedUser; }
        set { Set(ref _selectedUser, value); }
    }


    public SuperAdminMenuViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger,DBContext dBContext)
    {
        _navigationService = navigationService;
        _dataService = dataService;
        _messenger = messenger;
        _dbContext = dBContext;
        Users = new ObservableCollection<User>(_dbContext.Users.ToList());
    }


    public RelayCommand Exit
    {
        get => new(
            () =>
            {
                _navigationService.NavigateTo<LoglnViewModel>();
            });
    }

    public RelayCommand ToAdmin
    {
        get => new(
            () =>
            {
                if (SelectedUser != null)
                {
                    if (SelectedUser.Membership == "User")
                    {
                        SelectedUser.Membership = "Admin";
                        _dbContext.SaveChanges();
                        MessageBox.Show("Sucsessfully switched to admin");
                    }
                    else if (SelectedUser.Membership == "SuperAdmin")
                    {
                        MessageBox.Show("You can't change the role of SuperAdmin");
                    }
                    else
                        MessageBox.Show("An error was occured.This member already is admin");
                }
                else
                    MessageBox.Show("Please select user");
            });
    }
    public RelayCommand ToUser
    {
        get => new(
            () =>
            {
                if (SelectedUser != null)
                {
                    if (SelectedUser.Membership == "Admin")
                    {
                        SelectedUser.Membership = "User";
                        _dbContext.SaveChanges();
                        MessageBox.Show("Sucsessfully switched to user");
                    }
                    else if (SelectedUser.Membership == "SuperAdmin")
                    {
                        MessageBox.Show("You can't change the role of SuperAdmin");
                    }
                    else
                        MessageBox.Show("An error was occured.This member already is user");
                }
                else
                    MessageBox.Show("Please select user");

            });
    
        
    } 
    
}


