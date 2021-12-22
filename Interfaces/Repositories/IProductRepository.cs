using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IProductRepository
    {
        List<Product> Get(Product filter, int count, int page);
        string Add(Product product);
        string Delete(Product product);
        string Change(int oldProduct, Product newProduct);
    }
}
