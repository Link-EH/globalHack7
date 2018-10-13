using System.Data.Entity;

namespace Website.Models
{
    public class EmploymentDatabase : DbContext
    {
        public DbSet<SkillType> SkillType { get; set; }
        public DbSet<SkillCategory> SkillCategory { get; set; }
        public DbSet<JobSkill> JobSkill { get; set; }
        public DbSet<BusinessProfile> BusinessProfiles { get; set; }

        public System.Data.Entity.DbSet<Website.Models.Resume> Resumes { get; set; }
    }
}