using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    [Table("SkillCategory")]
    public class SkillCategory
    {
        [Display(Name = "Skill Id"), Key]
        public Guid SkillId { get; set; }
        [Display(Name = "Skill Name")]
        public string SkillName { get; set; }
        [Display(Name = "Skill Type")]
        public string SkillType { get; set; }
        [Display (Name = "Skill Image")]
        public string Image { get; set; }
    }
}