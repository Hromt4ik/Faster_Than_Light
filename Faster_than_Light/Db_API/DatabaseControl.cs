using Faster_than_Light.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Faster_than_Light.Db_API
{
 

    public static class DatabaseControl
    {


        public static List<Car> GetCarStatusAtTheBase()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Car.Include(t => t.LocationBaseEntity).Include(t => t.EmployeeEntity).Where(t => t.Status == "На базе").ToList();
            }
        }
        public static List<Car> GetCarStatusAssignedDriver()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Car.Include(t => t.LocationBaseEntity).Include(t => t.EmployeeEntity).Where(t => t.Status == "Назначен водитель").ToList();
            }
        }
        public static List<Car> GetCarStatusRepair()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Car.Include(t => t.LocationBaseEntity).Include(t => t.EmployeeEntity).Where(t => t.Status == "Ремонт").ToList();
            }
        }
        public static List<Car> GetCarStatusDiscarded()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Car.Include(t => t.LocationBaseEntity).Include(t => t.EmployeeEntity).Where(t => t.Status == "Списана").ToList();
            }
        }

        public static List<Package> GetPackageStatusAcceptedFromClient()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Where(t => t.Status == "Принят от клиента").ToList();
            }
        }
        public static List<Package> GetPackageStatusSentToWarehouse()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Where(t => t.Status == "Отправлен на склад").ToList();
            }
        }
        public static List<Package> GetPackageStatusAcceptedToWarehouse()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Where(t => t.Status == "Принят на складе").ToList();
            }
        }
        public static List<Package> GetPackageStatusSentToDestinationCity()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Where(t => t.Status == "Отправлен в город выдачи").ToList();
            }
        }
        public static List<Package> GetPackageStatusAcceptedDestinationCity()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Where(t => t.Status == "Принят в городе выдачи").ToList();
            }
        }
        public static List<Package> GetPackageStatusSentIssuePoint()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Where(t => t.Status == "Отправлен в пункт выдачи").ToList();
            }
        }
        public static List<Package> GetPackageStatusAcceptedPointIssue()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Where(t => t.Status == "Принят в пункте выдачи").ToList();
            }
        }
        public static List<Package> GetPackageStatusLost()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Where(t => t.Status == "Утерян").ToList();
            }
        }
        public static List<Package> GetPackageStatusIssued()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Where(t => t.Status == "Выдан").ToList();
            }
        }

        public static decimal AllSumCost()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Sum(t => t.DeliveryCost);
            }
        }

        public static decimal AllAvgCost()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).Average(t => t.DeliveryCost);
            }
        }


        //Get for View All tables--------------------------------------------------
        public static List<Car> GetCarForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Car.Include(t => t.LocationBaseEntity).Include(t => t.EmployeeEntity).ToList();
            }
        }
        public static List<CargoCategory> GetCargoCategoryForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.CargoCategory.ToList();
            }
        }
        public static List<Client> GetClientForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Client.ToList();
            }
        }
        public static List<DriverIdentification> GetDriverIdentificationForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.DriverIdentification.Include(t => t.EmployeeEntity).ToList();
            }
        }
        public static List<Employee> GetEmployeeForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Employee.ToList();
            }
        }
        public static List<LocationBase> GetLocationBaseForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.LocationBase.Include(t => t.EmployeeEntity).ToList();
            }
        }
        public static List<Package> GetPackageForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
                    .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).ToList();
            }
        }
        public static List<PointReception> GetPointReceptionForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.PointReception.Include(t => t.WarehouseEntity).Include(t => t.EmployeeEntity).ToList();
            }
        }
        public static List<Warehouse> GetWarehouseForView()
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Warehouse.Include(t => t.EmployeeEntity).ToList();
            }
        }
        //-------------------------------------------------------------- end

        public static Employee GetUser(string login)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                return ctx.Employee.Where(p => p.Login == login).FirstOrDefault();
               
            }
        }
        //public static Package GetSendingAdressAddreses()
        //{
        //    using (DbAppContext ctx = new DbAppContext())
        //    {
        //        return ctx.Package.Include(t => t.ClientEntity).Include(t => t.SendingAddressEntity).Include(t => t.DeliveryAddressEntity)
        //            .Include(t => t.EmployeeEntity).Include(t => t.CargoCategoryEntity).Include(t => t.CarEntity).OrderBy(p => p.SendingAddress).ToList();
        //    }
        //}


        public static bool isDriverIdentificationUnique(string driverLicense)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                if (ctx.DriverIdentification.Where(p => p.DriverLicense == driverLicense).FirstOrDefault() != null)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool isClientPasportUnique(string number)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                if (ctx.Client.Where(p => p.SeriaNumberPassport == number).FirstOrDefault() != null)
                {
                    return false;
                }
                return true;
            }
        }


        public static bool isEmployeePasportUnique(string number)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                if (ctx.Employee.Where(p => p.SeriaNumberPassport == number).FirstOrDefault() != null)
                {
                    return false;
                }
                return true;
            }
        }


        public static bool isVINUnique(string vin)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                if (ctx.Car.Where(p => p.VIN == vin).FirstOrDefault() != null)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool isEmailClientUnique(string email)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                if (ctx.Client.Where(p => p.Email == email).FirstOrDefault() != null)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool isEmailEmployeeUnique(string email)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                if (ctx.Employee.Where(p => p.Email == email).FirstOrDefault() != null)
                {
                    return false;
                }
                return true;
            }
        }

        public static bool isLoginUnique(string login)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                if (ctx.Employee.Where(p => p.Login == login).FirstOrDefault() != null)
                {
                    return false;
                }
                return true;
            }
        }


        //Add all tables -----------------------------------------------------------------
        public static void AddCar(Car Car)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Car.Add(Car);
                ctx.SaveChanges();
            }
        }
        public static void AddCargoCategory(CargoCategory CargoCategory)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.CargoCategory.Add(CargoCategory);
                ctx.SaveChanges();
            }
        }
        public static void AddClient(Client client)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Client.Add(client);
                ctx.SaveChanges();
            }
        }
        public static void AddDriverIdentification(DriverIdentification DriverIdentification)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.DriverIdentification.Add(DriverIdentification);
                ctx.SaveChanges();
            }
        }
        public static void AddEmployee(Employee Employee)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Employee.Add(Employee);
                ctx.SaveChanges();
            }
        }
        public static void AddLocationBase(LocationBase LocationBase)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.LocationBase.Add(LocationBase);
                ctx.SaveChanges();
            }
        }
        public static void AddPackage(Package Package)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Package.Add(Package);
                ctx.SaveChanges();
            }
        }
        public static void AddPointReception(PointReception PointReception)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.PointReception.Add(PointReception);
                ctx.SaveChanges();
            }
        }
        public static void AddWarehouse(Warehouse Warehouse)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Warehouse.Add(Warehouse);
                ctx.SaveChanges();
            }
        }


        //--------------------------------------------------------------- end

        //Edit all tables -----------------------------------------------------

        public static void UpdateDriverIdentification(DriverIdentification driverIdentification)
        {
            using (DbAppContext ctx = new DbAppContext())
            {

                DriverIdentification temp = ctx.DriverIdentification.FirstOrDefault(
                    p => p.GuideReferencesID == driverIdentification.GuideReferencesID);

                if (temp == null)
                {
                    return;
                }

                temp.DriverLicense = driverIdentification.DriverLicense;
                temp.B = driverIdentification.B;
                temp.BE = driverIdentification.BE;
                temp.C = driverIdentification.C;
                temp.CE = driverIdentification.CE;
                temp.DateReceipt = driverIdentification.DateReceipt;
                temp.TerminationDate = driverIdentification.TerminationDate;
                temp.EmployeeID = driverIdentification.EmployeeID;


                ctx.SaveChanges();
            }
        }

        public static void UpdateCargoCategory(CargoCategory Category)
        {
            using (DbAppContext ctx = new DbAppContext())
            {

                CargoCategory temp = ctx.CargoCategory.FirstOrDefault(p => p.CategoryID == Category.CategoryID);

                if (temp == null)
                {
                    return;
                }

                temp.Name = Category.Name;
                temp.Comments = Category.Comments;
                temp.TransportationCoefficient = Category.TransportationCoefficient;

                ctx.SaveChanges();
            }
        }

        public static void UpdateClieny(Client client)
        {
            using (DbAppContext ctx = new DbAppContext())
            {

                Client temp = ctx.Client.FirstOrDefault(p => p.ClientID 
                == client.ClientID);

                if (temp == null)
                {
                    return;
                }

                temp.Name = client.Name;
                temp.Surname = client.Surname;
                temp.Patronymic = client.Patronymic;
                temp.Birthdate = client.Birthdate;
                temp.SeriaNumberPassport = client.SeriaNumberPassport;
                temp.PhoneNumber = client.PhoneNumber;
                temp.Email = client.Email;
                

                ctx.SaveChanges();
            }
        }

        public static void UpdateLocationBase(LocationBase locationBase)
        {
            using (DbAppContext ctx = new DbAppContext())
            {

                LocationBase temp = ctx.LocationBase.FirstOrDefault(p => p.LocationBaseID
                == locationBase.LocationBaseID);

                if (temp == null)
                {
                    return;
                }

                temp.Region = locationBase.Region;
                temp.Director = locationBase.Director;
                temp.NumberSeats = locationBase.NumberSeats;
                temp.Address = locationBase.Address;

                ctx.SaveChanges();
            }
        }

        public static void UpdateCar(Car car)
        {
            using (DbAppContext ctx = new DbAppContext())
            {

                Car temp = ctx.Car.FirstOrDefault(p => p.CarID
                == car.CarID);

                if (temp == null)
                {
                    return;
                }

                temp.VIN = car.VIN;
                temp.StateNumber = car.StateNumber;
                temp.Stamp = car.Stamp;
                temp.Model = car.Model;
                temp.Mileage = car.Mileage;
                temp.NextMaintenance = car.NextMaintenance;
                temp.Status = car.Status;
                temp.LocationBase = car.LocationBase;
                temp.DriverID = car.DriverID;

                ctx.SaveChanges();
            }
        }

        public static void UpdatePointReception(PointReception Point)
        {
            using (DbAppContext ctx = new DbAppContext())
            {

                PointReception temp = ctx.PointReception.FirstOrDefault(p => p.PointID
                == Point.PointID);

                if (temp == null)
                {
                    return;
                }

                temp.Director = Point.Director;
                temp.WarehouseID = Point.WarehouseID;
                temp.Address = Point.Address;

                ctx.SaveChanges();
            }
        }

        public static void UpdateEmployee(Employee employee)
        {
            using (DbAppContext ctx = new DbAppContext())
            {

                Employee temp = ctx.Employee.FirstOrDefault(p => p.EmployeeID
                == employee.EmployeeID);

                if (temp == null)
                {
                    return;
                }

                temp.Birthdate = employee.Birthdate;
                temp.Surname = employee.Surname;
                temp.PhoneNumber = employee.PhoneNumber;
                temp.Login = employee.Login;
                temp.Email = employee.Email;
                temp.SeriaNumberPassport = employee.SeriaNumberPassport;
                temp.Password = employee.Password;
                temp.Post = employee.Post;
                temp.Name= employee.Name;
                temp.Patronymic = employee.Patronymic;
                temp.ResidentialAddress = employee.ResidentialAddress;


                ctx.SaveChanges();
            }
        }

        public static void UpdateWarehouse(Warehouse warehouse)
        {
            using (DbAppContext ctx = new DbAppContext())
            {

                Warehouse temp = ctx.Warehouse.FirstOrDefault(p => p.WarehouseID
                == warehouse.WarehouseID);

                if (temp == null)
                {
                    return;
                }

               temp.Address = warehouse.Address;
               temp.Region = warehouse.Region;
               temp.Director = warehouse.Director;


                ctx.SaveChanges();
            }
        }


        public static void UpdatePackage(Package package)
        {
            using (DbAppContext ctx = new DbAppContext())
            {

                Package temp = ctx.Package.FirstOrDefault(p => p.PackageID
                == package.PackageID);

                if (temp == null)
                {
                    return;
                }

                temp.ClientID = package.ClientID;
                temp.Comments = package.Comments;
                temp.SendingAddress = package.SendingAddress;
                temp.DeliveryAddress = package.DeliveryAddress;
                temp.Weight = package.Weight;
                temp.DateAcceptance = package.DateAcceptance;
                temp.DateDeliveryToPoint = package.DateDeliveryToPoint;
                temp.DateIssue = package.DateIssue;
                temp.EmployeeID = package.EmployeeID;
                temp.Length = package.Length;
                temp.Width = package.Width;
                temp.Height = package.Height;
                temp.PackageType = package.PackageType;
                temp.DeliveryCost = package.DeliveryCost;
                temp.CargoCategory = package.CargoCategory;
                temp.Status = package.Status;
                temp.CarID = package.CarID;



                ctx.SaveChanges();
            }
        }

        //--------------------------------------------------------------- end

        //Delete all tables ---------------------------------------------------

        public static void DelCar(Car Car)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Car.Remove(Car);
                ctx.SaveChanges();
            }
        }
        public static void DelCargoCategory(CargoCategory CargoCategory)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.CargoCategory.Remove(CargoCategory);
                ctx.SaveChanges();
            }
        }
        public static void DelClient(Client client)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Client.Remove(client);
                ctx.SaveChanges();
            }
        }
        public static void DelDriverIdentification(DriverIdentification DriverIdentification)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.DriverIdentification.Remove(DriverIdentification);
                ctx.SaveChanges();
            }
        }
        public static void DelEmployee(Employee Employee)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Employee.Remove(Employee);
                ctx.SaveChanges();
            }
        }
        public static void DelLocationBase(LocationBase LocationBase)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.LocationBase.Remove(LocationBase);
                ctx.SaveChanges();
            }
        }
        public static void DelPackage(Package Package)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Package.Remove(Package);
                ctx.SaveChanges();
            }
        }
        public static void DelPointReception(PointReception PointReception)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.PointReception.Remove(PointReception);
                ctx.SaveChanges();
            }
        }
        public static void DelWarehouse(Warehouse Warehouse)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Warehouse.Remove(Warehouse);
                ctx.SaveChanges();
            }
        }




    }
}
