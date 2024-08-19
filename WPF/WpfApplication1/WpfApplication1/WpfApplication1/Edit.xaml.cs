using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
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
    public partial class Edit : Window
    {
        User u = new User();
        public Edit()
        {
            InitializeComponent();
            DataContext = u;
            //nameBox.SetBinding(TextBox.TextProperty, 
            //    new Binding("login") {
            //        Mode = BindingMode.TwoWay,
            //        Source = u
            //    });
            //fioBox.SetBinding(TextBox.TextProperty,
            //    new Binding("fio")
            //    {
            //        Mode = BindingMode.TwoWay,
            //        Source = u
            //    });
            //descriptionBox.SetBinding(TextBox.TextProperty,
            //    new Binding("description")
            //    {
            //        Mode = BindingMode.TwoWay,
            //        Source = u
            //    });
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\model\Base.mdf;Integrated Security=True"))
            {
                connection.Open();
                string sql = "SELECT * FROM TestTable";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int Id = reader.GetInt32(0);
                    string Name = reader.GetString(1);
                    int Age = reader.GetInt32(2);
                    //byte[] data = (byte[])reader.GetValue(3);
                }
            }

        }
    }
}
