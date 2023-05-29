using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light.classes
{
    public class Warehouse
    {
        public int WarehouseID { get; set; }
        public string Address { get; set; }
        public string Region { get; set; }
        public int Director { get; set; }

        public List<PointReception> PointReceptionEntites { get; set; }

        public Employee EmployeeEntity { get; set; }


    }
}
