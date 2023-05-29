using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light.classes
{
    public class CargoСategory
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public decimal TransportationCoefficient { get; set; }
        public string Comments { get; set; }

        public List<Package> PackageEntites { get; set; }
    }
}
