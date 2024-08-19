using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.model
{
    public class User : modelBase
    {
        string _login, _fio, _description;
        public string login {
            get { return _login; }
            set { _login = value; RaisePropertyChanged("login"); }
        }
        public string fio
        {
            get { return _fio; }
            set { _fio = value; RaisePropertyChanged("fio"); }
        }
        public string description
        {
            get { return _description; }
            set { _description = value; RaisePropertyChanged("description"); }
        }
    }
}
