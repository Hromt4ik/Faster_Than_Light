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

namespace Faster_than_Light
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
            login.Text = string.Empty;
            password.Clear();
        }

        private void Button_Click_Enter(object sender, RoutedEventArgs e)
        {
            //Добавить проверку на то что логин есть в базе
            if (password.Password.ToString() == "qqq")
            {
                MessageBox.Show("yooohgy", "2312");
            }

        }
    }
}
