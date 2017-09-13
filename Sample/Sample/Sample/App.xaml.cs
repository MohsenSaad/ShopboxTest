using Microsoft.Practices.Unity;
using Prism.Unity;
using Sample.Helpers;
using Sample.ViewModels;
using Sample.Views;
using Xamarin.Forms;

namespace Sample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("CustomMasterDetailPagexaml/NavigationPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<CustomMasterDetailPagexaml,CustomMasterDetailPagexamlViewModel>();
            Container.RegisterTypeForNavigation<Customers, CustomersViewModel>();

            this.Container.RegisterType<ISQLiteDataAccess, SQLiteDataAccess>(new ContainerControlledLifetimeManager());
        }
    }
}
