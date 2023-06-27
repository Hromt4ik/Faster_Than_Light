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
    /// Логика взаимодействия для EditWarehouse.xaml
    /// </summary>
    public partial class EditWarehouse : Window
    {
        Warehouse temp = new Warehouse();
        public EditWarehouse(Warehouse warehouse)
        {
            InitializeComponent();
            temp = warehouse;
            EmployeeID.ItemsSource = DatabaseControl.GetEmployeeForView();
            EmployeeID.SelectedValue = warehouse.EmployeeEntity.EmployeeID;
            addresBox.Text = warehouse.Address;
            RegionBox.Text = warehouse.Region;


        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (Check.Empty(addresBox.Text))
            {
                MessageBox.Show("Введите Адрес", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
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



            temp.Address = addresBox.Text;
            temp.Region = RegionBox.Text;
            temp.Director = Convert.ToInt32(EmployeeID.SelectedValue);

            DatabaseControl.UpdateWarehouse(temp);
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
