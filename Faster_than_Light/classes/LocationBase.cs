using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light.classes
{
    public class LocationBase
    {
        public int LocationBaseID { get; set; }
        public string Address { get; set; }
        public int NumberSeats { get; set; }
        public string Region { get; set; }
        public int Director { get; set; }

        public Employee EmployeeEntity { get; set; }

        public List<Car> CarEntites { get; set; }
    }
}
