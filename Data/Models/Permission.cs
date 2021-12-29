using stretch_ceilings_app.Data;
using stretch_ceilings_app.Interfaces;
using stretch_ceilings_app.Utility.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stretch_ceilings_app.Models
{
    [Table("Permissions")]
    public class Permission : IPermission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public PermissionCode Code { get; set; }

        public string Add()
        {
            try
            {
                using (StretchCeilingsContext db = new StretchCeilingsContext())
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
                using (StretchCeilingsContext db = new StretchCeilingsContext())
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
                using (StretchCeilingsContext db = new StretchCeilingsContext())
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