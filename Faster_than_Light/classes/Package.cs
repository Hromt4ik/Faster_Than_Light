using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Faster_than_Light.classes
{
    public class Package
    {
        [Key] public int PackageID { get; set; }
        [ForeignKey("ClientEntity")] public int ClientID { get; set; }
        public string Comments { get; set; }
        [ForeignKey("SendingAddressEntity")] public int SendingAddress { get; set; }
        [ForeignKey("DeliveryAddressEntity")] public int DeliveryAddress { get; set; }
        public decimal Weight { get; set; }
        public DateTime DateAcceptance { get; set; }
        public DateTime DateDeliveryToPoint { get; set; }
        public DateTime DateIssue { get; set; }
        [ForeignKey("EmployeeEntity")] public int EmployeeID { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string PackageType { get; set; }
        public decimal DeliveryCost { get; set; }
        [ForeignKey("CargoCategoryEntity")]  public int CargoCategory { get; set; }
        public string Status { get; set; }
        [ForeignKey("CarEntity")] public int CarID { get; set; }

        public Client ClientEntity { get; set; }
        public PointReception SendingAddressEntity { get; set; }
        public PointReception DeliveryAddressEntity { get; set; }
        public Employee EmployeeEntity { get; set; }
        public CargoCategory CargoCategoryEntity { get; set; }
        public Car CarEntity { get; set; }



    }
}
