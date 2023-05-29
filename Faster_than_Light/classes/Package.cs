using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Faster_than_Light.classes
{
    public class Package
    {
        public int PackageID { get; set; }
        public int ClientID { get; set; }
        public string Comments { get; set; }
        public int SendingAddress { get; set; }
        public int DeliveryAddress { get; set; }
        public decimal Weight { get; set; }
        public DateTime DateAcceptance { get; set; }
        public DateTime DateDeliveryToPoint { get; set; }
        public DateTime DateIssue { get; set; }
        public int EmployeeID { get; set; }
        public JsonObject Dimensions { get; set; }
        public string PackageType { get; set; }
        public decimal DeliveryCost { get; set; }
        public int CargoСategory { get; set; }
        public StatusEnum.ParcelStatuses Status { get; set; }
        public int CarID { get; set; }

        public Client ClientEntity { get; set; }
        public PointReception SendingAddressEntity { get; set; }
        public PointReception DeliveryAddressEntity { get; set; }
        public Employee EmployeeEntity { get; set; }
        public CargoСategory CargoСategoryEntity { get; set; }
        public Car CarEntity { get; set; }



    }
}
