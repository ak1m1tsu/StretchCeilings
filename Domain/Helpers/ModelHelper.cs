using StretchCeilings.Domain.Models;

namespace StretchCeilings.Domain.Helpers
{
    /// <summary>
    /// Presents entity properties checker
    /// </summary>
    public static class ModelHelper
    {
        /// <summary>
        /// Check <see cref="Manufacturer"/> properties
        /// </summary>
        /// <param name="manufacturer">source</param>
        /// <returns>
        /// <see langword="true"/> if some property is null; otherwise <see langword="false"/>
        /// </returns>
        public static bool HasNullField(this Manufacturer manufacturer)
        {
            return manufacturer?.Address == null ||
                   manufacturer.Name == null ||
                   manufacturer.Country == null ||
                   manufacturer.Id == 0;
        }

        /// <summary>
        /// Check <see cref="Estate"/> properties
        /// </summary>
        /// <param name="estate">source</param>
        /// <returns>
        /// <see langword="true"/> if some property is null; otherwise <see langword="false"/>
        /// </returns>
        public static bool HasNullField(this Estate estate)
        {
            return estate?.Address == null ||
                   estate.Id == 0;
        }

        /// <summary>
        /// Check <see cref="Order"/> properties
        /// </summary>
        /// <param name="order">source</param>
        /// <returns>
        /// <see langword="true"/> if some property is null; otherwise <see langword="false"/>
        /// </returns>
        public static bool HasNullField(this Order order)
        {
            return order?.Total == null ||
                   order.Status == null ||
                   order.CustomerId == null ||
                   order.PaidByCash == null ||
                   order.DateOfMeasurements == null;
        }

        /// <summary>
        /// Check <see cref="Customer"/> properties
        /// </summary>
        /// <param name="customer">source</param>
        /// <returns>
        /// <see langword="true"/> if some property is null; otherwise <see langword="false"/>
        /// </returns>
        public static bool HasNullField(this Customer customer)
        {
            return customer?.FullName == null ||
                   customer.PhoneNumber == null ||
                   customer.Id == 0;
        }

        /// <summary>
        /// Check <see cref="Employee"/> properties
        /// </summary>
        /// <param name="employee">source</param>
        /// <returns>
        /// <see langword="true"/> if some property is null; otherwise <see langword="false"/>
        /// </returns>
        public static bool HasNullField(this Employee employee)
        {
            return employee?.FullName == null ||
                   employee.Login == null ||
                   employee.Password == null ||
                   employee.Id == 0;
        }

        /// <summary>
        /// Check <see cref="Service"/> properties
        /// </summary>
        /// <param name="service">source</param>
        /// <returns>
        /// <see langword="true"/> if some property is null; otherwise <see langword="false"/>
        /// </returns>
        public static bool HasNullField(this Service service)
        {
            return service?.Price == null ||
                   service.Id == 0;
        }

        /// <summary>
        /// Check <see cref="Room"/> properties
        /// </summary>
        /// <param name="room">source</param>
        /// <returns>
        /// <see langword="true"/> if some property is null; otherwise <see langword="false"/>
        /// </returns>
        public static bool HasNullField(this Room room)
        {
            return room?.Area == null ||
                   room.Corners == null ||
                   room.Type == null ||
                   room.Plane == null ||
                   room.Id == 0;
        }
    }
}
