using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
using stretch_ceilings_app.Data;

namespace stretch_ceilings_app.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(ApplicationContext context) { }
    }
}
