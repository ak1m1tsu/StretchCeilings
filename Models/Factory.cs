using stretch_ceilings_app.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Factories")]
    public class Factory : IFactory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public DateTime DateDeleted { get; set; }

        public string AddOrder(FactoryOrder order)
        {
            throw new System.NotImplementedException();
        }

        public string AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public string DeleteOrder(FactoryOrder order)
        {
            throw new System.NotImplementedException();
        }

        public string DeleteProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public List<FactoryOrder> GetOrders()
        {
            throw new System.NotImplementedException();
        }

        public List<Product> GetProduct()
        {
            throw new System.NotImplementedException();
        }
    }
}