namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessProfiles",
                c => new
                    {
                        BusinessId = c.Int(nullable: false, identity: true),
                        BusinessName = c.String(),
                        BusinessIndustry = c.String(),
                        ShortBusinessDescription = c.String(),
                        LongBusinessDescription = c.String(),
                        State = c.String(),
                        City = c.String(),
                        StreetAddress = c.String(),
                        EmailAddress = c.String(),
                        PhoneNumber = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.BusinessId);
            
            DropTable("dbo.Unicorns");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Unicorns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.BusinessProfiles");
        }
    }
}
