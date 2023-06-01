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

namespace Faster_than_Light.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            
            InitializeComponent();
            FrameLib.FrameCarInfo = FrameCarInfo;
        }

        private void ButtonCar_Click(object sender, RoutedEventArgs e)
        {
            FrameLib.FrameCarInfo.Navigate(new CarInfo());
        }
        private void FrameAuthorization_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void ButtonDriverIdentification_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonCargoCategory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonLocationBase_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPackage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPointReception_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonWarehouse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonEmploee_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
