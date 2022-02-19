using System.Data.Entity;
using StretchCeilings.Domain.Models;

namespace StretchCeilings.DataAccess
{
    public class StretchCeilingsContext : DbContext
    {
        public StretchCeilingsContext() 
            : base("Default") { }

        // Tables for business logic
        public DbSet<AdditionalService> AdditionalServices { get; set; }
        public DbSet<Ceiling> Ceilings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Room> CustomersRooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<TimeTable> Schedule { get; set; }


        public DbSet<ServiceAdditionalService> ServiceAdditionalServices { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<OrderWorkDate> OrderWorkDates { get; set; }
        public DbSet<OrderService> OrderServices { get; set; }
        public DbSet<OrderEmployee> OrderEmployees { get; set; }

        // Tables for user session
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEmployee>().HasKey(k => new { k.OrderId, k.EmployeeId });
            modelBuilder.Entity<OrderService>().HasKey(k => new { k.OrderId, k.ServiceId });
            modelBuilder.Entity<OrderWorkDate>().HasKey(k => new { k.OrderId, k.DateOfWork });
            modelBuilder.Entity<RolePermission>().HasKey(k => new { k.RoleId, k.PermissionId });
            modelBuilder.Entity<ServiceAdditionalService>().HasKey(k => new { k.ServiceId, k.AdditionalServiceId });
        }
    }
}
