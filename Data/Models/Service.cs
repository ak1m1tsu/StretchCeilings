﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using stretch_ceilings_app.Interfaces.Models;

namespace stretch_ceilings_app.Data.Models
{
    [Table("Services")]
    public class Service : IService
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("ManufacturerId")]
        public int? ManufacturerId { get; set; }
        [Column("ManufacturerId")]
        public virtual Manufacturer Manufacturer { get; set; }
        [Column("CeilingId")]
        public int? CeilingId { get; set; }
        [Column("CeilingId")]
        public virtual Ceiling Ceiling { get; set; }
        public decimal? Price { get; set; }
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