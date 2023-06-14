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
    /// Логика взаимодействия для EditClient.xaml
    /// </summary>
    public partial class EditClient : Window
    {

        Client temp = new Client();
        public EditClient(Client client)
        {
            InitializeComponent();
            temp = client;
            NameBox.Text = temp.Name;
            SurnameBox.Text = temp.Surname;
            PatronomicBox.Text = temp.Patronymic;
            BirthdateBox.SelectedDate = temp.Birthdate;
            SeriaNumberPassportBox.Text = temp.SeriaNumberPassport;
            PhoneNumberBox.Text = temp.PhoneNumber;
            EmailBox.Text = temp.Email;

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {


            if (Check.Empty(NameBox.Text))
            {
                MessageBox.Show("Введите имя", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(SurnameBox.Text))
            {
                MessageBox.Show("Введите фамилию", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(PatronomicBox.Text))
            {
                MessageBox.Show("Введите отчество", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(Convert.ToString(BirthdateBox.Text)))
            {
                MessageBox.Show("Введите дату рождения", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(SeriaNumberPassportBox.Text))
            {
                MessageBox.Show("Введите серию и номер паспорта", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!Check.IsPositivNumber(SeriaNumberPassportBox.Text))
            {
                MessageBox.Show("Введите серию и номер паспорта", "Поле заполнено некоректно", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(PhoneNumberBox.Text))
            {
                MessageBox.Show("Введите номер телефона", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Check.Empty(EmailBox.Text))
            {
                MessageBox.Show("Введите Email", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!(Check.Phone(PhoneNumberBox.Text)))
            {
                MessageBox.Show("Введите номер телефона в формате: \n 8ХХХХХХХХХХ", "Телефон введен некоректно", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (!(Check.Email(EmailBox.Text)))
            {
                MessageBox.Show("Введите коректный Email", "Поле заполнено некоректно", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            temp.Name = NameBox.Text;
            temp.Surname = SurnameBox.Text;
            temp.Patronymic = PatronomicBox.Text;
            temp.Birthdate = DateTime.SpecifyKind(Convert.ToDateTime(BirthdateBox.SelectedDate.Value), DateTimeKind.Utc);
            temp.SeriaNumberPassport = SeriaNumberPassportBox.Text;
            temp.PhoneNumber = PhoneNumberBox.Text;
            temp.Email = EmailBox.Text;



            DatabaseControl.UpdateClieny(temp);
            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetClientForView();
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
