using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class Order : IOrder
    {
        /// <summary>
        /// identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
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
        /// placed date
        /// </summary>
        public DateTime? DatePlaced { get; set; }
        /// <summary>
        /// measurements date
        /// </summary>
        public DateTime? DateOfMeasurements { get; set; }
        /// <summary>
        /// paid date
        /// </summary>
        public DateTime? DatePaid { get; set; }
        /// <summary>
        /// canceled date
        /// </summary>
        public DateTime? DateCanceled { get; set; }
        /// <summary>
        /// deleted date
        /// </summary>
        public DateTime? DeletedDate { get; set; }
        /// <summary>
        /// paid by cash
        /// </summary>
        public bool? PaidByCash { get; set; }
        /// <summary>
        /// order status
        /// </summary>
        public OrderStatus? Status { get; set; }
        /// <summary>
        /// total price
        /// </summary>
        public decimal? Total { get; set; }

        /// <inheritdoc />
        public IEnumerable<OrderWorkDate> GetWorkDates()
        {
            using (var db = new StretchCeilingsContext())
            {
                return (db.OrderWorkDates
                    .Join(db.Orders, wd => wd.OrderId, o => o.Id, (wd, o) => new { wd, o })
                    .Where(@t => @t.o.DeletedDate == null && @t.o.Id == Id)
                    .Select(@t => @t.wd)).ToList();
            }
        }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Orders.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void CalculateTotal()
        {
            var services = GetServices();
            Total = 0;
            foreach (var service in services)
                Total += service.Price;
        }

        /// <inheritdoc />
        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                DeletedDate = DateTime.Now;
                var order = db.Orders.Find(Id);
                db.Entry(order).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public IEnumerable<Log> GetLogs()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Logs.Where(l => l.OrderId == Id && l.DeletedDate == null).ToList();
            }
        }

        /// <inheritdoc />
        public IEnumerable<Service> GetServices()
        {
            using (var db = new StretchCeilingsContext())
            {
                var services = db.Services
                    .Join(db.OrderServices, s => s.Id, os => os.ServiceId, (s, os) => new { s, os })
                    .Where(@t => @t.os.OrderId == Id && @t.s.DeletedDate == null)
                    .Select(@t => @t.s);

                if (!services.Any())
                    return services.ToList();

                services.ForEachAsync(s => db.Entry(s).Reference(r => r.Ceiling).Load());
                services.ForEachAsync(s => db.Entry(s).Reference(r => r.Manufacturer).Load());
                services.ForEachAsync(s => db.Entry(s).Reference(r => r.Room).Load());

                return services.ToList();
            }
        }

        /// <inheritdoc />
        public void RemoveService(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var service = db.OrderServices
                    .First(x => x.OrderId == Id && x.ServiceId == id);

                if (service == null)
                    return;

                db.OrderServices.Remove(service);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void RemoveEmployee(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var employee = db.OrderEmployees
                    .First(x => x.OrderId == Id && x.EmployeeId == id);

                if (employee == null)
                    return;

                db.OrderEmployees.Remove(employee);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public IEnumerable<Employee> GetEmployees()
        {
            using (var db = new StretchCeilingsContext())
            {
                var employees = db.Employees
                    .Join(db.OrderEmployees, e => e.Id, orderEmployee => orderEmployee.EmployeeId,
                        (e, orderEmployee) => new { e, orderEmployee })
                    .Join(db.Orders, @t => @t.orderEmployee.OrderId, order => order.Id,
                        (@t, order) => new { @t, order })
                    .Where(@t => @t.@t.e.DeletedDate == null && @t.order.Id == Id)
                    .Select(@t => @t.@t.e);

                if (employees.Any() == false)
                    return employees.ToList();

                employees.ForEachAsync(e => db.Entry(e).Reference(r => r.Role).Load());

                return employees.ToList();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Orders.Find(Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }


}