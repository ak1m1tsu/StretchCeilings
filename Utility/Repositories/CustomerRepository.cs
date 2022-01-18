using System.Collections.Generic;
using System.Linq;
using stretch_ceilings_app.Data;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Utility.Repositories
{
    public static class CustomerRepository
    {
        public static List<Customer> GetCustomers(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var customers = db.Customers.Where(o => o.DateDeleted == null).ToList();
                rows = 0;
                if (customers.Any())
                {
                    rows = customers.Count;
                }

                return customers;
            }
        }

        public static List<Customer> GetOrders(Customer filter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var customers = db.Customers.Where(o => o.Equals(filter)).ToList();
                rows = 0;

                if (customers.Any())
                {
                    rows = customers.Count;
                    customers = customers.Skip((page - 1) * count).Take(count).ToList();
                }

                return customers;
            }
        }

        public static Customer GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var customer = db.Customers.FirstOrDefault(o => o.Id == id);

                return customer;
            }
        }
    }
}
