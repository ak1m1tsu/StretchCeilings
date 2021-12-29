﻿using stretch_ceilings_app.Interfaces;
using stretch_ceilings_app.Utility.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Orders")]
    public class Order : IOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("CustomerId")]
        public int CustomerId { get; set; }
        [Column("CustomerId")]
        public Customer Customer { get; set; }
        public DateTime? DatePlaced { get; set; }
        public DateTime? DateOfMeasurements { get; set; }
        public DateTime?[] DateOfWork { get; set; }
        public DateTime? DatePaid { get; set; }
        public DateTime? DateCanceled { get; set; }
        public DateTime? DateDeleted { get; set; }
        public bool PaidByCash { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Total { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void AddLog(Log log)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateTotal()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void DeleteLog(Log log)
        {
            throw new NotImplementedException();
        }

        public List<Log> GetLogs()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }


}