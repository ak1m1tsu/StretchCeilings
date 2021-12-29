using stretch_ceilings_app.Models;
using System.Data.Entity;

namespace stretch_ceilings_app.Data
{
    public class StretchCeilingsContext : DbContext
    {
        public StretchCeilingsContext() 
            : base("Default") { }

        // Модели бизнес логики
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<Manufacturer> Factories { get; set; }
        public DbSet<ManufacturerOrder> FactoryOrders { get; set; }
        public DbSet<TimeTable> Schedules { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Log> OrderLogs { get; set; }
        public DbSet<Estate> Estates { get; set; }

        // Права и роли пользователей системы
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}
