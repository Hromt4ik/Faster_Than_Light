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
    /// Логика взаимодействия для EditPointReception.xaml
    /// </summary>
    public partial class EditPointReception : Window
    {
        PointReception temp = new PointReception();
        public EditPointReception(PointReception Point)
        {
            InitializeComponent();
            temp = Point;
            positionView.ItemsSource = DatabaseControl.GetEmployeeForView();
            positionView.SelectedIndex = Point.Director - 1;
            WareView.ItemsSource = DatabaseControl.GetWarehouseForView();
            WareView.SelectedIndex = Point.WarehouseID - 1;
            AdressBox.Text = Point.Address;

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            temp.Director = (int)positionView.SelectedValue;
            temp.WarehouseID = (int)WareView.SelectedValue;
            temp.Address = AdressBox.Text;

            DatabaseControl.UpdatePointReception(temp);
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
