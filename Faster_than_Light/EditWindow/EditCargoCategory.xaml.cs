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
    /// Логика взаимодействия для EditCargoCategory.xaml
    /// </summary>
    public partial class EditCargoCategory : Window
    {

        CargoCategory temp = new CargoCategory();
        public EditCargoCategory(CargoCategory cargo)
        {
            InitializeComponent();
            temp = cargo;
            CommBox.Text = cargo.Comments;
            NameBox.Text = cargo.Name;
            CoeffBox.Text = cargo.TransportationCoefficient.ToString();

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            if (!Check.IsPositivNumber(CoeffBox.Text))
            {
                return;
            }


            temp.Name = NameBox.Text;
            temp.Comments = CommBox.Text;
            temp.TransportationCoefficient = Convert.ToDecimal(CoeffBox.Text);

            DatabaseControl.UpdateCargoCategory(temp);
            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetCargoCategoryForView();
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
