using System.Collections.Generic;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models;

namespace StretchCeilings.Repositories
{
    public static class TimeTableRepository
    {
        public static List<TimeTable> GetByEmployeeId(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Schedule.Where(x => x.EmployeeId == id && x.DeletedDate == null).ToList();
            }
        }

        public static TimeTable GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Schedule.FirstOrDefault(x => x.Id == id && x.DeletedDate == null);
            }
        }
    }
}
