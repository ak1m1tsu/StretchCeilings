using System.Collections.Generic;
using StretchCeilings.Models;

namespace StretchCeilings.Interfaces.Models
{
    public interface IEmployee
    {
        void Add();
        void Update();
        void Delete();
        List<TimeTable> GetSchedule();
        List<Order> GetOrders(int count, int pages);
        List<Service> GetServices(int count, int pages);
    }
}
