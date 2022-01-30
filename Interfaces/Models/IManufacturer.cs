using System.Collections.Generic;
using StretchCeilings.Models;

namespace StretchCeilings.Interfaces.Models
{
    public interface IManufacturer
    {
        void Add();
        void Update();
        void Delete();
        List<Ceiling> GetCeilings();
    }
}
