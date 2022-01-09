using System.Collections.Generic;
using stretch_ceilings_app.Data.Models;

namespace stretch_ceilings_app.Interfaces.Models
{
    public interface IManufacturer
    {
        void Add();
        void Update();
        void Delete();
        List<Ceiling> GetCeilings();
        List<ManufacturerOrder> GetOrders();
    }
}
