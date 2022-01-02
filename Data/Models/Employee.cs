using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string Add()
        {
            throw new NotImplementedException();
        }

        public string AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public string AddService(Service service)
        {
            throw new NotImplementedException();
        }

        public string AddTimeTable(TimeTable timeTable)
        {
            throw new NotImplementedException();
        }

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public string DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public string DeleteService(Service service)
        {
            throw new NotImplementedException();
        }

        public string DeleteTimeTable(TimeTable timeTable)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders(int count, int pages)
        {
            throw new NotImplementedException();
        }

        public List<TimeTable> GetSchedule()
        {
            throw new NotImplementedException();
        }

        public List<Service> GetServices(int count, int pages)
        {
            throw new NotImplementedException();
        }

        public string Update()
        {
            throw new NotImplementedException();
        }
    }
}