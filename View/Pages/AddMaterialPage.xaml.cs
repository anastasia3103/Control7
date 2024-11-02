using Control7.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddMaterialPage.xaml
    /// </summary>
    public partial class AddMaterialPage : Page
    {
        public AddMaterialPage()
        {
            InitializeComponent();
            ManufacturedCmb.SelectedValuePath = "Id";
            ManufacturedCmb.DisplayMemberPath = "Name";
            ManufacturedCmb.ItemsSource = App.context.Manufacturer.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(MaterialdTb.Text))
                mes += "Введите товар\n";
            if (string.IsNullOrWhiteSpace(ManufacturedCmb.Text))
                mes += "Выберите производителя\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;

            }

            Material material = new Material()
            {
                Name = MaterialdTb.Text,
                Manufacturer = ManufacturedCmb.SelectedItem as Manufacturer
            };



            App.context.Material.Add(material);
            App.context.SaveChanges();
            MessageBox.Show("Товар добавлен");

            MaterialdTb.Text = "";
            ManufacturedCmb.Text = "";
        }
    }
}
