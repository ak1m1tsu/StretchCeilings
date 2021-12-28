using stretch_ceilings_app.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
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
        [ForeignKey("Role")]
        public int RoleID { get; set; }
        public Role Role { get; set; }
        public DateTime? DateDeleted { get; set; }

        public bool Can(Permission permission)
        {
            return false;
        }

        public List<TimeTable> GetSchedule()
        {
            return new List<TimeTable>();
        }

        public string AddTimeTable(TimeTable timeTable)
        {
            return string.Empty;
        }

        public string DeleteTimeTable(TimeTable timeTable)
        {
            return string.Empty;
        }

        public List<Order> GetOrders(int count, int pages)
        {
            return new List<Order>();
        }
        public string AddOrder(Order order)
        {
            return string.Empty;
        }

        public string DeleteOrder(Order Order)
        {
            return string.Empty;
        }

        public List<Service> GetServices(int count, int pages)
        {
            return new List<Service>();
        }
        public string AddService(Service service)
        {
            return string.Empty;
        }

        public string DeleteService(Service service)
        {
            return string.Empty;
        }
    }
}