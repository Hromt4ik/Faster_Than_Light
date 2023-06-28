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

            BaseView.SelectedValue = car.LocationBaseEntity.LocationBaseID;
            DriverView.SelectedValue = car.EmployeeEntity.EmployeeID;


        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (Check.Empty(VinBox.Text))
            {
                MessageBox.Show("Введите VIN", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(StateBox.Text))
            {
                MessageBox.Show("Введите Гос. номер", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(VinBox.Text))
            {
                MessageBox.Show("Введите VIN", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(StampBox.Text))
            {
                MessageBox.Show("Введите марку", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(ModelBox.Text))
            {
                MessageBox.Show("Введите модель", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(MileageBox.Text))
            {
                MessageBox.Show("Введите пробег", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(NextMileageBox.Text))
            {
                MessageBox.Show("Введите пробег для прохождения следующего ТО", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!Check.IsPositivNumber(MileageBox.Text))
            {
                return;
            }

            if (!Check.IsPositivNumber(NextMileageBox.Text))
            {
                return;
            }

            if (Check.Empty(statusComboBox.Text))
            {
                MessageBox.Show("Выберите статус машины", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(BaseView.Text))
            {
                MessageBox.Show("Выберите место базирования", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(DriverView.Text))
            {
                MessageBox.Show("Выберите водителя", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!Check.NumberCar(StateBox.Text))
            {

                MessageBox.Show("Введите номер формата: А000АА00 \n или А000АА000", "Неправильный номер", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            if (!(DatabaseControl.isVINUnique(VinBox.Text)) && VinBox.Text != temp.VIN)
            {
                MessageBox.Show("VIN номер не уникален", "Ошибка уникальности", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

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
