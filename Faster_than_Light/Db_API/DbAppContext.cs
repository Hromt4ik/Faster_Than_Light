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
                "Host=localhost;Username=postgres;Password=123;Database=tut");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Phone>().HasOne(p => p.CompanyEntity).WithMany(p => p.PhoneEntites);

            //Car - 2 
            modelBuilder.Entity<Car>().HasOne(t => t.LocationBaseEntity).WithMany(t => t.CarEntites).IsRequired(false);
            modelBuilder.Entity<Car>().HasOne(t => t.EmployeeEntity).WithMany(t => t.CarEntites).IsRequired(false);

            //CargoCategory - 0
            //Client - 0
            //DriverIdentification - 1
            modelBuilder.Entity<DriverIdentification>().HasOne(t => t.EmployeeEntity).WithMany(t => t.DriverIdentificationEntites).IsRequired(false);
            
            //Employee - 0
            //LocationBase - 1
            modelBuilder.Entity<LocationBase>().HasOne(t => t.EmployeeEntity).WithMany(t => t.LocationBaseEntites).IsRequired(false);

            //Package - 6
            modelBuilder.Entity<Package>().HasOne(t => t.ClientEntity).WithMany(t => t.PackageEntites).IsRequired(false);
            modelBuilder.Entity<Package>().HasOne(t => t.SendingAddressEntity).WithMany(t => t.PackageSendingAddress).IsRequired(false);
            modelBuilder.Entity<Package>().HasOne(t => t.DeliveryAddressEntity).WithMany(t => t.PackageDeliveryAddress).IsRequired(false);
            modelBuilder.Entity<Package>().HasOne(t => t.EmployeeEntity).WithMany(t => t.PackageEntites).IsRequired(false);
            modelBuilder.Entity<Package>().HasOne(t => t.CargoCategoryEntity).WithMany(t => t.PackageEntites).IsRequired(false);
            modelBuilder.Entity<Package>().HasOne(t => t.CarEntity).WithMany(t => t.PackageEntites).IsRequired(false);

            //PointReception - 2 
            modelBuilder.Entity<PointReception>().HasOne(t => t.EmployeeEntity).WithMany(t => t.PointReceptionEntites).IsRequired(false);
            modelBuilder.Entity<PointReception>().HasOne(t => t.WarehouseEntity).WithMany(t => t.PointReceptionEntites).IsRequired(false);

            //Warehouse - 1
            modelBuilder.Entity<Warehouse>().HasOne(t => t.EmployeeEntity).WithMany(t => t.WarehouseEntites).IsRequired(false);
            


        }

    }
}
