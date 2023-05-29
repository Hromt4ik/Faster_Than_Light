using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light.classes
{
    public class PointReception
    {
        public int PointID { get; set;}
        public string Address { get; set;}
        public int Director { get; set;}
        public int WarehouseID { get; set;}

        public Employee EmployeeEntity { get; set;}
        public Warehouse WarehouseEntity { get; set;}
        
        public List<Package> PackageSendingAddress { get; set;}
        public List<Package> PackageDeliveryAddress { get; set;}

    }
}
