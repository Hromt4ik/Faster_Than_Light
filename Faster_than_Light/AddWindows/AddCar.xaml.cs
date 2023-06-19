using Faster_than_Light.classes;
using Faster_than_Light.Db_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Faster_than_Light.NavigateMethods;

namespace Faster_than_Light.AddWindows
{
    /// <summary>
    /// Логика взаимодействия для AddCar.xaml
    /// </summary>
    public partial class AddCar : Window
    {
        public AddCar()
        {
            InitializeComponent();
            BaseView.ItemsSource = DatabaseControl.GetLocationBaseForView();
            DriverView.ItemsSource = DatabaseControl.GetEmployeeForView();

            List<string> finalEnumList = new List<string>();
            Array enumArray = (Array)Enum.GetValues(typeof(StatusEnum.MachineStatuses)).Cast<StatusEnum.MachineStatuses>();
            foreach (StatusEnum.MachineStatuses element in enumArray)
            {
                finalEnumList.Add(StatusEnum.GetDescription(element));
            }

            statusComboBox.ItemsSource = finalEnumList;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

    
            DatabaseControl.AddCar(new classes.Car
            {
                VIN = VinBox.Text,
                StateNumber = StateBox.Text,
                Stamp = StampBox.Text,
                Model = ModelBox.Text,
                Mileage = Convert.ToInt32(MileageBox.Text),
                NextMaintenance = Convert.ToInt32(NextMileageBox.Text),
                Status = statusComboBox.SelectedItem.ToString(),

                LocationBase = (int)BaseView.SelectedValue,
                DriverID = Convert.ToInt32(DriverView.SelectedValue),


            });

            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetCarForView();


            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
