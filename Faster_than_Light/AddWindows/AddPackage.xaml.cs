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
    /// Логика взаимодействия для AddPackage.xaml
    /// </summary>
    public partial class AddPackage : Window
    {
        public AddPackage()
        {
            InitializeComponent();
            ClientIdView.ItemsSource = DatabaseControl.GetClientForView();
            SendingView.ItemsSource = DatabaseControl.GetPointReceptionForView();
            DeliveryView.ItemsSource = DatabaseControl.GetPointReceptionForView();
            EmployeeView.ItemsSource = DatabaseControl.GetEmployeeForView();
            CategoryView.ItemsSource = DatabaseControl.GetCargoCategoryForView();
            CarIDView.ItemsSource = DatabaseControl.GetCarForView();

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            DatabaseControl.AddPackage(new classes.Package
            {
                ClientID = (int)ClientIdView.SelectedValue,
                SendingAddress = (int)SendingView.SelectedValue,
                DeliveryAddress = (int)DeliveryView.SelectedValue,
                EmployeeID = (int)EmployeeView.SelectedValue,
                CargoCategory = (int)CategoryView.SelectedValue,
                CarID = (int)CarIDView.SelectedValue,

                Length = Convert.ToInt32(LenghtBox.Text),
                Width = Convert.ToInt32(WidthBox.Text),
                Height = Convert.ToInt32(HeightBox.Text),
                Weight = Convert.ToInt32(ModelBox.Text),


               DateIssue = DateTime.SpecifyKind(Convert.ToDateTime(DateIssueBox.SelectedDate.Value), DateTimeKind.Utc),
               DateAcceptance = DateTime.SpecifyKind(Convert.ToDateTime(DateAcceptanceeBox.SelectedDate.Value), DateTimeKind.Utc),
               DateDeliveryToPoint = DateTime.SpecifyKind(Convert.ToDateTime(DateDeliveryToPointBox.SelectedDate.Value), DateTimeKind.Utc),

               PackageType = TypeBox.Text,
               Status = StatusBox.Text,

               DeliveryCost = Convert.ToInt32(CostBox.Text),
               Comments = CommBox.Text,


            }) ;

            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetPackageForView();
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }
    }
}
