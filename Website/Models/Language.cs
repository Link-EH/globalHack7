using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Website.Models
{
    [Table("Languages")]
    public class Language
    {
        [Key, Display(Name ="Language Code")]
        public string LanguageCode { get; set; }

        [Display(Name ="English Name")]
        public string EnglishName { get; set; }

        [Display(Name ="Native Language")]
        public string NativeLanguage { get; set; }
    }
}