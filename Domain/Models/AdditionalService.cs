using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class AdditionalService : IDbModel
    {
        /// <summary>
        /// identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// price
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        /// deleted date
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.AdditionalServices.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.AdditionalServices.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                DeletedDate = DateTime.Now;
                var old = db.AdditionalServices.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Returns additional services count in order for same period
        /// </summary>
        /// <param name="dateFrom">date from</param>
        /// <param name="dateUntil">date until</param>
        /// <returns>
        /// additional services count
        /// </returns>
        public int CountInOrders(DateTime dateFrom, DateTime dateUntil)
        {
            using (var db = new StretchCeilingsContext())
            {
                var count = db.AdditionalServices
                    .Join(db.ServiceAdditionalServices, ads => ads.Id, sas => sas.AdditionalServiceId,
                        (ads, sas) => new { ads, sas })
                    .Join(db.Services, @t => @t.sas.ServiceId, s => s.Id, (@t, s) => new { @t, s })
                    .Join(db.OrderServices, @t => @t.s.Id, os => os.ServiceId, (@t, os) => new { @t, os })
                    .Join(db.Orders, @t => @t.os.OrderId, o => o.Id, (@t, o) => new { @t, o })
                    .Where(@t =>
                        dateFrom <= @t.o.DatePlaced && @t.o.DatePlaced <= dateUntil && @t.o.DeletedDate == null)
                    .Select(@t => @t.@t.@t.@t.sas.Count);

                return count.Any() == false ? 0 : count.Sum();
            }
        }
    }
}