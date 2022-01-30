using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StretchCeilings.DataAccess;
using StretchCeilings.Helpers.Enums;
using StretchCeilings.Interfaces.Models;

namespace StretchCeilings.Models
{
    public class Permission : IPermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public string Name { get; set; }
        [Index(IsUnique = true)]
        public PermissionCode Code { get; set; }

        public string Add()
        {
            try
            {
                using (var db = new StretchCeilingsContext())
                {
                    db.Permissions.Add(this);
                    db.SaveChanges();

                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete()
        {
            try
            {
                using (var db = new StretchCeilingsContext())
                {
                    db.Permissions.Add(this);
                    db.SaveChanges();

                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update()
        {
            try
            {
                using (var db = new StretchCeilingsContext())
                {
                    db.Permissions.Add(this);
                    db.SaveChanges();

                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}