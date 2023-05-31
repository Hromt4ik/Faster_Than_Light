using Faster_than_Light.Db_API;
using Faster_than_Light.Pages;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameLib.MainWindowFrame = FrameAuthorization;
            FrameLib.FrameCarInfo = FrameCarInfo;
            NavigateToPage1();
            
        }

        

        public void NavigateToPage1()
        {
            FrameLib.MainWindowFrame.Navigate(new AuthorizationPage());
        }

        private void ButtonCar_Click(object sender, RoutedEventArgs e)
        {
            FrameLib.FrameCarInfo.Navigate(new CarInfo());
        }

        private void FrameAuthorization_Navigated(object sender, NavigationEventArgs e)
        {

        }

        public void Change_Visabilyty_Visible()
        {
            MainStackPanel.Visibility = Visibility.Visible;
        }

        public void Change_Visabilyty_Collapsed()
        {
            MainStackPanel.Visibility = Visibility.Collapsed;
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
