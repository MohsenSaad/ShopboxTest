using Microsoft.Practices.Unity;
using Prism.Services;
using Prism.Unity;
using ShopBox.Helpers;
using ShopBox.ViewModels;
using ShopBox.Views;
using Xamarin.Forms;

namespace ShopBox
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<LoginPage,LoginPageViewModel>();
            Container.RegisterTypeForNavigation<ClientPage, ClientPageViewModel>();
            Container.RegisterTypeForNavigation<BranchePage, BranchePageViewModel>();
            Container.RegisterTypeForNavigation<ProductPage, ProductPageViewModel>();
        }
    }
}
