using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Faster_than_Light.classes
{
    public class PointReception
    {
        [Key] public int PointID { get; set;}
        public string Address { get; set;}
        [ForeignKey("EmployeeEntity")]  public int Director { get; set;}
        [ForeignKey("WarehouseEntity")]  public int WarehouseID { get; set;}

        public Employee EmployeeEntity { get; set;}
        public Warehouse WarehouseEntity { get; set;}
        
        public List<Package> PackageSendingAddress { get; set;}
        public List<Package> PackageDeliveryAddress { get; set;}

    }
}
