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
    /// Логика взаимодействия для AddCargoCategory.xaml
    /// </summary>
    public partial class AddCargoCategory : Window
    {
        public AddCargoCategory()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            if (Check.Empty(NameBox.Text))
            {
                MessageBox.Show("Введите Имя", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(CoeffBox.Text))
            {
                MessageBox.Show("Введите Коэфициент", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!(Check.IsPositivNumber(CoeffBox.Text)))
            {
                return;
            }


            if (Check.Empty(CommBox.Text))
            {
                MessageBox.Show("Введите Комментарий", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DatabaseControl.AddCargoCategory(new classes.CargoCategory
            {
                Name = NameBox.Text,
                TransportationCoefficient = Convert.ToDecimal(CoeffBox.Text),
                Comments = CommBox.Text
            }) ;

            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetCargoСategoryForView();
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
