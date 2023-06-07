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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Window
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            DatabaseControl.AddClient(new classes.Client
            {
                Name = NameBox.Text,
                Surname = SurnameBox.Text,
                Patronymic = PatronomicBox.Text,
                Birthdate = DateTime.SpecifyKind(Convert.ToDateTime(BirthdateBox.SelectedDate.Value), DateTimeKind.Utc),
                SeriaNumberPassport = SeriaNumberPassportBox.Text,
                PhoneNumber = PhoneNumberBox.Text,
                Email = EmailBox.Text,
            }) ;


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
