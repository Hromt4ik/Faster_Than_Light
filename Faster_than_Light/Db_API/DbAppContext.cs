using Faster_than_Light.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faster_than_Light.Db_API
{
    public class DbAppContext : DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<CargoCategory> CargoCategory { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<DriverIdentification> DriverIdentification { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<LocationBase> LocationBase { get; set; }
        public DbSet<Package> Package { get; set; }
        public DbSet<PointReception> PointReception { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Username=postgres;Password=22345621;Database=Test_last1");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Phone>().HasOne(p => p.CompanyEntity).WithMany(p => p.PhoneEntites);

            //Car - 2 
            modelBuilder.Entity<Car>().HasOne(t => t.LocationBaseEntity).WithMany(t => t.CarEntites);
            modelBuilder.Entity<Car>().HasOne(t => t.EmployeeEntity).WithMany(t => t.CarEntites);

            //CargoCategory - 0
            //Client - 0
            //DriverIdentification - 1
            modelBuilder.Entity<DriverIdentification>().HasOne(t => t.EmployeeEntity).WithMany(t => t.DriverIdentificationEntites);
            
            //Employee - 0
            //LocationBase - 1
            modelBuilder.Entity<LocationBase>().HasOne(t => t.EmployeeEntity).WithMany(t => t.LocationBaseEntites);

            //Package - 6
            modelBuilder.Entity<Package>().HasOne(t => t.ClientEntity).WithMany(t => t.PackageEntites);
            modelBuilder.Entity<Package>().HasOne(t => t.SendingAddressEntity).WithMany(t => t.PackageSendingAddress);
            modelBuilder.Entity<Package>().HasOne(t => t.DeliveryAddressEntity).WithMany(t => t.PackageDeliveryAddress);
            modelBuilder.Entity<Package>().HasOne(t => t.EmployeeEntity).WithMany(t => t.PackageEntites);
            modelBuilder.Entity<Package>().HasOne(t => t.CargoCategoryEntity).WithMany(t => t.PackageEntites);
            modelBuilder.Entity<Package>().HasOne(t => t.CarEntity).WithMany(t => t.PackageEntites);

            //PointReception - 2 
            modelBuilder.Entity<PointReception>().HasOne(t => t.EmployeeEntity).WithMany(t => t.PointReceptionEntites);
            modelBuilder.Entity<PointReception>().HasOne(t => t.WarehouseEntity).WithMany(t => t.PointReceptionEntites);

            //Warehouse - 1
            modelBuilder.Entity<Warehouse>().HasOne(t => t.EmployeeEntity).WithMany(t => t.WarehouseEntites);
            


        }

    }
}
