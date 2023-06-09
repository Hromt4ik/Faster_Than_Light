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
using System.Windows.Shapes;
using static Faster_than_Light.NavigateMethods;

namespace Faster_than_Light.EditWindow
{
    /// <summary>
    /// Логика взаимодействия для EditDriver.xaml
    /// </summary>
    public partial class EditDriver : Window
    {
        DriverIdentification temp = new DriverIdentification();
        public EditDriver(DriverIdentification Driver)
        {
            InitializeComponent();
            temp = Driver;
            DriverView.ItemsSource = DatabaseControl.GetEmployeeForView();
            DriverView.SelectedIndex = Driver.EmployeeID - 1;
            DriverLicense.Text = Driver.DriverLicense;
            DateReceipt.SelectedDate = Driver.DateReceipt;
            TerminationDate.SelectedDate = Driver.TerminationDate;
            BChecked.IsChecked = (bool)Driver.B;
            BE.IsChecked = (bool)Driver.BE;
            CChecked.IsChecked = (bool)Driver.C;
            CE.IsChecked = (bool)Driver.CE;



        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            if (!((bool)BChecked.IsChecked || (bool)BE.IsChecked || (bool)CChecked.IsChecked || (bool)CE.IsChecked))
            {
                MessageBox.Show("Выберите хотя бы 1 категорию", "Категории не выбраны", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            temp.DriverLicense = DriverLicense.Text;
            temp.EmployeeID = (int)DriverView.SelectedValue;
            temp.DateReceipt = DateTime.SpecifyKind(Convert.ToDateTime(DateReceipt.SelectedDate.Value), DateTimeKind.Utc);
            temp.TerminationDate = DateTime.SpecifyKind(Convert.ToDateTime(TerminationDate.SelectedDate.Value), DateTimeKind.Utc);
            temp.B = (bool)BChecked.IsChecked;
            temp.BE = (bool)BE.IsChecked;
            temp.C = (bool)CChecked.IsChecked;
            temp.CE = (bool)CE.IsChecked;

            DatabaseControl.UpdateDriverIdentification(temp);
            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetDriverIdentificationForView();
            this.Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
