namespace stretch_ceilings_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rolepermissions : DbMigration
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
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolesPermissions", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RolesPermissions", "PermissionId", "dbo.Permissions");
            DropIndex("dbo.RolesPermissions", new[] { "RoleId" });
            DropIndex("dbo.RolesPermissions", new[] { "PermissionId" });
            DropTable("dbo.RolesPermissions");
        }
    }
}
