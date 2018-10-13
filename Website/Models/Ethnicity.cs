using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Website.Models
{
    [Table("Ethnicty")]
    public class Ethnicity
    {
        [Display(Name ="Ethnicity ID")]
        public Guid EthnicityId { get; set; }

        [Display(Name = "Ethnicity Name")]
        public string EthnicityName { get; set; }
    }
}