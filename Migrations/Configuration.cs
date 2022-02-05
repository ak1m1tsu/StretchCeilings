using System.Data.Entity.Migrations;
using System.Data.SQLite.EF6.Migrations;
using StretchCeilings.DataAccess;

namespace StretchCeilings.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<StretchCeilingsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());
        }

        protected override void Seed(StretchCeilingsContext context) { }
    }
}
