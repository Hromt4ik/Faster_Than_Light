using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Faster_than_Light.classes
{
    public class CargoCategory
    {
        [Key] public int CategoryID { get; set; }
        public string Name { get; set; }
        public decimal TransportationCoefficient { get; set; }
        public string Comments { get; set; }

        public List<Package> PackageEntites { get; set; }
    }
}
