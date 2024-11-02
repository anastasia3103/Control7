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

namespace Control7.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void ReportPeriodHL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReportEmpoyeeHL_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Acounting_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AccountingPage());
            
        }

        private void AddManufacturedHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddManufacturedPage());

        }

        private void AddMaterialHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddMaterialPage());

        }

        private void AddEmployeeHL_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.AddEmployeePage());
        }
    }
}
