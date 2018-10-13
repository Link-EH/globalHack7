using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Website.Models
{
    [Table("SkillType")]
    public class SkillType
    {
        [Display(Name = "Skill Type"), Key]
        public string Name { get; set; }
    }
}