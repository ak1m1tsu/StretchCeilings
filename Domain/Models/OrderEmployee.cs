using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class OrderEmployee : IDbModel
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
        /// employee identifier
        /// </summary>
        [Column("EmployeeId")] 
        public int? EmployeeId { get; set; }
        /// <summary>
        /// employee
        /// </summary>
        [Column("EmployeeId")]
        public virtual Employee Employee { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.OrderEmployees.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.OrderEmployees.Find(OrderId, EmployeeId);
                
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
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
