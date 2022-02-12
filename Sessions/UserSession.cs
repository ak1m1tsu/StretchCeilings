using System.Linq;
using StretchCeilings.Models;
using StretchCeilings.Models.Enums;
using StretchCeilings.Repositories;

namespace StretchCeilings.Sessions
{
    public class UserSession
    {
        private static Employee _user;

        public static bool TryLogin(string login, string password)
        {
            _user = EmployeeRepository.GetUser(login, password);
            return _user != null;
        }

        public static bool IsAdmin => _user != null &&
                                      _user.Role.GetPermissions()
                                                .Any(p => p.Code == PermissionCode.All);

        public static bool Can(PermissionCode code)
        {
            return _user != null && _user.Role.GetPermissions().Any(p => p.Code == code);
        }
    }
}
