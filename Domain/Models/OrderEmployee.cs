using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    public class OrderEmployee : IDbModel
    {
        [Column("OrderId")] 
        public int? OrderId { get; set; }
        [Column("OrderId")]
        public virtual Order Order { get; set; }
        [Column("EmployeeId")] 
        public int? EmployeeId { get; set; }
        [Column("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.OrderEmployees.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.OrderEmployees.Find(OrderId, EmployeeId);
                
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.OrderEmployees.Find(OrderId, EmployeeId);
                
                if (old == null)
                    return;
                
                db.OrderEmployees.Remove(old);
                db.SaveChanges();
            }
        }
    }
}
