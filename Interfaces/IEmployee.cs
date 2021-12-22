using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IEmployee
    {
        bool Can(Permission permission);
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
