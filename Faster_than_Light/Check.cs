using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light
{
    public class Check
    {
        public static bool Empty(string message) {
        
            if (string.IsNullOrEmpty(message))
            {
                return true;
            }
            return false;
        }


        //public static bool Phone(string message)
        //{

        //}
        //public static bool Email(string message)
        //{

        //}

    }
}
