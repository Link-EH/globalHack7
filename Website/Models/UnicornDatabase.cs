using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class UnicornDatabase : DbContext
    {
        public DbSet<Unicorn> Unicorns { get; set; }
    }
}