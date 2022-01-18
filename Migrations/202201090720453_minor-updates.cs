namespace stretch_ceilings_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class minorupdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ManufacturerOrders", "RoomId", c => c.Int());
            AddColumn("dbo.ManufacturerOrders", "DateDeleted", c => c.DateTime());
            CreateIndex("dbo.ManufacturerOrders", "RoomId");
            AddForeignKey("dbo.ManufacturerOrders", "RoomId", "dbo.Rooms", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ManufacturerOrders", "RoomId", "dbo.Rooms");
            DropIndex("dbo.ManufacturerOrders", new[] { "RoomId" });
            DropColumn("dbo.ManufacturerOrders", "DateDeleted");
            DropColumn("dbo.ManufacturerOrders", "RoomId");
        }
    }
}
