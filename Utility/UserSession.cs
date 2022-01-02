using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Utility
{
    public static class UserSession
    {
        public static Employee User { get; private set; }

        public static bool LogIn(List<Employee> users, string login, string password)
        {
            User = users.FirstOrDefault(user => user.Login == login && user.Password == password);
            return User != null;
        }

        public static bool Can(PermissionCode code)
        {
            using (var db = new StretchCeilingsContext())
            {
                if (User == null) 
                    return false;

                return User.RoleId == 1 || User.Role.GetPermissions().Any(p => p.Code == code);
            }
        }
    }
}
