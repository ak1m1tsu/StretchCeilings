using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IOrderRepository
    {
        List<Order> Get(Order filter, int count, int page); 
        string Add(Order order); 
        string Delete(Order order); 
        string Change(int oldOrder, Order newOrder);
    }
}
