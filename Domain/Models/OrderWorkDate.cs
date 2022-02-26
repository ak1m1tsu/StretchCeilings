using System;
using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class OrderWorkDate : IDbModel
    {
        /// <summary>
        /// order identifier
        /// </summary>
        [Column("OrderId")] 
        public int? OrderId { get; set; }
        /// <summary>
        /// order
        /// </summary>
        [Column("OrderId")] 
        public virtual Order Order { get; set; }
        /// <summary>
        /// work date
        /// </summary>
        public DateTime DateOfWork { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.OrderWorkDates.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.OrderWorkDates.Find(OrderId, DateOfWork);

                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.OrderWorkDates.Find(OrderId, DateOfWork);

                if (old == null)
                    return;

                db.OrderWorkDates.Remove(old);
                db.SaveChanges();
            }
        }
    }
}
