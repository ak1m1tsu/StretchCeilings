using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilingsApp.Interfaces.Models;

namespace StretchCeilingsApp.Data.Models
{
    [Table("Employees")]
    public class Employee : IEmployee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FullName { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Column("RoleId")]
        public int? RoleId { get; set; }
        [Column("RoleId")]
        public virtual Role Role { get; set; }
        public DateTime? DeletedDate { get; set; }

        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Employees.Add(this);
                db.SaveChanges();
            }
        }

        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Employees.Find(this.Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                DeletedDate = DateTime.Now;
                var old = db.Employees.Find(this.Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public List<Order> GetOrders(int count, int pages)
        {
            using (var db = new StretchCeilingsContext())
            {
                var list = new List<Order>();
                var orderEmployees = db.OrderEmployees.Where(x => x.EmployeeId == Id);
                foreach (var orderEmployee in orderEmployees)
                {
                    list.Add(orderEmployee.Order);
                }
                return list;
            }
        }

        public List<TimeTable> GetSchedule()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Schedules.Where(t => t.EmployeeId == Id).ToList();
            }
        }

        public List<Service> GetServices(int count, int pages)
        {
            using (var db = new StretchCeilingsContext())
            {
                var list = new List<Service>();
                var orderEmployees = db.OrderEmployees.Where(x => x.EmployeeId == Id);
                foreach (var orderEmployee in orderEmployees)
                {
                    var orderServices = db.OrderServices.Where(x => x.OrderId == orderEmployee.OrderId);
                    foreach (var orderService in orderServices)
                    {
                        list.AddRange(db.Services.Where(x => x.Id == orderService.ServiceId));
                    }
                }
                return list;
            }
        }
    }
}