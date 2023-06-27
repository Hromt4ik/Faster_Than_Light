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
    /// Логика взаимодействия для EditLocationBase.xaml
    /// </summary>
    public partial class EditLocationBase : Window
    {

        LocationBase temp = new LocationBase();
        public EditLocationBase(LocationBase Location)
        {
            InitializeComponent();
            temp = Location;
            EmployeeID.ItemsSource = DatabaseControl.GetEmployeeForView();
            EmployeeID.SelectedValue = Location.EmployeeEntity.EmployeeID;
            AdressBox.Text = temp.Address;
            RegionBox.Text = temp.Region;
            NumberBox.Text = Convert.ToString(temp.NumberSeats);
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
            if (Check.Empty(Convert.ToString(EmployeeID.SelectedValue)))
            {
                MessageBox.Show("Выберите Директора", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (!Check.IsPositivNumber(NumberBox.Text))
            {
                return;
            }

            temp.Address = AdressBox.Text;
            temp.Region = RegionBox.Text;
            temp.Director = (int)EmployeeID.SelectedValue;
            temp.NumberSeats = Convert.ToInt32(NumberBox.Text);



            DatabaseControl.UpdateLocationBase(temp);
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
