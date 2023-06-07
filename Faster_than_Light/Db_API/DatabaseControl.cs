using Faster_than_Light.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light.Db_API
{
    //public static class DatabaseControl
    //{
    //    public static List<Phone> GetPhonesForView()
    //    {
    //        using (DbAppContext ctx = new DbAppContext())
    //        {
    //            return ctx.Phone.Include(p => p.CompanyEntity).ToList();
    //        }
    //    }

    //    public static List<Company> GetCompanyForView()
    //    {
    //        using (DbAppContext ctx = new DbAppContext())
    //        {
    //            return ctx.Company.Include(p => p.PhoneEntites).ToList();
    //        }
    //    }

    //    public static void AddPhone(Phone phone)
    //    {
    //        using (DbAppContext ctx = new DbAppContext())
    //        {
    //            ctx.Phone.Add(phone);
    //            ctx.SaveChanges();
    //        }
    //    }
    //    public static void DelPhone(Phone phone)
    //    {
    //        using (DbAppContext ctx = new DbAppContext())
    //        {
    //            ctx.Phone.Remove(phone);
    //            ctx.SaveChanges();
    //        }
    //    }

    //    public static void UpdatePhone(Phone phone)
    //    {
    //        using (DbAppContext ctx = new DbAppContext())
    //        {
    //            Phone _phone = ctx.Phone.FirstOrDefault(p => p.Id == phone.Id);

    //            if (_phone == null)
    //            {
    //                return;
    //            }

    //            _phone.Title = phone.Title;
    //            _phone.Price = phone.Price;
    //            _phone.CompanyId = phone.CompanyId;

    //            ctx.SaveChanges();
    //        }
    //    }
    //}

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
        public static List<CargoCategory> GetCargoСategoryForView()
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

        //--------------------------------------------------------------- end
    }
}
