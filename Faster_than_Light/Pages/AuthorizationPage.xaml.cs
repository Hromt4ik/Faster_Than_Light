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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Faster_than_Light.MainWindow;

namespace Faster_than_Light.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Clear_box();
        }

        private void Button_Click_Enter(object sender, RoutedEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Check_Enter();
            }
                
            
        }



        public void Check_Enter()
        {
            //Добавить проверку на то что логин есть в базе
            if (CheckLogin() && CheckPassword())
            {
                FrameLib.MainWindowFrame.Navigate(null);
            }
            else
            {
                Clear_box();
            }
        }
        public void Clear_box()
        {
            login.Text = string.Empty;
            password.Clear();
        }

        public bool CheckLogin()
        {
            if (login.Text == String.Empty)
            {
                MessageBox.Show("Логин не может быть пустым", "Неверный ввод", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }

            return true;
        }

        public bool CheckPassword()
        {
            if (password.Password.ToString() == "qqq")
            {
                MessageBox.Show("Неправильный Пароль", "Неверный ввод", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;

            }
            if (password.Password.ToString() == String.Empty)
            {
                MessageBox.Show("Пароль не введен", "Введите пароль", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;

            }
            return true;
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            Check_Enter();
        }
    }
}

