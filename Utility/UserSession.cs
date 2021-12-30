using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Models;
using stretch_ceilings_app.Utility.Enums;

namespace stretch_ceilings_app.Utility
{
    public static class UserSession
    {
        private static Employee _currentUser;

        public static Employee User { get { return _currentUser; } }

        public static bool LogIn(List<Employee> users, string login, string password)
        {
            foreach (var user in users)
            {
                if (user.Login == login && user.Password == password)
                {
                    _currentUser = user;
                    return true;
                }
            }

            return false;
        }

        public static bool Can(PermissionCode code)
        {
            using (StretchCeilingsContext db = new StretchCeilingsContext())
            {
                if (_currentUser is null) 
                    return false;

                if (_currentUser.RoleId == 1) 
                    return true;

                if (_currentUser.Role.GetPermissions().Any(p => p.Code == code))
                    return true;

                return false;
            }
        }
    }
}
