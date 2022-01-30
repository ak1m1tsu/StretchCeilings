using System.Collections.Generic;
using StretchCeilings.Models;

namespace StretchCeilings.Interfaces.Models
{
    public interface ICustomer
    {
        void Add();
        void Update();
        void Delete();
        List<Estate> GetEstates();
    }
}
