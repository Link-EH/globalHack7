using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    [Table("WorkExperience")]
    public class WorkExperience
    {
        [Key, Display(Name = "#")]
        public Guid ResumeId { get; set; }
        
        [Key, Display(Name = "Work Name")]
        [StringLength(60)]
        public string WorkName { get; set; }

        [Key, Display(Name = "Start date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Work Description")]
        public string WorkDescription { get; set; }
    }
}