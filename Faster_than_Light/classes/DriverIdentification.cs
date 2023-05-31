using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Faster_than_Light.classes
{
    public class DriverIdentification
    {
        [Key] public int GuideReferencesID { get; set; }
        public string DriverLicense { get; set; }
        public JsonObject Category { get; set; }

        public DateTime DateReceipt { get; set; }
        public DateTime TerminationDate { get; set; }
        [ForeignKey("EmployeeEntity")] public int EmploeeID { get; set; }

        public Employee EmployeeEntity { get; set; }

        DriverIdentification() {
        
            Category = new JsonObject();

        }


    }
}
