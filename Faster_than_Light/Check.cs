using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

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


        public static bool IsPositivNumber(string str)
        {
            
            double number;
            if (double.TryParse(str, out number))
            {
                if (number > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Введите положительное число", "Число не может быть отрицательным", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
                
                
            }

            MessageBox.Show("Введите число", "Строка не являеться числом", MessageBoxButton.OK, MessageBoxImage.Warning);
            return false;
        }

    }
}
