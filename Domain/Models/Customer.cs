using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class Customer : ICustomer
    {
        /// <summary>
        /// identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// full name
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// phone number
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// deleted date
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Customers.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                DeletedDate = DateTime.Now;
                var old = db.Customers.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
        
        /// <inheritdoc />
        public IList<Estate> GetEstates()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Estates.Where(e => e.CustomerId == Id && e.DeletedDate == null)
                    .ToList();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Customers.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public IList<Order> GetOrders()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Orders.Where(o => o.CustomerId == Id && o.DeletedDate == null)
                    .OrderByDescending(x => x.Total)
                    .ToList();
            }
        }

        public IList<Service> GetServices()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Services
                    .Join(db.OrderServices, s => s.Id, os => os.ServiceId, (s, os) => new { s, os })
                    .Join(db.Orders, @t => @t.os.OrderId, o => o.Id, (@t, o) => new { @t, o })
                    .Where(@t => @t.o.CustomerId == Id && @t.o.DeletedDate == null)
                    .Select(@t => @t.@t.s)
                    .OrderByDescending(@t => @t.Price)
                    .Include(x => x.Manufacturer)
                    .Include(x => x.Ceiling)
                    .Include(x => x.Room)
                    .ToList();
            }
        }

        /// <inheritdoc />
        public int GetOrdersCount(DateTime dateFrom, DateTime dateUntil)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Orders.Count(o => o.CustomerId == Id && o.DeletedDate == null && dateFrom <= o.DatePlaced &&
                                            o.DatePlaced <= dateUntil);
            }
        }
    }
}