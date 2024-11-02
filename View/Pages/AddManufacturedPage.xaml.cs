﻿using Control7.Model;
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
    /// Логика взаимодействия для AddManufacturedPage.xaml
    /// </summary>
    public partial class AddManufacturedPage : Page
    {
        public AddManufacturedPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(ManufacturedTb.Text))
                mes += "Введите производителя\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Manufacturer manufactured = new Manufacturer()
            {
                Name = ManufacturedTb.Text
            };

            App.context.Manufacturer.Add(manufactured);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            ManufacturedTb.Text = "";

        }
    }
}
