﻿using stretch_ceilings_app.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Services")]
    public class Service : IService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column("CategoryId")]
        public int CategoryId { get; set; }
        [Column("CategoryId")]
        public Category Category { get; set; }
        [Column("ManufacturerId")]
        public int ManufacturerId { get; set; }
        [Column("ManufacturerId")]
        public Manufacturer Manufacturer { get; set; }
        [Column("ProductId")]
        public int ProductId { get; set; }
        [Column("ProductId")]
        public Ceiling Product { get; set; }
        public int Pipes { get; set; }
        public int Lamps { get; set; }
        public bool Backlight { get; set; }
        public decimal Price { get; set; }
        public DateTime? DeteDeleted { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }


}