using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Models.Interfaces;

namespace StretchCeilings.Models
{
    public class OrderService : IDbModel
    {
        [Column("OrderId")] 
        public int? OrderId { get; set; }
        [Column("OrderId")] 
        public virtual Order Order { get; set; }
        [Column("ServiceId")] 
        public int? ServiceId { get; set; }
        [Column("ServiceId")] 
        public virtual Service Service { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.OrderServices.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.OrderServices.Find(OrderId, ServiceId);

                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

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
