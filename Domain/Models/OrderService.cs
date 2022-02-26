using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class OrderService : IDbModel
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
        /// service identifier
        /// </summary>
        [Column("ServiceId")] 
        public int? ServiceId { get; set; }
        /// <summary>
        /// service
        /// </summary>
        [Column("ServiceId")] 
        public virtual Service Service { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.OrderServices.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.OrderServices.Find(OrderId, ServiceId);

                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.OrderServices.Find(OrderId, ServiceId);

                if (old == null)
                    return;

                db.OrderServices.Remove(old);
                db.SaveChanges();
            }
        }
    }
}
