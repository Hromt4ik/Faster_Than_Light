﻿using Faster_than_Light.classes;
using Faster_than_Light.Db_API;
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
            CargoСategoryDataGridView.ItemsSource = DatabaseControl.GetCargoСategoryForView();
            ClientDataGridView.ItemsSource = DatabaseControl.GetClientForView();
            DriverIdentificationDataGridView.ItemsSource = DatabaseControl.GetDriverIdentificationForView();
            EmployeeDataGridView.ItemsSource = DatabaseControl.GetEmployeeForView();
            LocationBaseDataGridView.ItemsSource = DatabaseControl.GetLocationBaseForView();
            PackageDataGridView.ItemsSource = DatabaseControl.GetPackageForView();
            PointReceptionDataGridView.ItemsSource = DatabaseControl.GetPointReceptionForView();
            WarehouseDataGridView.ItemsSource = DatabaseControl.GetWarehouseForView();

        }


        private void CarDataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void CargoСategoryDataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ClientDataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
        private void DriverIdentification_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void LocationBaseDataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void PackageDataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void PointReceptionDataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void WarehouseDataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void EmployeeDataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }





        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigateMethods.MainPageClose();
            sessionData.LogOutAdmin();
            NavigateMethods.AuthorizationPageOpen();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindows.AddClient win = new AddWindows.AddClient();
            NavigateMethods.GridStorage.grid = ClientDataGridView;
            win.ShowDialog();

        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindows.AddEmployee win = new AddWindows.AddEmployee();
            NavigateMethods.GridStorage.grid = EmployeeDataGridView;
            win.ShowDialog();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //Добавь Проверку
                sessionData.LogInAdmin();
            }
        }

    }
}
