 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Website.Models
{
    [Table("BusinessProfiles")]
    public class BusinessProfile
    {
        [Key, Display(Name = "Business#")]
        public int BusinessId { get; set; }
        [Display(Name = "BusinessName")]
        public string BusinessName { get; set; }
        [Display(Name = "Industry")]
        public string BusinessIndustry { get; set; }
        [Display(Name = "ShortDescription")]
        [DataType(DataType.MultilineText)]
        public string ShortBusinessDescription { get; set; }
        [Display(Name = "LongDescription")]
        [DataType(DataType.MultilineText)]
        public string LongBusinessDescription { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "StreetAddress")]
        public string StreetAddress { get; set; }
        [Display(Name = "EmailAddress")]
        public string EmailAddress { get; set; }
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }

        [Display(Name = "Industry#")]
        public Guid IndustryId { get; set; }
        public virtual Industry Industry { get; set; }

    }
}