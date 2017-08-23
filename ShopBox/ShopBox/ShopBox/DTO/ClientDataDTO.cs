using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.DTO
{
   public class ClientDataDTO :BindableBase
    {
        private int _uid;
        public int uid
        {
            get { return _uid; }
            set { SetProperty(ref _uid, value); }
        }
        private object _phone;
        public object phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }
        private string _name;
        public string name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _description;
        public string description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }
    }
}
