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
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            


            
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
