using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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


        public static bool Phone(string message)
        {


        }
        public static bool Email(string email) => Regex.IsMatch(email, @"[a-zA-Z1-9\-\._] +@[a-z1-9]+(.[a-z1-9] +){ 1,}");

    }
}
