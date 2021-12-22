using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateDeleted { get; set; }

        public List<Estate> GetEstates()
        {
            return new List<Estate>();
        }

        public string AddEstate(Estate estate)
        {
            return string.Empty;
        }

        public string DeleteEstate(Estate estate)
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

        public string DeleteOrder(Order order)
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