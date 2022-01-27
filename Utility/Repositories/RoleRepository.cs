using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class RoleRepository
    {
        public static List<Role> GetAll()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Roles.ToList();
            }
        }
    }
}
