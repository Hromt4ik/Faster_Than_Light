using Faster_than_Light.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Faster_than_Light
{
    public class NavigateMethods
    {
        public static void MainPageOpen()
        {
            FrameLib.FrameMainPage.Navigate(new MainPage());
        }

        public static void MainPageClose() {
            FrameLib.FrameMainPage.Navigate(null);
        }

        public static void AuthorizationPageOpen()
        {
            FrameLib.FrameAuthorization.Navigate(new AuthorizationPage());
        }

        public static void AuthorizationPageClose()
        {
            FrameLib.FrameAuthorization.Navigate(null);
        }

        static public class GridStorage
        {
            static public DataGrid grid { set; get; }
        }

    }
}
