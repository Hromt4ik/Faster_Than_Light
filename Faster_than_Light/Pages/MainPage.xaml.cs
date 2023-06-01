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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            
            InitializeComponent();
            CarDataGridView.ItemsSource = DatabaseControl.GetCarForView();
            DriverIdentificationDataGridView.ItemsSource = DatabaseControl.GetDriverIdentificationForView();

        }

        private void CarDataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }



        private void editButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TabItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}