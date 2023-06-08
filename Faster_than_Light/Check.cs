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
         

        public static bool Phone(string phoneNumber) => Regex.IsMatch(phoneNumber, @"8\d{10}");
 
        public static bool Email(string email) => Regex.IsMatch(email, @"^\w+([.-]?\w+)@\w+([.-]?\w+)(.\w{2,3})+$");

    }
}
