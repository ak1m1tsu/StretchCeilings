using System;
using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    public class OrderWorkDate : IDbModel
    {
        [Column("OrderId")] 
        public int? OrderId { get; set; }
        [Column("OrderId")] 
        public virtual Order Order { get; set; }
        public DateTime DateOfWork { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.OrderWorkDates.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.OrderWorkDates.Find(OrderId, DateOfWork);

                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

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
