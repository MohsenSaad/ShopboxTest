using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Sample.Helpers;
using Sample.SQLiteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ViewModels
{
   public class CustomersViewModel :BindableBase
    {
        INavigationService _navigationService;
        ISQLiteDataAccess _dataAccess;
       // public DelegateCommand GoToDetailsCommand { get; set; }
        public CustomersViewModel(INavigationService navigationService, ISQLiteDataAccess dataAccess)
        {
            _navigationService = navigationService;
            this._dataAccess = dataAccess;
            //  GoToDetailsCommand = new DelegateCommand(Navigate);
            AddEmployData();
            GetEmployeData();
        }

        public void Navigate()
        {
            _navigationService.NavigateAsync("CustomersDetails");
        }

        private IEnumerable<Employe> _employe;

        private Employe _selectedEmploye;
        public Employe SelectedEmploye
        {
            get { return this._selectedEmploye; }
            set { SetProperty(ref _selectedEmploye, value); }
        }

        public IEnumerable<Employe> Employe
        {
            get { return this._employe; }
            set { SetProperty(ref _employe, value); }
        }

        public void GetEmployeData()
        {
            Employe = this._dataAccess.GetAll();
        }


        public void AddEmployData()
        {
            this._dataAccess.Insert(new Employe { Id = 1, Email = "mohsen.mahmoud@hpe.com", Name = "Mohsen Mahmoud" });
        }
    }
}
