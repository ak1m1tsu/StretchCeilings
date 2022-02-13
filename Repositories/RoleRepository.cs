using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
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
