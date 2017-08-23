using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using ShopBox.MappingLayer;
using ShopBox.DTO;
using ShopBox.Helpers;
using ShopBox.Models.Branches;
using ShopBox.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.ViewModels
{
   public  class BranchePageViewModel :BindableBase,INavigatedAware
    {
        #region fileds
        ServiceConnector svcconnector;
        INavigationService _navigationservice;
        IPageDialogService _displayAlert;
        DTOMapper mapper = new DTOMapper();

          #endregion

        #region constructor
        public BranchePageViewModel(INavigationService navigationService, IPageDialogService displayAlert)
        {
            _displayAlert = displayAlert;
            _navigationservice = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
                 
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            GetBranches(parameters[AppConstants.AccessToken].ToString(), parameters[AppConstants.ClientIdKey].ToString());
        }
        #endregion

        #region Privtae properties
        private bool _isIndicatorLoading = false;
        private ObservableCollection<BranchDataDTO> _branches;
        private BranchDataDTO _selectedbranchItem;
        #endregion

        #region public properties
        public ObservableCollection<BranchDataDTO>  Branches
        {
            get{ return _branches; }
            set{ SetProperty(ref _branches, value);  }
        }

        public BranchDataDTO BranchSelectedItem
        {
            get { return _selectedbranchItem; }
            set
            {
                SetProperty(ref _selectedbranchItem, value);
                var parameter = new NavigationParameters();
                parameter.Add(AppConstants.AccessToken, AccessTokenSingleton.Instance.AccessToken);
                parameter.Add(AppConstants.ClientIdKey, BranchSelectedItem.client.ToString());
                _navigationservice.NavigateAsync("ProductPage", parameter);

            }
        }

        public bool IsIndicatorLoading
        {
            get{return _isIndicatorLoading; }
            set{ SetProperty(ref _isIndicatorLoading, value);}
        }

        #endregion

        #region methods
        async void GetBranches(string accessToken,string clientId)
        {
            if (NetworkCheck.IsInternet())
            {
                IsIndicatorLoading = true;
                svcconnector = new ServiceConnector();
                var response = await svcconnector.GetAllBranches(accessToken, clientId);
                if (response.Success)
                {
                    IsIndicatorLoading = false;

                    Branches = mapper.MapBranchserviceModelToDTOModel(response.ResponseObject as BranchRootObject);

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
