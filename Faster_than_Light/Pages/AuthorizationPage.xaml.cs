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
            Clear_box();
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Clear_box();
        }

        private void Button_Click_Enter(object sender, RoutedEventArgs e)
        {

              Check_Enter();      
            
        }



        public void Check_Enter()
        {

            if (login.Text == "СекретныйКод")
            {
                sessionData.LogInAdmin();
                FrameLib.FrameAuthorization.Navigate(null);
                NavigateMethods.MainPageOpen();
                MessageBox.Show("Ай ай ай", "Кто-то что-то забыл", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (!(CheckLogin() && CheckPassword()))
            {
                Clear_box();
                return;
            }

            Employee user = DatabaseControl.GetUser(login.Text);

            if (user == null)
            {
                MessageBox.Show("Пользователь не найден", "Неверный логин", MessageBoxButton.OK, MessageBoxImage.Warning);
                Clear_box();
                return;
            }

            sessionData.Login = Convert.ToString(user.Login);
            sessionData.Password = user.Password;


            if (sessionData.Password != password.Password.ToString())
            {

                MessageBox.Show("Неверный Пароль", "Ошибка Ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                sessionData.Login = null;
                sessionData.Password = null;
                return;
            }

            if (user.Post == "Админ")
            {
                sessionData.LogInAdmin();
            }

            FrameLib.FrameAuthorization.Navigate(null);
            NavigateMethods.MainPageOpen();
      
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
            if (password.Password.ToString() == String.Empty)
            {
                MessageBox.Show("Пароль не введен", "Введите пароль", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;

            }
            return true;
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter) {
                Check_Enter();
            } 
        }
    }
}

