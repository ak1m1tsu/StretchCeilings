using StretchCeilings.Models;

namespace StretchCeilings.Helpers
{
    public static class ModelHelper
    {
        public static bool HasNullField(this Manufacturer manufacturer)
        {
            return manufacturer?.Address == null ||
                   manufacturer.Name == null ||
                   manufacturer.Country == null ||
                   manufacturer.Id == 0;
        }

        public static bool HasNullField(this Customer customer)
        {
            return customer?.FullName == null ||
                   customer.PhoneNumber == null ||
                   customer.Id == 0;
        }
        public static bool HasNullField(this Employee employee)
        {
            return employee?.FullName == null ||
                   employee.Login == null ||
                   employee.Password == null ||
                   employee.Id == 0;
        }

        public static bool HasNullField(this Service service)
        {
            return service?.Price == null ||
                   service.Id == 0;
        }
    }
}
