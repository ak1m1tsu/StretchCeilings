using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using stretch_ceilings_app.Interfaces.Models;

namespace stretch_ceilings_app.Data.Models
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
        public DateTime? DateDeleted { get; set; }

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
                db.Entry(this.Id).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Entry(this.Id).CurrentValues.SetValues(DateDeleted = DateTime.Now);
                db.SaveChanges();
            }
        }

        public List<Order> GetOrders(int count, int pages)
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Orders.SqlQuery("SELECT Orders.* FROM Orders " +
                                          "INNER JOIN OrderEmployees ON OrderEmployees.OrderId = Orders.Id " +
                                          $"WHERE OrderEmployees.EmployeeId = {Id} AND Orders.DateDeleted IS NULL").ToList();
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
                return db.Services.SqlQuery("SELECT Services.* FROM Services " +
                                            "INNER JOIN OrderServices ON OrderServices.ServiceId = Services.Id " +
                                            "INNER JOIN OrderEmployees ON OrderServices.OrderId = OrderEmployees.OrderId " +
                                            $"WHERE OrderEmployees.EmployeeId = {Id}").ToList();
            }
        }
    }
}