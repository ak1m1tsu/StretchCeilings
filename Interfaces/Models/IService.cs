using System.Collections.Generic;
using StretchCeilingsApp.Data.Models;

namespace StretchCeilingsApp.Interfaces.Models
{
    public interface IService
    {
        void Add();
        void Update();
        void Delete();
        List<AdditionalService> GetAdditionalServices();
    }
}
