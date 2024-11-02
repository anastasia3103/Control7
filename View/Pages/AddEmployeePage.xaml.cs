using Control7.Model;
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
    /// Логика взаимодействия для AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        public AddEmployeePage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

            string mes = "";
            if (string.IsNullOrWhiteSpace(EmployeeTb.Text))
                mes += "Введите сотрудника\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Employee employee = new Employee()
            {
                Name = EmployeeTb.Text
            };

            App.context.Employee.Add(employee);
            App.context.SaveChanges();
            MessageBox.Show("Сотрудник добавлен");

            EmployeeTb.Text = "";
        }
    }
}
