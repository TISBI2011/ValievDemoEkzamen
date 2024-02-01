using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kontrolnaaya2Valiev.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            string Login = TBLogin.Text;
            string Parol = TBPassword.Text;


            var loggedEmployee = App.DB.Employees.FirstOrDefault(x => x.login == Login && x.parol == Parol);
            
            if (loggedEmployee == null)
            {
                MessageBox.Show ("pole avtorizacii pustoe");
                return;
            }

            App.LoggedEmployee = loggedEmployee;
            NavigationService.Navigate(new EmployeeListPage());
        }

        private void BRegister_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
