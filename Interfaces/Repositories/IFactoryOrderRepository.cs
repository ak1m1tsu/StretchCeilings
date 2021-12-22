using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IFactoryOrderRepository
    {
        List<FactoryOrder> Get(FactoryOrder filter, int count, int page);
        string Add(FactoryOrder order);
        string Delete(FactoryOrder order);
        string Change(int oldOrder, FactoryOrder newOrder);
    }
}
