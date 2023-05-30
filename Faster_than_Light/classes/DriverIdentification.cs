using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Faster_than_Light.classes
{
    public class DriverIdentification
    {
        public int GuideReferencesID { get; set; }
        public string DriverLicense { get; set; }
        public JsonObject Category { get; set; }
        public DateOnly DateReceipt { get; set; }
        public DateOnly TerminationDate { get; set; }
       public Employee EmployeeEntity { get; set; }  

    }
}
