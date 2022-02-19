using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess.Repositories;
using StretchCeilings.Domain.Models;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.Domain.Repositories;
using StretchCeilings.Domain.Services;

namespace StretchCeilings.App.Services
{
    public class AuthService : IAuthService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private const byte LOGIN_LENGTH = 16;
        private const char EMPTY_CHAR = ' ';

        public AuthService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public bool Login(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password) ||
                login.Contains(EMPTY_CHAR) ||
                login.Length < LOGIN_LENGTH)
                return false;
            
            var employee = _employeeRepository.FindByLogin(login);
            var isEmployeeExist = employee != null;

            if (isEmployeeExist)
            {
                UserSession.Initialize(employee);
            }

            return true;
        }
    }

    public class UserSession
    {
        private static IList<PermissionCode> _permission;

        public static void Initialize(Employee employee)
        {
            if (employee?.Role is null)
                return;

            if (_permission != null)
                return;

            _permission = employee.Role.GetPermissions()
                .Select(x => x.Code)
                .ToList();
        }

        public static bool IsAdmin => _permission.Contains(PermissionCode.All);

        public static bool Can(PermissionCode code) => _permission.Contains(code);
    }
}