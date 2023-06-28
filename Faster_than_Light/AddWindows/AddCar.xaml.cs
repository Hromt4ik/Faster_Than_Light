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

            if (!Check.IsPositivNumber(MileageBox.Text))
            {
                return;
            }

            if (!Check.IsPositivNumber(NextMileageBox.Text))
            {
                return;
            }

            if (!Check.NumberCar(StateBox.Text))
            {

                MessageBox.Show("Введите номер формата: А000АА00 \n или А000АА000", "Неправильный номер", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!(DatabaseControl.isVINUnique(VinBox.Text)))
            {
                MessageBox.Show("VIN номер не уникален", "Ошибка уникальности", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            DatabaseControl.AddCar(new classes.Car
            {
                VIN = VinBox.Text,
                StateNumber = StateBox.Text,
                Stamp = StampBox.Text,
                Model = ModelBox.Text,
                Mileage = Convert.ToInt32(MileageBox.Text),
                NextMaintenance = Convert.ToInt32(NextMileageBox.Text),
                Status = statusComboBox.SelectedItem.ToString(),

                LocationBase = Convert.ToInt32(BaseView.SelectedValue),
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
