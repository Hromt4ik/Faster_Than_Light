using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light
{
    public class Check
    {
        public bool Empty(string message) {
        
            if (string.IsNullOrEmpty(message))
            {
                return false;
            }
            return true;
        }

        public bool NoEmpty(string message)
        {

            if (string.IsNullOrEmpty(message))
            {
                return true;
            }
            return false;
        }




    }
}
