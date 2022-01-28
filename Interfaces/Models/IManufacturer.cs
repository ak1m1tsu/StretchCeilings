using System.Collections.Generic;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Interfaces.Models
{
    public interface IManufacturer
    {
        void Add();
        void Update();
        void Delete();
        List<Ceiling> GetCeilings();
    }
}
