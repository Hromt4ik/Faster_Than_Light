using Faster_than_Light.classes;
using Faster_than_Light.Db_API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace Faster_than_Light.EditWindow
{
    /// <summary>
    /// Логика взаимодействия для EditCar.xaml
    /// </summary>
    public partial class EditCar : Window
    {

        Car temp = new Car();
        public EditCar(Car car)
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


            temp = car;
            VinBox.Text = car.VIN;
            StateBox.Text = car.StateNumber;
            StampBox.Text = car.Stamp;
            ModelBox.Text = car.Model;
            MileageBox.Text = Convert.ToString(car.Mileage);
            NextMileageBox.Text = Convert.ToString(car.NextMaintenance);
            statusComboBox.SelectedItem = car.Status;

            BaseView.SelectedIndex = car.LocationBase - 1;
            DriverView.SelectedIndex = (int)(car.DriverID - 1);


        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {




            temp.VIN = VinBox.Text;
            temp.StateNumber = StateBox.Text;
            temp.Stamp = StampBox.Text;
            temp.Model = ModelBox.Text;
            temp.Mileage = Convert.ToInt32(MileageBox.Text);
            temp.NextMaintenance = Convert.ToInt32(NextMileageBox.Text);
            temp.Status = statusComboBox.SelectedItem.ToString();

            temp.LocationBase = Convert.ToInt32(BaseView.SelectedValue);
            temp.DriverID = Convert.ToInt32(DriverView.SelectedValue);


            DatabaseControl.UpdateCar(temp);
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
