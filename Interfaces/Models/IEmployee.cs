using System.Collections.Generic;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Interfaces.Models
{
    public interface IEmployee
    {
        string Add();
        string Update();
        string Delete();
        List<TimeTable> GetSchedule();
        string AddTimeTable(TimeTable timeTable);
        string DeleteTimeTable(TimeTable timeTable);
        List<Order> GetOrders(int count, int pages);
        string AddOrder(Order order);
        string DeleteOrder(Order order);
        List<Service> GetServices(int count, int pages);
        string AddService(Service service);
        string DeleteService(Service service);
    }
}
