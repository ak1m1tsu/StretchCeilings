using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilings.DataAccess;

namespace StretchCeilings.Models
{
    public class ServiceAdditionalService
    {
        [Column("ServiceId")] 
        public int? ServiceId { get; set; }
        [Column("ServiceId")] 
        public virtual Service Service { get; set; }
        [Column("AdditionalServiceId")] 
        public int? AdditionalServiceId { get; set; }
        [Column("AdditionalServiceId")] 
        public virtual AdditionalService AdditionalService { get; set; }
        public int Count { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.ServiceAdditionalServices.Add(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                var service = db.ServiceAdditionalServices.First(x =>
                    x.AdditionalServiceId == AdditionalServiceId &&
                    x.ServiceId == ServiceId);

                db.ServiceAdditionalServices.Remove(service);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.ServiceAdditionalServices.FirstOrDefault(x =>
                    x.ServiceId == ServiceId &&
                    x.AdditionalServiceId == AdditionalServiceId);

                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public AdditionalService GetAdditionalService()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.AdditionalServices.FirstOrDefault(x => x.Id == AdditionalServiceId);
            }
        }
    }
}
