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


        public static void AddClient(Client client)
        {
            using (DbAppContext ctx = new DbAppContext())
            {
                ctx.Client.Add(client);
                ctx.SaveChanges();
            }
        }


    }
}
