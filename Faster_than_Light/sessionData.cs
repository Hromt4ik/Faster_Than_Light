﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light
{
    public class sessionData
    {
        public static bool IsAdmin = false;


        public static void LogInAdmin() {
            
            IsAdmin = true;

        }
        public static void LogOutAdmin() {
        
            IsAdmin = false;
        }
    }
}
