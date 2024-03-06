using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Trendyol.Services.Classes;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
    class LogInViewModel : ViewModelBase
    {

        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        public DBContext _dbContext = new();
        LogInService _loginService = new();
        VerificationService _verificationService = new();
        public string _emailText = "";
        public string _passwordText = "";

        public string Email
        {
            get { return _emailText; }
            set { Set(ref _emailText, value); }
        }
        public string Password
        {
            get { return _passwordText; }
            set { Set(ref _passwordText, value); }
        }

        public LogInViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;

        }

        public RelayCommand LogIn
        {
            get => new(
            () =>
            {
                var currentUser = _dbContext.Users.ToList().First(x => x.Email == Email);
                if (Email == null || Password == null)
                {
                    MessageBox.Show("Please fill the fields!");
                    Email = "";
                    Password = "";
                }
                else if (_loginService.IsEmail(_emailText, _dbContext) && _loginService.PasswordIsTrue(_passwordText, _dbContext,currentUser) && currentUser.Membership == "User")
                {
                    MessageBox.Show("Successfully Loged in!");
                    _dataService.SendData(currentUser);
                    _navigationService.NavigateTo<GoodsPageViewModel>();
                    Email = "";
                    Password = "";

                }
                else if (_loginService.IsEmail(_emailText, _dbContext) && _loginService.PasswordIsTrue(_passwordText, _dbContext, currentUser) && currentUser.Membership == "SuperAdmin")
                {
                    MessageBox.Show("Successfully Loged in!");
                    _navigationService.NavigateTo<SuperAdminMenuViewModel>();
                    Email = "";
                    Password = "";
                }
                else if (_loginService.IsEmail(_emailText, _dbContext) && _loginService.PasswordIsTrue(_passwordText, _dbContext, currentUser) && currentUser.Membership == "Admin")
                {
                    MessageBox.Show("Successfully Loged in!");
                    _navigationService.NavigateTo<AdminMenuViewModel>();
                    Email = "";
                    Password = "";
                }
                else
                {
                    MessageBox.Show("Something wet wrong!Please try again");
                    Email = "";
                    Password = "";

                }
                //else if (_verificationService.IsEmailameValid(Email) && _verificationService.IsPasswordValid(Password) && !_loginService.IsEmail(_emailText, _dbContext))
                //{
                //    MessageBox.Show("Email is not found");
                //}
                //else if (_verificationService.IsEmailameValid(Email) && _verificationService.IsPasswordValid(Password) && !_loginService.PasswordIsTrue(_passwordText, _dbContext))
                //{
                //    MessageBox.Show("Wrong Password!");
                //}
                //else if (!_verificationService.IsEmailameValid(Email) && !_verificationService.IsPasswordValid(Password) )
                //{
                //    MessageBox.Show("Wrong Email and Password!Password must contain at least 8 characters and you can use only letters and numbers!Please try again.");
                //}
                //else if (!_verificationService.IsPasswordValid(Password))
                //{
                //    MessageBox.Show("Wrong Password syntax!Password must contain at least 8 characters and you can use only letters and numbers!Please try again.");
                //}
                //else if (!_verificationService.IsEmailameValid(Email))
                //{
                //    MessageBox.Show("Wrong Email syntax!Please try again.");
                //}



            });


        }


    }
}
