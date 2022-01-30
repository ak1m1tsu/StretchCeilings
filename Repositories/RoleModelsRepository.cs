using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public static class RoleModelsRepository
    {
        public static Role GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Roles.FirstOrDefault(x => x.Id == id);
            }
        }

        public static List<Role> GetAll()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Roles.ToList();
            }
        }
    }
}
