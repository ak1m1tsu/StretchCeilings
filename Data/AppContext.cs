using SQLite.CodeFirst;
using stretch_ceilings_app.Models;
using System.Data.Entity;
using System.Data.SQLite;

namespace stretch_ceilings_app.Data
{
    public class AppContext : DbContext
    {
        AppContext() : base("Default") { }

        // Модели бизнес логики
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<FactoryOrder> FactoryOrders { get; set; }
        public DbSet<TimeTable> Schedules { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Log> OrderLogs { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<OrderService> OrderServices { get; set; }
        public DbSet<OrderEmployee> OrderEmployees { get; set; }

        // Права и роли пользователей системы
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RolePermission>()
                .HasKey(k => new { k.RoleID, k.PermissionID });
            modelBuilder.Entity<OrderService>()
                .HasKey(k => new { k.OrderID, k.ServiceID });
            modelBuilder.Entity<OrderEmployee>()
                .HasKey(k => new { k.OrderID, k.EmployeeID });


            var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<AppContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);

            var model = modelBuilder.Build(Database.Connection);
            ISqlGenerator sqlGenerator = new SqliteSqlGenerator();
            sqlGenerator.Generate(model.StoreModel);
        }
    }
}
