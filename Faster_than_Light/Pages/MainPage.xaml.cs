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
            CargoCategoryDataGridView.ItemsSource = DatabaseControl.GetCargoCategoryForView();
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
            sessionData.Password = null;
            sessionData.Login = null;
            NavigateMethods.AuthorizationPageOpen();
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

        private void AddDriverIdentificationButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindows.DriverIdentificationWindow win = new AddWindows.DriverIdentificationWindow();
            NavigateMethods.GridStorage.grid = DriverIdentificationDataGridView;
            win.ShowDialog();
        }

        private void AddCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindows.AddCargoCategory win = new AddWindows.AddCargoCategory();
            NavigateMethods.GridStorage.grid = CargoCategoryDataGridView;
            win.ShowDialog();
        }

        private void AddCarButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindows.AddCar win = new AddWindows.AddCar();
            NavigateMethods.GridStorage.grid = CarDataGridView;
            win.ShowDialog();
        }

        private void AddLocationButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindows.AddLocationBase win = new AddWindows.AddLocationBase();
            NavigateMethods.GridStorage.grid = LocationBaseDataGridView;
            win.ShowDialog();
        }

        private void AddPointReceptionButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindows.AddPointReception win = new AddWindows.AddPointReception();
            NavigateMethods.GridStorage.grid = PointReceptionDataGridView;
            win.ShowDialog();
        }

        private void AddPackageButton_Click(object sender, RoutedEventArgs e)
        {

            AddWindows.AddCar win = new AddWindows.AddCar();
            NavigateMethods.GridStorage.grid = CarDataGridView;
            win.ShowDialog();
        }

        private void AddWarehouseButton_Click(object sender, RoutedEventArgs e)
        {
            AddWindows.AddWarehouse win = new AddWindows.AddWarehouse();
            NavigateMethods.GridStorage.grid = WarehouseDataGridView;
            win.ShowDialog();
        }



        private void DelDriverIdentificationButton_Click(object sender, RoutedEventArgs e)
        {
            DriverIdentification temp = DriverIdentificationDataGridView.SelectedItem as DriverIdentification;

                if(temp != null) {
                DatabaseControl.DelDriverIdentification(temp);

                DriverIdentificationDataGridView.ItemsSource = null;
                DriverIdentificationDataGridView.ItemsSource = DatabaseControl.GetDriverIdentificationForView();
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void EditDriverIdentificationButton_Click(object sender, RoutedEventArgs e)
        {
            DriverIdentification temp = DriverIdentificationDataGridView.SelectedItem as DriverIdentification;

            if (temp != null)
            {
                EditWindow.EditDriver win = new EditWindow.EditDriver(temp);
                NavigateMethods.GridStorage.grid = DriverIdentificationDataGridView;
                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите элемент для изменеемя", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }



        private void LocationBaseDataEditButton_Click(object sender, RoutedEventArgs e)
        {
            //LocationBase temp = DriverIdentificationDataGridView.SelectedItem as LocationBase;

            //if (temp != null)
            //{
            //    EditWindow.EditLocationBase win = new EditWindow.EditLocationBase(temp);
            //    NavigateMethods.GridStorage.grid = EditLocationBaseDataGridView;
            //    win.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Выберите элемент для изменеемя", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            //}
        }

        private void LocationBaseRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            LocationBase temp = LocationBaseDataGridView.SelectedItem as LocationBase;

            if (temp != null)
            {
                DatabaseControl.DelLocationBase(temp);

                LocationBaseDataGridView.ItemsSource = null;
                LocationBaseDataGridView.ItemsSource = DatabaseControl.GetLocationBaseForView();
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }



        private void EditCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            CargoCategory temp = CargoCategoryDataGridView.SelectedItem as CargoCategory;

            if (temp != null)
            {
                EditWindow.EditCargoCategory win = new EditWindow.EditCargoCategory(temp);
                NavigateMethods.GridStorage.grid = CargoCategoryDataGridView;
                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите элемент для изменеемя", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RemoveCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            CargoCategory temp = CargoCategoryDataGridView.SelectedItem as CargoCategory;

            if (temp != null)
            {
                DatabaseControl.DelCargoCategory(temp);

                CargoCategoryDataGridView.ItemsSource = null;
                CargoCategoryDataGridView.ItemsSource = DatabaseControl.GetCargoCategoryForView();
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }





        private void RemoveWarehouseButton_Click(object sender, RoutedEventArgs e)
        {
            Warehouse temp = WarehouseDataGridView.SelectedItem as Warehouse;

            if (temp != null)
            {
                DatabaseControl.DelWarehouse(temp);

                WarehouseDataGridView.ItemsSource = null;
                WarehouseDataGridView.ItemsSource = DatabaseControl.GetWarehouseForView();
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void EditPackageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemovePackageButton_Click(object sender, RoutedEventArgs e)
        {
            Package temp = PackageDataGridView.SelectedItem as Package;

            if (temp != null)
            {
                DatabaseControl.DelPackage(temp);

                PackageDataGridView.ItemsSource = null;
                PackageDataGridView.ItemsSource = DatabaseControl.GetPackageForView();
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private void EditWarehouseButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditClientButton_Click(object sender, RoutedEventArgs e)
        {
            Client temp = ClientDataGridView.SelectedItem as Client;

            if (temp != null)
            {
                EditWindow.EditClient win = new EditWindow.EditClient(temp);
                NavigateMethods.GridStorage.grid = ClientDataGridView;
                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите элемент для изменеемя", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RemoveClientButton_Click(object sender, RoutedEventArgs e)
        {
            Client temp = ClientDataGridView.SelectedItem as Client;

            if (temp != null)
            {
                DatabaseControl.DelClient(temp);

                ClientDataGridView.ItemsSource = null;
                ClientDataGridView.ItemsSource = DatabaseControl.GetClientForView();
            }
            else
            {
                MessageBox.Show("Выберите элемент для удаления", "Элемент не выбран", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
