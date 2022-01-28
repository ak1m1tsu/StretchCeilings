using System.Collections.Generic;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Interfaces.Models
{
    public interface ICustomer
    {
        void Add();
        void Update();
        void Delete();
        List<Estate> GetEstates();
    }
}
