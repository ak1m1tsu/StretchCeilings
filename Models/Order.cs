using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Models.Enums;
using StretchCeilings.Models.Interfaces;

namespace StretchCeilings.Models
{
    public class Order : IOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("CustomerId")]
        public int? CustomerId { get; set; }
        [Column("CustomerId")]
        public virtual Customer Customer { get; set; }
        public DateTime? DatePlaced { get; set; }
        public DateTime? DateOfMeasurements { get; set; }
        public DateTime? DatePaid { get; set; }
        public DateTime? DateCanceled { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? PaidByCash { get; set; }
        public OrderStatus? Status { get; set; }
        public decimal? Total { get; set; }

        public List<OrderWorkDate> GetWorkDates()
        {
            using (var db = new StretchCeilingsContext())
            {
                return (db.OrderWorkDates
                    .Join(db.Orders, wd => wd.OrderId, o => o.Id, (wd, o) => new { wd, o })
                    .Where(@t => @t.o.DeletedDate == null && @t.o.Id == Id)
                    .Select(@t => @t.wd)).ToList();
            }
        }

        public void SetWorkday(OrderWorkDate workDate)
        {
            using (var db = new StretchCeilingsContext())
            {
                db.OrderWorkDates.Add(workDate);
                db.SaveChanges();
            }
        }

        public void DeleteWorkDay(OrderWorkDate workDate)
        {
            using (var db = new StretchCeilingsContext())
            {
                db.OrderWorkDates.Remove(workDate);
                db.SaveChanges();
            }
        }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Orders.Add(this);
                db.SaveChanges();
            }
        }

        public void CalculateTotal()
        {
            var services = GetServices();
            Total = 0;
            foreach (var service in services)
                Total += service.Price;
        }

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

        public List<Log> GetLogs()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Logs.Where(l => l.OrderId == Id && l.DeletedDate == null).ToList();
            }
        }

        public List<Service> GetServices()
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

        public List<Employee> GetEmployees()
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