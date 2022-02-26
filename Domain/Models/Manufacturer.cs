using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using StretchCeilings.DataAccess;
using StretchCeilings.Domain.Models.Enums;
using StretchCeilings.Domain.Models.Interfaces;

namespace StretchCeilings.Domain.Models
{
    /// <inheritdoc />
    public class Manufacturer : IManufacturer
    {
        /// <summary>
        /// identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// country
        /// </summary>
        public Country? Country { get; set; }
        /// <summary>
        /// address
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// deleted date
        /// </summary>
        public DateTime? DeletedDate { get; set; }

        /// <inheritdoc />
        public void Add()
        {
            using (var db = new StretchCeilingsContext())
            {
                db.Manufacturers.Add(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public void Delete()
        {
            using (var db = new StretchCeilingsContext())
            {
                DeletedDate = DateTime.Now;
                var old = db.Manufacturers.FirstOrDefault(x => x.Id == Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }

        /// <inheritdoc />
        public IEnumerable<Ceiling> GetCeilings()
        {
            using (var db = new StretchCeilingsContext())
            {
                return db.Ceilings.Where(ceiling => ceiling.ManufacturerId == Id && ceiling.DeletedDate == null).ToList();
            }
        }

        /// <inheritdoc />
        public void Update()
        {
            using (var db = new StretchCeilingsContext())
            {
                var old = db.Manufacturers.FirstOrDefault(x=>x.Id == Id);
                db.Entry(old).CurrentValues.SetValues(this);
                db.SaveChanges();
            }
        }
    }
}