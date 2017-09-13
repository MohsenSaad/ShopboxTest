using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ViewModels
{
   public class CustomMasterDetailPagexamlViewModel :BindableBase
    {

        INavigationService _navigationService;
        public DelegateCommand NavigateCommand { get; set; }
        public CustomMasterDetailPagexamlViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand(Navigate);
        }
        public void Navigate()
        {
            _navigationService.NavigateAsync("Customers");
        }
    }
}
