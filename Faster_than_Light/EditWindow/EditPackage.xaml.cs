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
using static Faster_than_Light.classes.StatusEnum;
using System.Xml.Linq;
using static Faster_than_Light.NavigateMethods;

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
            ClientIdView.ItemsSource = DatabaseControl.GetClientForView();
            SendingView.ItemsSource = DatabaseControl.GetPointReceptionForView();
            DeliveryView.ItemsSource = DatabaseControl.GetPointReceptionForView();
            EmployeeView.ItemsSource = DatabaseControl.GetEmployeeForView();
            CategoryView.ItemsSource = DatabaseControl.GetCargoCategoryForView();
            CarIDView.ItemsSource = DatabaseControl.GetCarForView();




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

            ClientIdView.SelectedValue = package.ClientEntity.ClientID;
            SendingView.SelectedValue = package.SendingAddressEntity.PointID;
            DeliveryView.SelectedValue = package.DeliveryAddressEntity.PointID;

            LenghtBox.Text = package.Length.ToString();
            WidthBox.Text = package.Width.ToString();
            HeightBox.Text = package.Height.ToString();

            DateAcceptanceBox.SelectedDate = package.DateAcceptance;
            DateDeliveryToPointBox.SelectedDate = package.DateDeliveryToPoint;
            DateIssueBox.SelectedDate = package.DateIssue;

            ModelBox.Text = package.Weight.ToString();
            EmployeeView.SelectedValue = package.EmployeeEntity.EmployeeID;
            CategoryView.SelectedValue = package.CargoCategoryEntity.CategoryID;

            typePackageComboBox.SelectedValue = package.PackageType;
            CarIDView.SelectedValue = package.CarEntity.CarID;
            statusComboBox.SelectedValue = package.Status;

            CostBox.Text = package.DeliveryCost.ToString();
            CommBox.Text = package.Comments;

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (Check.Empty(ClientIdView.Text))
            {
                MessageBox.Show("Выберите клиента", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(SendingView.Text))
            {
                MessageBox.Show("Выберите адрес отправки", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(DeliveryView.Text))
            {
                MessageBox.Show("Выберите адрес доставки", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(LenghtBox.Text))
            {
                MessageBox.Show("Введите длину", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Check.Empty(WidthBox.Text))
            {
                MessageBox.Show("Выберите ширину", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(HeightBox.Text))
            {
                MessageBox.Show("Выберите высоту", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(Convert.ToString(DateAcceptanceBox.Text)))
            {
                MessageBox.Show("Введите дату принятия", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            if (Check.Empty(ModelBox.Text))
            {
                MessageBox.Show("Введит вес", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(CategoryView.Text))
            {
                MessageBox.Show("Выберите категорию", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(EmployeeView.Text))
            {
                MessageBox.Show("Выберите сотрудника", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Check.Empty(CarIDView.Text))
            {
                MessageBox.Show("Выберите тип упаковки", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Check.Empty(typePackageComboBox.Text))
            {
                MessageBox.Show("Выберите тип упаковки", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(statusComboBox.Text))
            {
                MessageBox.Show("Выберите статус посылки", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(CostBox.Text))
            {
                MessageBox.Show("Заолните цену", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!(Check.IsPositivNumber(LenghtBox.Text)))
            {
                return;
            }
            if (!(Check.IsPositivNumber(WidthBox.Text)))
            {
                return;
            }
            if (!(Check.IsPositivNumber(ModelBox.Text)))
            {
                return;
            }
            if (!(Check.IsPositivNumber(HeightBox.Text)))
            {
                return;
            }
            if (!(Check.IsPositivNumber(CostBox.Text)))
            {
                return;
            }


            if (!Check.DateMore(Convert.ToDateTime(DateAcceptanceBox.SelectedDate.Value), Convert.ToDateTime(DateDeliveryToPointBox.SelectedDate.Value)))
            {
                MessageBox.Show("Дата доставки в пункт не может \n быть меньше даты принятия", "Ошибка даты", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!Check.DateMore(Convert.ToDateTime(DateDeliveryToPointBox.SelectedDate.Value), Convert.ToDateTime(DateIssueBox.SelectedDate.Value)))
            {
                MessageBox.Show("Дата получения клиентом в пункт не может \n быть меньше даты доставки в пукт", "Ошибка даты", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (SendingView.SelectedIndex == DeliveryView.SelectedIndex)
            {
                MessageBox.Show("Адрес доставки и получения не может совпадать", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            temp.ClientID = (int)ClientIdView.SelectedValue;
            temp.SendingAddress = (int)SendingView.SelectedValue;
            temp.DeliveryAddress = (int)DeliveryView.SelectedValue;
            temp.EmployeeID = (int)EmployeeView.SelectedValue;
            temp.CargoCategory = (int)CategoryView.SelectedValue;
            temp.CarID = (int)CarIDView.SelectedValue;

            temp.Length = Convert.ToInt32(LenghtBox.Text);
            temp.Width = Convert.ToInt32(WidthBox.Text);
            temp.Height = Convert.ToInt32(HeightBox.Text);
            temp.Weight = Convert.ToDecimal(ModelBox.Text);


            temp.DateIssue = DateTime.SpecifyKind(Convert.ToDateTime(DateIssueBox.SelectedDate.Value), DateTimeKind.Utc);
            temp.DateAcceptance = DateTime.SpecifyKind(Convert.ToDateTime(DateAcceptanceBox.SelectedDate.Value), DateTimeKind.Utc);
            temp.DateDeliveryToPoint = DateTime.SpecifyKind(Convert.ToDateTime(DateDeliveryToPointBox.SelectedDate.Value), DateTimeKind.Utc);

            temp.PackageType = typePackageComboBox.SelectedItem.ToString();
            temp.Status = statusComboBox.SelectedItem.ToString();

            temp.DeliveryCost = Convert.ToDecimal(CostBox.Text);
            temp.Comments = CommBox.Text;


            DatabaseControl.UpdatePackage(temp);
            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetPackageForView();
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
            if (!(Check.IsPositivNumber(ModelBox.Text)))
            {
                return;
            }
            if (ModelBox.Text != string.Empty && CategoryView.SelectedItem != null)
            {
                CargoCategory temp = CategoryView.SelectedItem as CargoCategory;
                CostBox.Text = Convert.ToString(Convert.ToDecimal(ModelBox.Text) * temp.GetTransportationCoefficient());
            }
        }
    }
}
