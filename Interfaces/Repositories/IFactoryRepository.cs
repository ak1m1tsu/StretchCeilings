using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IFactoryRepository
    {
        List<Factory> Get(Factory filter, int count, int page);
        string Add(Factory factory);
        string Delete(Factory factory);
        string Change(int oldFactory, Factory newFactory);
    }
}
