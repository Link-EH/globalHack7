using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class EmploymentDatabase : DbContext
    {
        public DbSet<BusinessProfile> BusinessProfiles { get; set; }
    }
}