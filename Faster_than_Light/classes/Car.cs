using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Faster_than_Light.classes
{
    public class Car
    {

        [Key] public int CarID { get; set; }
        public string VIN { get; set; }
        public string StateNumber { get; set; }
        public string Stamp { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int NextMaintenance { get; set; }
        public string Status  { get; set; } = String.Empty;

        [ForeignKey("LocationBaseEntity")] public int LocationBase { get; set; }
        [ForeignKey("EmployeEntity")] public int DriverID { get; set; }

        public LocationBase LocationBaseEntity { get; set; }
        public Employee EmployeEntity { get; set; }
        public List<Package> PackageEntites { get; set; }

  


    }
}
