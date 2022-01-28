using System.Collections.Generic;
using System.Linq;
using StretchCeilingsApp.Data;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Utility.Repositories
{
    public static class RoleModelsRepository
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
