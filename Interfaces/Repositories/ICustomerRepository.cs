using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> Get(Customer filter, int count, int page); 
        string Add(Customer customer); 
        string Delete(Customer customer); 
        string Change(int oldCustomer, Customer newCustomer);
     }
}
