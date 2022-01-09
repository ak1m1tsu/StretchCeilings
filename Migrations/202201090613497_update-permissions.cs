namespace stretch_ceilings_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatepermissions : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Permissions", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Permissions", new[] { "Code" });
        }
    }
}
