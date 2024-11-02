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
    /// Логика взаимодействия для AccountingPage.xaml
    /// </summary>
    public partial class AccountingPage : Page
    {
        public AccountingPage()
        {
            InitializeComponent();

            EmployeeCmb.SelectedValuePath = "Id";
            EmployeeCmb.DisplayMemberPath = "Name";
            EmployeeCmb.ItemsSource = App.context.Employee.ToList();

            ManufacturedCmb.SelectedValuePath = "Id";
            ManufacturedCmb.DisplayMemberPath = "Name";
            ManufacturedCmb.ItemsSource = App.context.Manufacturer.ToList();

            MaterialCmb.SelectedValuePath = "Id";
            MaterialCmb.DisplayMemberPath = "Name";
            MaterialCmb.ItemsSource = App.context.Material.ToList();


        }

        private void ManufacturedCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedManufactured = Convert.ToInt32(ManufacturedCmb.SelectedValue);
            MaterialCmb.ItemsSource = App.context.Material.Where(x => x.IdManufacturer == SelectedManufactured).ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(DateDp.Text))
                mes += "Выберите дату\n";

            if (string.IsNullOrWhiteSpace(EmployeeCmb.Text))
                mes += "Выберите сотрудника\n";

            if (string.IsNullOrWhiteSpace(ManufacturedCmb.Text))
                mes += "Выберите производителя\n";

            if (string.IsNullOrWhiteSpace(MaterialCmb.Text))
                mes += "Выберите товар\n";

            if (string.IsNullOrWhiteSpace(MarkTb.Text))
                mes += "Введите оценку\n";

            if (string.IsNullOrWhiteSpace(PriceTb.Text))
                mes += "Введите цену\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Accounting accounting = new Accounting()
            {
                DateDelivery= (DateTime)DateDp.SelectedDate,
                Employee = EmployeeCmb.SelectedItem as Employee,
                Material = MaterialCmb.SelectedItem as Material,
                Price = Convert.ToDecimal(PriceTb.Text),
                Qty = Convert.ToInt32(PriceTb.Text)
            };

            App.context.Accounting.Add(accounting);
            App.context.SaveChanges();
            MessageBox.Show("Запись добавлена");

            EmployeeCmb.Text = "";
            ManufacturedCmb.Text = "";
            MaterialCmb.Text = "";
            MarkTb.Text = "";
            PriceTb.Text = "";
            DateDp.Text = "";

        }
    }
}
