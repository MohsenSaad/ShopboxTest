using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using ShopBox.MappingLayer;
using ShopBox.DTO;
using ShopBox.Helpers;
using ShopBox.Models.Products;
using ShopBox.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.ViewModels
{
   public class ProductPageViewModel : BindableBase,INavigationAware
    {

          #region fields
        ServiceConnector svcconnector;
        INavigationService _navigationservice;
        IPageDialogService _displayAlert;
        DTOMapper mapper = new DTOMapper();
#endregion

          #region Constructor
        public ProductPageViewModel(INavigationService navigationService, IPageDialogService displayAlert)
        {
            _displayAlert = displayAlert;
            _navigationservice = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
           
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            GetProducts(parameters[AppConstants.AccessToken].ToString(), parameters[AppConstants.ClientIdKey].ToString());
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
          
        }

        #endregion

          #region Privtae properties
        private bool _isIndicatorLoading = false;
        private ObservableCollection<ProductDataDTO> _products;
        #endregion

          #region Public properties
        public ObservableCollection<ProductDataDTO> Products
        {
            get {return _products; }
            set { SetProperty(ref _products, value); }
        }

        public bool IsIndicatorLoading
        {
            get { return _isIndicatorLoading; }
            set { SetProperty(ref _isIndicatorLoading, value); }
        }
        #endregion

          #region methods
        async void GetProducts(string accessToken, string clientId)
        {
            if (NetworkCheck.IsInternet())
            {
                IsIndicatorLoading = true;
                svcconnector = new ServiceConnector();
                var response = await svcconnector.GetAllProducts(accessToken, clientId);
                if (response.Success)
                {
                    IsIndicatorLoading = false;
                    Products = mapper.MapProductserviceModelToDTOModel( response.ResponseObject as ProductModel);

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
