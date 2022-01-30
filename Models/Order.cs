using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public List<DateTime?> GetWorkdays()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Database.SqlQuery<DateTime?>($"SELECT OrderWorkdays.DateOfWork FROM OrderWorkdays WHERE OrderWorkdays.OrderId = {Id}").ToList();
            }
        }

        public void SetWorkday(DateTime? day)
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Database.ExecuteSqlCommand($"INSERT INTO OrderWorkdays VALUES ({Id}, {day})");
                db.SaveChanges();
            }
        }

        public void DeleteWorkDay(DateTime? day)
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Database.ExecuteSqlCommand($"DELETE FROM OrderWorkdays WHERE OrderWorkdays.OrderId = {Id} AND OrderWorkdays.DateOfWork = {day}");
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
                return db.Logs.Where(l => l.OrderId == this.Id).ToList();
            }
        }

        public List<Service> GetServices()
        {
            using (var db = new StretchCeilingsContext())
            {
                var services = db.Services.SqlQuery("SELECT Services.* FROM Services " +
                                                     "INNER JOIN OrderServices ON OrderServices.ServiceId = Services.Id " +
                                                     $"WHERE OrderServices.OrderId = {Id} AND Services.DeletedDate IS NULL").ToList();

                if (services.Any())
                {
                    services.ForEach(service => db.Entry(service).Reference(r => r.Manufacturer).Load());
                    services.ForEach(service => db.Entry(service).Reference(r => r.Ceiling).Load());
                }

                return services;
            }
        }

        public List<Employee> GetEmployees()
        {
            using (var db = new StretchCeilingsContext())
            {
                var employees = db.Employees.SqlQuery("SELECT Employees.* FROM Employees " +
                                                      "INNER JOIN OrderEmployees ON OrderEmployees.EmployeeId = Employees.Id " +
                                                      $"WHERE OrderEmployees.OrderId = {Id} AND Employees.DeletedDate IS NULL").ToList();

                if (employees.Any())
                {
                    employees.ForEach(employee => db.Entry(employee).Reference(e=>e.Role).Load());
                }

                return employees;
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