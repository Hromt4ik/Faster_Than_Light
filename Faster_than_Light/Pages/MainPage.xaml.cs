using Faster_than_Light.classes;
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
            CargoCategoryDataGridView.ItemsSource = DatabaseControl.GetCargoСategoryForView();
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

        }

        private void AddPointReceptionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddPackageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddWarehouseButton_Click(object sender, RoutedEventArgs e)
        {

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

        private void DriverIdentificationMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
