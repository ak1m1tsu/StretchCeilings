namespace stretch_ceilings_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderworkdaystable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.OrderWorkdays",
                    c => new
                    {
                        OrderId = c.Int(nullable: false),
                        DateOfWork = c.DateTime(nullable: false)
                    })
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderWorkdays", "OrderId", "dbo.Orders");
            DropIndex("dbo.OrderWorkdays", new[] { "OrderId" });
            DropTable("dbo.OrderWorkdays");
        }
    }
}
