namespace MapStatistics.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContryCodeColumnToAreas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Areas", "CountryCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Areas", "CountryCode");
        }
    }
}
