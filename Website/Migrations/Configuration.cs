namespace Website.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Website.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Website.Models.EmploymentDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Website.Models.EmploymentDatabase";
        }

        protected override void Seed(Website.Models.EmploymentDatabase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Industries.AddOrUpdate(new Industry
            {
                IndustryId = Guid.Parse("c2681640-cae7-425f-a48c-f2e7a1e2b3b9"),
                IndustryName = "Automotive"
            });

            context.Industries.AddOrUpdate(new Industry
            {
                IndustryId = Guid.Parse("fc692308-1567-4ce7-bae1-68ee3b768303"),
                IndustryName = "Technology"
            });

            context.Industries.AddOrUpdate(new Industry
            {
                IndustryId = Guid.Parse("19f66291-8eb5-49b5-b2dd-ecf208b3bcec"),
                IndustryName = "Food"
            });

        }
    }
}
