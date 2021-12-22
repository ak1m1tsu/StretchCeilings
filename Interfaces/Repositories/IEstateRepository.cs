using stretch_ceilings_app.Models;
using System.Collections.Generic;

namespace stretch_ceilings_app.Interfaces
{
    public interface IEstateRepository
    {
        List<Estate> Get(Estate filter, int count, int page);
        string Add(Estate estate);
        string Delete(Estate estate);
        string Change(int oldEstate, Estate newEstate);
    }
}
