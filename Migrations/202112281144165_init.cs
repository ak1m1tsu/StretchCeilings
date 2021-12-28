﻿namespace stretch_ceilings_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
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
                        RoleID = c.Int(nullable: false),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Estates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false, maxLength: 2147483647),
                        CustomerId = c.Int(nullable: false),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Factories",
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
                "dbo.FactoryOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FactoryId = c.Int(nullable: false),
                        DateFilled = c.DateTime(),
                        DateComming = c.DateTime(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factories", t => t.FactoryId, cascadeDelete: true)
                .Index(t => t.FactoryId);
            
            CreateTable(
                "dbo.OrderLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        Comment = c.String(nullable: false, maxLength: 2147483647),
                        DateCanceled = c.DateTime(),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        DatePlaced = c.DateTime(),
                        DateOfMeasurements = c.DateTime(),
                        DatePaid = c.DateTime(),
                        DateCanceled = c.DateTime(),
                        DateDeleted = c.DateTime(),
                        PaidByCash = c.Boolean(nullable: false),
                        Status = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        Code = c.String(nullable: false, maxLength: 2147483647),
                        DateDeleted = c.DateTime(),
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
                        EstateId = c.Int(nullable: false),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estates", t => t.EstateId, cascadeDelete: true)
                .Index(t => t.EstateId);
            
            CreateTable(
                "dbo.Schedule",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(),
                        TimeStart = c.DateTime(),
                        TimeEnd = c.DateTime(),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        Description = c.String(maxLength: 2147483647),
                        FactoryId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Pipes = c.Int(nullable: false),
                        Lamps = c.Int(nullable: false),
                        Backlight = c.Boolean(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeteDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factories", t => t.FactoryId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.FactoryId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2147483647),
                        Description = c.String(maxLength: 2147483647),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateDeleted = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Services", "FactoryId", "dbo.Factories");
            DropForeignKey("dbo.Rooms", "EstateId", "dbo.Estates");
            DropForeignKey("dbo.OrderLogs", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.FactoryOrders", "FactoryId", "dbo.Factories");
            DropForeignKey("dbo.Estates", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Employees", "RoleID", "dbo.Roles");
            DropIndex("dbo.Services", new[] { "ProductId" });
            DropIndex("dbo.Services", new[] { "FactoryId" });
            DropIndex("dbo.Rooms", new[] { "EstateId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.OrderLogs", new[] { "OrderId" });
            DropIndex("dbo.FactoryOrders", new[] { "FactoryId" });
            DropIndex("dbo.Estates", new[] { "CustomerId" });
            DropIndex("dbo.Employees", new[] { "RoleID" });
            DropTable("dbo.Products");
            DropTable("dbo.Services");
            DropTable("dbo.Schedule");
            DropTable("dbo.Rooms");
            DropTable("dbo.Permissions");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderLogs");
            DropTable("dbo.FactoryOrders");
            DropTable("dbo.Factories");
            DropTable("dbo.Estates");
            DropTable("dbo.Roles");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
