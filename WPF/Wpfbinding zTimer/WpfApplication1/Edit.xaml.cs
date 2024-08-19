using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApplication1.model;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window, INotifyPropertyChanged
    {
        User u = new User();

        struct _user
        {
            public int ID { get; set; }
            public string login { get; set; }
            public string fio { get; set; }
            public string description { get; set; }
        }


        List<_user> UserList = new List<_user>();

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public int count { get { return UserList.Count; } set { } }

        public Edit(MainWindow main)

        {
            
            InitializeComponent();
            DataContext = u;

            nameBox.SetBinding(TextBox.TextProperty,
                new Binding("login")
                {
                    Mode = BindingMode.TwoWay,
                    Source = u
                });
            fioBox.SetBinding(TextBox.TextProperty,
                new Binding("fio")
                {
                    Mode = BindingMode.TwoWay,
                    Source = u
                });

            descriptionBox.SetBinding(TextBox.TextProperty,
                new Binding("description")
                {
                    Mode = BindingMode.TwoWay,
                    Source = u
                });

            textBox.SetBinding(TextBox.TextProperty,
                new Binding("count")
                {
                    Mode = BindingMode.TwoWay,
                    Source = this
                });


            string text = null;
            foreach (_user aPart in UserList)
            {
                text += aPart.ID + "|" + aPart.login + "\n";
            }
            main.RTBedit(text);


            System.Timers.Timer t = new System.Timers.Timer(100);
            t.AutoReset = true;
            t.Elapsed += T_Elapsed;
            t.Start();


        }

 

        private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            button_Click(this, null);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            u.login = Guid.NewGuid().ToString();
            u.fio = Guid.NewGuid().ToString();
            u.description = Guid.NewGuid().ToString();

            _user US = new _user();

            US.ID = 123;
            US.login = u.login;
            US.fio = u.fio;
            US.description = u.description;
            UserList.Add(US);

            RaisePropertyChanged("count");
            

        }

        private void textBox_TextChanged (object sender, TextChangedEventArgs e)
        {

        }
    }
}
