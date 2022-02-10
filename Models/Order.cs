using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Interfaces.Models;

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
                return (from wd in db.OrderWorkDates
                        join o in db.Orders on wd.OrderId equals o.Id
                        where o.DeletedDate == null 
                        select wd).ToList();
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
            GetServices().ForEach(s => Total += s.Price);
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
                var services = from s in db.Services
                    join os in db.OrderServices on s.Id equals os.ServiceId
                    where os.OrderId == Id && s.DeletedDate == null
                    select s;

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
                var employees = from e in db.Employees
                    join orderEmployee in db.OrderEmployees on e.Id equals orderEmployee.EmployeeId
                    join order in db.Orders on orderEmployee.OrderId equals order.Id
                    where e.DeletedDate == null
                    select e;

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