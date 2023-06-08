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
    /// Логика взаимодействия для DriverIdentificationWindow.xaml
    /// </summary>
    public partial class DriverIdentificationWindow : Window
    {
        public DriverIdentificationWindow()
        {
            InitializeComponent();
        }



        private void addButton_Click(object sender, RoutedEventArgs e)
        {



            if(!((bool)BChecked.IsChecked || (bool)BE.IsChecked || (bool)CChecked.IsChecked || (bool)CE.IsChecked))
            {
                MessageBox.Show("Выберите хотя бы 1 категорию", "Категории не выбраны", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DatabaseControl.AddDriverIdentification(new classes.DriverIdentification
            {
                DriverLicense = DriverLicense.Text,
                EmployeeID = Convert.ToInt32(EmployeeID.Text),
                DateReceipt = DateTime.SpecifyKind(Convert.ToDateTime(DateReceipt.SelectedDate.Value), DateTimeKind.Utc),
                TerminationDate = DateTime.SpecifyKind(Convert.ToDateTime(TerminationDate.SelectedDate.Value), DateTimeKind.Utc),
                B = (bool)BChecked.IsChecked,
                BE = (bool)BE.IsChecked,
                C = (bool)CChecked.IsChecked,
                CE = (bool)CE.IsChecked,

            }) ;


            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetDriverIdentificationForView();
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
