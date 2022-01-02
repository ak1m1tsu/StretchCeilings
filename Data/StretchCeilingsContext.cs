using System.Data.Entity;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Data
{
    public class StretchCeilingsContext : DbContext
    {
        public StretchCeilingsContext() 
            : base("Default") { }

        // Tables for business logic
        public DbSet<AdditionalService> AdditionalServices { get; set; }
        public DbSet<Ceiling> Ceilings { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ManufacturerOrder> FManufacturerOrders { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<TimeTable> Schedules { get; set; }

        // Tables for user session
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}
