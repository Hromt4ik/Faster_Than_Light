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
using System.Windows.Shapes;
using static Faster_than_Light.NavigateMethods;

namespace Faster_than_Light.AddWindows
{
    /// <summary>
    /// Логика взаимодействия для AddLocationBase.xaml
    /// </summary>
    public partial class AddLocationBase : Window
    {
        public AddLocationBase()
        {
            InitializeComponent();
            positionView.ItemsSource = DatabaseControl.GetEmployeeForView();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (Check.Empty(AdressBox.Text))
            {
                MessageBox.Show("Введите Адрес", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Check.Empty(NumberBox.Text))
            {
                MessageBox.Show("Введите количество мест", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Check.Empty(RegionBox.Text))
            {
                MessageBox.Show("Введите Регион", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Check.Empty(Convert.ToString(positionView.SelectedValue)))
            {
                MessageBox.Show("Выберите Директора", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (!Check.IsPositivNumber(NumberBox.Text))
            {
                return;
            }


            DatabaseControl.AddLocationBase(new classes.LocationBase
            {
                Director = (int)positionView.SelectedValue,
                Address = AdressBox.Text,
                NumberSeats = Convert.ToInt32(NumberBox.Text),
                Region = RegionBox.Text
            }); ;

            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetLocationBaseForView();

            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
