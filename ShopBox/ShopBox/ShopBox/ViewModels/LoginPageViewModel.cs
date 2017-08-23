using Newtonsoft.Json;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using ShopBox.Helpers;
using ShopBox.Models;
using ShopBox.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopBox.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {

        #region fields
        ServiceConnector svcconnector;
        INavigationService _navigationservice;
        IPageDialogService _displayAlert;

        #endregion

        #region constructor
        public LoginPageViewModel(INavigationService navigationService, IPageDialogService displayAlert)
        {
            _displayAlert = displayAlert;
            _navigationservice = navigationService;
             logincommand = new DelegateCommand(Login,() => CanLogin());
        }
#endregion

        #region Private properties

        private string _username;
        private string _password;
        private bool isValidMessageVisisble = true;
        private string validationMessage = string.Empty;

        private bool _isIndicatorLoading = false;


        #endregion

        #region public properties

        public bool IsIndicatorLoading
        {
            get { return _isIndicatorLoading; }
            set{  SetProperty(ref _isIndicatorLoading, value);}
        }

        public string UserName
        {
            get { return _username; }
            set { SetProperty(ref _username, value); LoginCommand.RaiseCanExecuteChanged(); }
        }


        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); LoginCommand.RaiseCanExecuteChanged(); }
        }

        public bool IsValidMessageVisisble
        {
            get { return isValidMessageVisisble; }
            set { SetProperty(ref isValidMessageVisisble, value); }
        }

        public string ValidationMessage
        {
            get { return validationMessage; }
            set
            {
                SetProperty(ref validationMessage, value);

                if (string.IsNullOrEmpty(value))
                {
                    IsValidMessageVisisble = false;
                }
                else
                {
                    IsValidMessageVisisble = true;
                }

            }
        }


        #endregion

        #region Commands

        private DelegateCommand logincommand;
        public DelegateCommand LoginCommand
        {
            get {  return this.logincommand; }
        }
        #endregion

        #region Methods
        public bool CanLogin()
        {
            if (string.IsNullOrEmpty(UserName))
            {
                ValidationMessage = "Please enter your username";
                return false;
            }
            if (string.IsNullOrEmpty(Password))
            {
                ValidationMessage = "Please enter your password";
                return false;
            }
            ValidationMessage = string.Empty;
            return true;
        }
        async void Login()
        {
            if (NetworkCheck.IsInternet())
            {
                IsIndicatorLoading = true;
                svcconnector = new ServiceConnector();
                var response = await svcconnector.Login(UserName, Password);
                if (response.Success)
                {
                    IsIndicatorLoading = false;
                    var result = response.ResponseObject as UserAccount;
                    //save the access token in singleton object
                    AccessTokenSingleton.Instance.AccessToken = result.accessToken;
                    var parameter = new NavigationParameters();
                    parameter.Add(AppConstants.AccessToken, result.accessToken);
                    await _navigationservice.NavigateAsync("ClientPage", parameter);
                }
                else
                {
                    IsIndicatorLoading = false;
                    await _displayAlert.DisplayAlertAsync(response.ErrorObject.error.name, response.ErrorObject.error.message, "ok");
                }
            }
            else
            {
                await _displayAlert.DisplayAlertAsync(AppConstants.NoInternetConnection, String.Empty, "ok");
            }
           
        }

        #endregion
    }
}
