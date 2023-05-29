using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light.classes
{
    public class Car
    {

        public int CarID { get; set; }
        public string VIN { get; set; }
        public string StateNumber { get; set; }
        public string Stamp { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int NextMaintenance { get; set; }
        public StatusEnum.MachineStatuses Status { get; set; }
        public int LocationBase { get; set; }
        public int DriverID { get; set; }

        public LocationBase LocationBaseEntity { get; set; }
        public Employee EmployeEntity { get; set; }

        public List<Package> PackageEntites { get; set; }

    }
}
