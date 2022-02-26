using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class Estate : IEstate
    {
        /// <summary>
        /// identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// customer identifier
        /// </summary>
        [Column("CustomerId")]
        public int? CustomerId { get; set; }
        /// <summary>
        /// customer
        /// </summary>
        [Column("CustomerId")]
        public virtual Customer Customer { get; set; }
        /// <summary>
        /// deleted date
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Estates.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                DeletedDate = DateTime.Now;
                var old = db.Estates.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public IEnumerable<Room> GetRooms()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.CustomersRooms.Where(r => r.EstateId == Id && r.DeletedDate == null).ToList();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Estates.FirstOrDefault(x => x.Id == Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }
}