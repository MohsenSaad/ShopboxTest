using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using ShopBox.MappingLayer;
using ShopBox.DTO;
using ShopBox.Helpers;
using ShopBox.Models.Clients;
using ShopBox.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.ViewModels
{
   public class ClientPageViewModel :BindableBase, INavigationAware
    {
        #region fields
        ServiceConnector svcconnector;
        INavigationService _navigationservice;
        IPageDialogService _displayAlert;
        DTOMapper mapper = new DTOMapper();
        object token;
        #endregion
      

        #region constructor
        public ClientPageViewModel(INavigationService navigationService, IPageDialogService displayAlert)
        {
            _displayAlert = displayAlert;
            _navigationservice = navigationService;
           

        }
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
           
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            token = parameters[AppConstants.AccessToken];
            GetClients(token.ToString());

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
           
        }

        #endregion

        #region private properties
        private bool _isIndicatorLoading = false;
        private ObservableCollection<ClientDataDTO> clients;
        private ClientDataDTO SelectedclientItem;
        #endregion

        #region public properties
        public ObservableCollection< ClientDataDTO> Clients
        {
            get{  return clients; }
            set{ SetProperty(ref clients, value); }
        }

        public ClientDataDTO SelectedClientItem
        {
            get { return SelectedclientItem; }
            set {
                SetProperty(ref SelectedclientItem, value);
                var parameter = new NavigationParameters();
                parameter.Add(AppConstants.AccessToken, AccessTokenSingleton.Instance.AccessToken);
                parameter.Add(AppConstants.ClientIdKey, SelectedclientItem.uid.ToString());
                _navigationservice.NavigateAsync("BranchePage", parameter);
            }
        }

        public bool IsIndicatorLoading
        {
            get { return _isIndicatorLoading; }
            set {SetProperty(ref _isIndicatorLoading, value); }
        }

        #endregion

        #region methods
        async void GetClients( string accessToken)
        {
            if (NetworkCheck.IsInternet())
            {
                IsIndicatorLoading = true;
            svcconnector = new ServiceConnector();
            var response = await svcconnector.GetAllStors(accessToken);
            if (response.Success)
            {
                IsIndicatorLoading = false;
                Clients = mapper.MapClientserviceModelToDTOModel( response.ResponseObject as ClientModel);
               
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
