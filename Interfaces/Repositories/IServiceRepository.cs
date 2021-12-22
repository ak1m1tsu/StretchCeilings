using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IServiceRepository
    {
        List<Service> Get(Service filter, int count, int page); 
        string Add(Service service); 
        string Delete(Service service); 
        string Change(int oldService, Service newService);
     }
}
