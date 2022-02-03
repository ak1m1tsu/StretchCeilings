using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Models;
using StretchCeilings.Repositories;

namespace StretchCeilings.Helpers
{
    public static class UserSession
    {
        private static Employee _user;

        public static bool LogIn(string login, string password)
        {
            _user = EmployeeRepository.GetUser(login, password);
            return _user != null;
        }

        public static bool IsAdmin
        {
            get
            {
                using (var db = new StretchCeilingsContext())
                {
                    return _user != null && _user.Role.GetPermissions().Any(p => p.Code == PermissionCode.All);
                }
            }
        }

        public static bool Can(PermissionCode code)
        {
            using (var db = new StretchCeilingsContext())
            {
                return _user != null && _user.Role.GetPermissions().Any(p => p.Code == code);
            }
        }
    }
}
