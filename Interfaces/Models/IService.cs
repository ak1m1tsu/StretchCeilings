using System.Collections.Generic;
using StretchCeilings.Models;

namespace StretchCeilings.Interfaces.Models
{
    public interface IService
    {
        void Add();
        void Update();
        void Delete();
        List<ServiceAdditionalService> GetAdditionalServices();
    }
}
