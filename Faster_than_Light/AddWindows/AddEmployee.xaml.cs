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
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        public AddEmployee()
        {
            InitializeComponent();
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
            if (Check.Empty(resAdressBox.Text))
            {
                MessageBox.Show("Введите Адрес Проживания", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Check.Empty(postBox.Text))
            {
                MessageBox.Show("Введите Должность", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }            
            if (Check.Empty(passwordBox.Text))
            {
                MessageBox.Show("Введите Пороль Для Пользователя", "Поле не заполнено", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            DatabaseControl.AddEmployee(new classes.Employee
            {
                Password = passwordBox.Text,
                Name = NameBox.Text,
                Surname = SurnameBox.Text,
                Patronymic = PatronomicBox.Text,
                Birthdate = DateTime.SpecifyKind(Convert.ToDateTime(BirthdateBox.SelectedDate.Value), DateTimeKind.Utc),
                SeriaNumberPassport = SeriaNumberPassportBox.Text,
                PhoneNumber = PhoneNumberBox.Text,
                ResidentialAddress = resAdressBox.Text,
                Email = EmailBox.Text,
                Post = postBox.Text

            });


            GridStorage.grid.ItemsSource = null;
            GridStorage.grid.ItemsSource = DatabaseControl.GetEmployeeForView();

            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
