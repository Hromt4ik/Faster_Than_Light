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
    /// Логика взаимодействия для AddPointReception.xaml
    /// </summary>
    public partial class AddPointReception : Window
    {
        public AddPointReception()
        {
            InitializeComponent();
            WareView.ItemsSource = DatabaseControl.GetWarehouseForView(); 
            positionView.ItemsSource = DatabaseControl.GetEmployeeForView();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (Check.Empty(Convert.ToString(positionView.SelectedValue)))
            {
                MessageBox.Show("Выберите Директора", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(Convert.ToString(WareView.SelectedValue)))
            {
                MessageBox.Show("Выберите Склад", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            if (Check.Empty(Convert.ToString(AdressBox.Text)))
            {
                MessageBox.Show("Введите адрес пункта выдачи", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DatabaseControl.AddPointReception(new classes.PointReception
            {
                Director = (int)positionView.SelectedValue,
                WarehouseID = (int)WareView.SelectedValue,
                Address = AdressBox.Text
            }) ;


            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetPointReceptionForView();
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
