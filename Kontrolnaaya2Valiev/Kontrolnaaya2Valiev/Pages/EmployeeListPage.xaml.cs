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
using Kontrolnaaya2Valiev.Model;

namespace Kontrolnaaya2Valiev.Pages
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public partial class EmployeeListPage : Page
    {
        public EmployeeListPage()
        {
            InitializeComponent();

            DgridEmploee.ItemsSource = App.DB.Employees.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            var SelEmployee = DgridEmploee.SelectedItem as Employees;
            if (SelEmployee != null)
            {
                App.DB.Employees.Remove(SelEmployee);
                App.DB.SaveChanges();
            }
            else MessageBox.Show("Pusto");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

    }
}
