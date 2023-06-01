﻿using Faster_than_Light.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}