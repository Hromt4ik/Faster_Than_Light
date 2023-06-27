using Faster_than_Light.classes;
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

namespace Faster_than_Light.EditWindow
{
    /// <summary>
    /// Логика взаимодействия для EditPackage.xaml
    /// </summary>
    public partial class EditPackage : Window
    {

        Package temp = new Package();
        public EditPackage(Package package)
        {
            InitializeComponent();
            temp = package;

            List<string> finalEnumList = new List<string>();
            Array enumArray = (Array)Enum.GetValues(typeof(StatusEnum.PackageStatuses)).Cast<StatusEnum.PackageStatuses>();
            foreach (StatusEnum.PackageStatuses element in enumArray)
            {
                finalEnumList.Add(StatusEnum.GetDescription(element));
            }

            statusComboBox.ItemsSource = finalEnumList;

            List<string> finalPackageEnumList = new List<string>();
            Array enumPackageArray = (Array)Enum.GetValues(typeof(StatusEnum.PackageType)).Cast<StatusEnum.PackageType>();
            foreach (StatusEnum.PackageType element in enumPackageArray)
            {
                finalPackageEnumList.Add(StatusEnum.GetDescription(element));
            }

            typePackageComboBox.ItemsSource = finalPackageEnumList;
            this.temp = temp;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }



        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }

        private void rezult_Click(object sender, RoutedEventArgs e)
        {
            CostSum();
        }



        private void ModelBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CostSum();
        }

        private void CategoryView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CostSum();
        }


        public void CostSum()
        {
            if (ModelBox.Text != string.Empty && CategoryView.SelectedItem != null)
            {
                CargoCategory temp = CategoryView.SelectedItem as CargoCategory;
                CostBox.Text = Convert.ToString(Convert.ToDecimal(ModelBox.Text) * temp.GetTransportationCoefficient());
            }


        }
    }
}
