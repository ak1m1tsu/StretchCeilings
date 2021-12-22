using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stretch_ceilings_app.Data
{
    public class AppContextInitializer : SqliteDropCreateDatabaseAlways<AppContext>
    {
        public AppContextInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder) { }

        protected override void Seed(AppContext context) { }
    }
}
