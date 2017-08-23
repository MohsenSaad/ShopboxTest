using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBox.DTO
{
    public class BranchDataDTO: BindableBase
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

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

        private int _client;
        public int client
        {
            get { return _client; }
            set { SetProperty(ref _client, value); }
        }

    }
}
