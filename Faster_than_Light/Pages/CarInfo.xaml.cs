﻿using Faster_than_Light.Db_API;
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

namespace Faster_than_Light.Pages
{
    /// <summary>
    /// Логика взаимодействия для CarInfo.xaml
    /// </summary>
    public partial class CarInfo : Page
    {
        public CarInfo()
        {
            InitializeComponent();
            CarDataGridView.ItemsSource = DatabaseControl.GetCarForView();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }



        private void editButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
