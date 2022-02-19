using System.Collections.Generic;

namespace StretchCeilings.Domain
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T FindById(int id);
    }
}