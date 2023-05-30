﻿using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light.classes
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateOnly Birthdate { get; set; }
        public string SeriaNumberPassport { get; set; }
        public string PhoneNumber { get; set; }
        public string ResidentialAddress { get; set; }
        public string Email { get; set; }
        public string Post { get; set; }
        public int GuideReferencesID { get; set; }

        public List<DriverIdentification> DriverIdentificationEntites { get; set; }
        public List<LocationBase> LocationBaseEntites { get; set; }
        public List<PointReception> PointReceptionEntites { get; set; }
        public List<Warehouse> WarehouseEntites { get; set; }
        public List<Car> CarEntites { get; set; }
        public List<Package> PackageEntites { get; set; }
    }
}
