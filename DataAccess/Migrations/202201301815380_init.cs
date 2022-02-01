namespace StretchCeilingsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        Price = c.Decimal(precision: 18, scale: 2),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ceilings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        ManufacturerId = c.Int(),
                        TextureType = c.Int(),
                        ColorType = c.Int(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId)
                .Index(t => t.ManufacturerId);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        Country = c.Int(),
                        Address = c.String(maxLength: 2147483647),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 2147483647),
                        PhoneNumber = c.String(maxLength: 2147483647),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Area = c.Int(),
                        Type = c.Int(),
                        Corners = c.Int(),
                        EstateId = c.Int(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estates", t => t.EstateId)
                .Index(t => t.EstateId);
            
            CreateTable(
                "dbo.Estates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(maxLength: 2147483647),
                        CustomerId = c.Int(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 2147483647),
                        Login = c.String(maxLength: 2147483647),
                        Password = c.String(maxLength: 2147483647),
                        RoleId = c.Int(),
                        DeletedDate = c.DateTime(),
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
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(),
                        Comment = c.String(maxLength: 2147483647),
                        DateCreated = c.DateTime(nullable: false),
                        DeletedDate = c.DateTime(),
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
                        DeletedDate = c.DateTime(),
                        PaidByCash = c.Boolean(),
                        Status = c.Int(),
                        Total = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.OrderEmployees",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.EmployeeId })
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.EmployeeId);
            
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
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerId = c.Int(),
                        CeilingId = c.Int(),
                        RoomId = c.Int(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ceilings", t => t.CeilingId)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerId)
                .ForeignKey("dbo.Rooms", t => t.RoomId)
                .Index(t => t.ManufacturerId)
                .Index(t => t.CeilingId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.OrderWorkDates",
                c => new
                    {
                        OrderId = c.Int(nullable: false),
                        DateOfWork = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderId, t.DateOfWork })
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        Code = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.RolePermissions",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        PermissionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.PermissionId })
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.TimeTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(),
                        Date = c.DateTime(),
                        TimeStart = c.DateTime(),
                        TimeEnd = c.DateTime(),
                        DeletedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.ServiceAdditionalServices",
                c => new
                    {
                        ServiceId = c.Int(nullable: false),
                        AdditionalServiceId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServiceId, t.AdditionalServiceId })
                .ForeignKey("dbo.AdditionalServices", t => t.AdditionalServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.AdditionalServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceAdditionalServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ServiceAdditionalServices", "AdditionalServiceId", "dbo.AdditionalServices");
            DropForeignKey("dbo.TimeTables", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.RolePermissions", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RolePermissions", "PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.OrderWorkDates", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.Services", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Services", "ManufacturerId", "dbo.Manufacturers");
            DropForeignKey("dbo.Services", "CeilingId", "dbo.Ceilings");
            DropForeignKey("dbo.OrderServices", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderEmployees", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderEmployees", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Logs", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Employees", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Rooms", "EstateId", "dbo.Estates");
            DropForeignKey("dbo.Estates", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Ceilings", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.ServiceAdditionalServices", new[] { "AdditionalServiceId" });
            DropIndex("dbo.ServiceAdditionalServices", new[] { "ServiceId" });
            DropIndex("dbo.TimeTables", new[] { "EmployeeId" });
            DropIndex("dbo.RolePermissions", new[] { "PermissionId" });
            DropIndex("dbo.RolePermissions", new[] { "RoleId" });
            DropIndex("dbo.Permissions", new[] { "Code" });
            DropIndex("dbo.OrderWorkDates", new[] { "OrderId" });
            DropIndex("dbo.Services", new[] { "RoomId" });
            DropIndex("dbo.Services", new[] { "CeilingId" });
            DropIndex("dbo.Services", new[] { "ManufacturerId" });
            DropIndex("dbo.OrderServices", new[] { "ServiceId" });
            DropIndex("dbo.OrderServices", new[] { "OrderId" });
            DropIndex("dbo.OrderEmployees", new[] { "EmployeeId" });
            DropIndex("dbo.OrderEmployees", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Logs", new[] { "OrderId" });
            DropIndex("dbo.Employees", new[] { "RoleId" });
            DropIndex("dbo.Estates", new[] { "CustomerId" });
            DropIndex("dbo.Rooms", new[] { "EstateId" });
            DropIndex("dbo.Ceilings", new[] { "ManufacturerId" });
            DropTable("dbo.ServiceAdditionalServices");
            DropTable("dbo.TimeTables");
            DropTable("dbo.RolePermissions");
            DropTable("dbo.Permissions");
            DropTable("dbo.OrderWorkDates");
            DropTable("dbo.Services");
            DropTable("dbo.OrderServices");
            DropTable("dbo.OrderEmployees");
            DropTable("dbo.Orders");
            DropTable("dbo.Logs");
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
            DropTable("dbo.Estates");
            DropTable("dbo.Rooms");
            DropTable("dbo.Customers");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Ceilings");
            DropTable("dbo.AdditionalServices");
        }
    }
}
