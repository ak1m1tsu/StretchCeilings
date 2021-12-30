namespace stretch_ceilings_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {

        public override void Up()
        {
            CreateTable(
                "dbo.RolePermissions",
                c => new
                {
                    RoleId = c.Int(nullable: false),
                    PermissionId = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.RoleId, t.PermissionId })
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.PermissionId);

            CreateTable(
                "dbo.ServiceAdditServices",
                c => new
                {
                    ServiceId = c.Int(nullable: false),
                    AdditServiceId = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.ServiceId, t.AdditServiceId })
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.AdditionalServices", t => t.AdditServiceId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.AdditServiceId);

            CreateTable(
                "dbo.OrderServices",
                c => new
                {
                    OrderId = c.Int(nullable: false),
                    ServiceId = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.OrderId, t.ServiceId })
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ServiceId);

            CreateTable(
                "dbo.AdditionalServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        Price = c.Decimal(precision: 18, scale: 2),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ceilings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        ManufacturerId = c.Int(),
                        Texture = c.Int(nullable: false),
                        Color = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 2147483647),
                        Country = c.String(nullable: false, maxLength: 2147483647),
                        Address = c.String(nullable: false, maxLength: 2147483647),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 2147483647),
                        PhoneNumber = c.String(maxLength: 2147483647),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 2147483647),
                        Login = c.String(nullable: false, maxLength: 2147483647),
                        Password = c.String(nullable: false, maxLength: 2147483647),
                        RoleId = c.Int(),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Estates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false, maxLength: 2147483647),
                        CustomerId = c.Int(),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.ManufacturerOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerId = c.Int(),
                        CeilingId = c.Int(),
                        DateFilled = c.DateTime(),
                        DateComming = c.DateTime(),
                        Total = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ceilings", t => t.CeilingId)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId)
                .Index(t => t.ManufacturerId)
                .Index(t => t.CeilingId);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(),
                        Comment = c.String(nullable: false, maxLength: 2147483647),
                        DateCreated = c.DateTime(),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(),
                        DatePlaced = c.DateTime(),
                        DateOfMeasurements = c.DateTime(),
                        DatePaid = c.DateTime(),
                        DateCanceled = c.DateTime(),
                        DateDeleted = c.DateTime(),
                        PaidByCash = c.Boolean(),
                        Status = c.Int(nullable: false),
                        Total = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Area = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Corners = c.Int(nullable: false),
                        EstateId = c.Int(),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estates", t => t.EstateId)
                .Index(t => t.EstateId);
            
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(),
                        Date = c.DateTime(),
                        TimeStart = c.DateTime(),
                        TimeEnd = c.DateTime(),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerId = c.Int(),
                        CeilingId = c.Int(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        DeteDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ceilings", t => t.CeilingId)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId)
                .Index(t => t.ManufacturerId)
                .Index(t => t.CeilingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolesPermissions", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RolesPermissions", "PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.ServiceAdditServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ServiceAdditServices", "AdditServiceId", "dbo.AdditionalServices");
            DropForeignKey("dbo.OrderServices", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderServices", "ServiceId", "dbo.Services");
            DropIndex("dbo.RolesPermissions", new[] { "RoleId" });
            DropIndex("dbo.RolesPermissions", new[] { "PermissionId" });
            DropIndex("dbo.ServiceAdditServices", new[] { "ServiceId" });
            DropIndex("dbo.ServiceAdditServices", new[] { "AdditServiceId" });
            DropIndex("dbo.OrderServices", new[] { "OrderId" });
            DropIndex("dbo.OrderServices", new[] { "ServiceId" });
            DropTable("dbo.RolesPermissions");
            DropTable("dbo.ServiceAdditServices");
            DropTable("dbo.OrderServices");
            DropForeignKey("dbo.Services", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Services", "CeilingId", "dbo.Ceilings");
            DropForeignKey("dbo.Schedule", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Rooms", "EstateId", "dbo.Estates");
            DropForeignKey("dbo.Logs", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.ManufacturerOrders", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.ManufacturerOrders", "CeilingId", "dbo.Ceilings");
            DropForeignKey("dbo.Estates", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Employees", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Ceilings", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Services", new[] { "CeilingId" });
            DropIndex("dbo.Services", new[] { "ManufacturerId" });
            DropIndex("dbo.Schedule", new[] { "EmployeeId" });
            DropIndex("dbo.Rooms", new[] { "EstateId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Logs", new[] { "OrderId" });
            DropIndex("dbo.ManufacturerOrders", new[] { "CeilingId" });
            DropIndex("dbo.ManufacturerOrders", new[] { "ManufacturerId" });
            DropIndex("dbo.Estates", new[] { "CustomerId" });
            DropIndex("dbo.Employees", new[] { "RoleId" });
            DropIndex("dbo.Ceilings", new[] { "ManufacturerId" });
            DropTable("dbo.Services");
            DropTable("dbo.Schedule");
            DropTable("dbo.Rooms");
            DropTable("dbo.Permissions");
            DropTable("dbo.Orders");
            DropTable("dbo.Logs");
            DropTable("dbo.ManufacturerOrders");
            DropTable("dbo.Estates");
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Ceilings");
            DropTable("dbo.AdditionalServices");
        }
    }
}
