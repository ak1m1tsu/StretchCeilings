using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <summary>
    /// Presents database entity
    /// </summary>
    public class ServiceAdditionalService : IDbModel
    {
        /// <summary>
        /// service identifier
        /// </summary>
        [Column("ServiceId")] 
        public int? ServiceId { get; set; }
        /// <summary>
        /// service
        /// </summary>
        [Column("ServiceId")] 
        public virtual Service Service { get; set; }
        /// <summary>
        /// additional service identifier
        /// </summary>
        [Column("AdditionalServiceId")] 
        public int? AdditionalServiceId { get; set; }
        /// <summary>
        /// additional service
        /// </summary>
        [Column("AdditionalServiceId")] 
        public virtual AdditionalService AdditionalService { get; set; }
        /// <summary>
        /// additional service count
        /// </summary>
        public int Count { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.ServiceAdditionalServices.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
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

        /// <inheritdoc />
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

        /// <summary>
        /// Returns additional service
        /// </summary>
        /// <returns>
        /// <see cref="AdditionalService"/>
        /// </returns>
        public AdditionalService GetAdditionalService()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.AdditionalServices.FirstOrDefault(x => x.Id == AdditionalServiceId);
            }
        }
    }
}
