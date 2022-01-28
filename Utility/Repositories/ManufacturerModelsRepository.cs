﻿using System.Collections.Generic;
using System.Linq;
using StretchCeilingsApp.Data;
using StretchCeilingsApp.Data.Models;
using StretchCeilingsApp.Utility.Enums;

namespace StretchCeilingsApp.Utility.Repositories
{
    public static class ManufacturerModelsRepository
    {
        public static List<Manufacturer> GetAll(out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Manufacturers.Where(x => x.DeletedDate == null);
                rows = 0;

                if (queryable.Any()) 
                    rows = queryable.Count();

                return queryable.ToList();
            }
        }

        public static List<Manufacturer> GetAll(Manufacturer firstFilter, int count, int page, out int rows)
        {
            using (var db = new StretchCeilingsContext())
            {
                var queryable = db.Manufacturers.Where(x => x.DeletedDate == null);
                rows = 0;

                if (firstFilter.Id != 0)
                {
                    queryable = queryable.Where(x => x.Id == firstFilter.Id);
                }
                else
                {
                    queryable = firstFilter.Address != null 
                        ? queryable.Where(x => x.Address == firstFilter.Address) 
                        : queryable;

                    queryable = firstFilter.Country != Country.Unknown
                        ? queryable.Where(x => x.Country == firstFilter.Country)
                        : queryable;

                    queryable = firstFilter.Name != null
                        ? queryable.Where(x => x.Name == firstFilter.Name)
                        : queryable;
                }

                if (!queryable.Any()) 
                    return queryable.ToList();

                rows = queryable.Count();
                return queryable.ToList().Skip((page - 1) * count).Take(count).ToList();

            }
        }

        public static Manufacturer GetById(int id)
        {
            using (var db = new StretchCeilingsContext())
            {
                var entity = db.Manufacturers.FirstOrDefault(o => o.Id == id);

                return entity;
            }
        }
    }
}