using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IFactory
    {
        List<Product> GetProduct();
        string AddProduct(Product product);
        string DeleteProduct(Product product);
        List<FactoryOrder> GetOrders();
        string AddOrder(FactoryOrder order);
        string DeleteOrder(FactoryOrder order);
    }
}
