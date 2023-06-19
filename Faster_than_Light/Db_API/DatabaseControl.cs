using Faster_than_Light.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Faster_than_Light.Db_API
{
 

    public static class DatabaseControl
    {


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


        //public static bool isPhoneUnique(string phone, string type)
        //{
        //    using (DbAppContext ctx = new DbAppContext())
        //    {
        //        if (type == "customer" && ctx.Customer.Where(p => p.PhoneNumber == phone).FirstOrDefault() != null)
        //        {
        //            return false;
        //        }
        //        else if (type == "provider" && ctx.Provider.Where(p => p.PhoneNumber == phone).FirstOrDefault() != null)
        //        {
        //            return false;
        //        }

        //        return true;
        //    }
        //}

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
