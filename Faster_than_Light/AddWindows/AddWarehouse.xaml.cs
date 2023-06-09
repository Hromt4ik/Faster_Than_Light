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
    /// Логика взаимодействия для AddWarehouse.xaml
    /// </summary>
    public partial class AddWarehouse : Window
    {
        public AddWarehouse()
        {
            InitializeComponent();
            positionView.ItemsSource = DatabaseControl.GetEmployeeForView();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            if (Check.Empty(Convert.ToString(positionView.SelectedValue)))
            {
                MessageBox.Show("Выберите Директора", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(Convert.ToString(RegionBox.Text)))
            {
                MessageBox.Show("Заполните Регион", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            if (Check.Empty(Convert.ToString(adresBox.Text)))
            {
                MessageBox.Show("Введите адрес склада", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            DatabaseControl.AddWarehouse(new classes.Warehouse
            {
                Address = adresBox.Text,
                Region = RegionBox.Text,
                Director = (int)positionView.SelectedValue
            });

            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetWarehouseForView();

            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
