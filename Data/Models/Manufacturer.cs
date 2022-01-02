using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using stretch_ceilings_app.Interfaces.Models;

namespace stretch_ceilings_app.Data.Models
{
    [Table("Manufacturers")]
    public class Manufacturer : IManufacturer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTime? DateDeleted { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void AddOrder(ManufacturerOrder order)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Ceiling product)
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(ManufacturerOrder order)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Ceiling product)
        {
            throw new NotImplementedException();
        }

        public List<ManufacturerOrder> GetOrders()
        {
            throw new NotImplementedException();
        }

        public List<Ceiling> GetProduct()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}