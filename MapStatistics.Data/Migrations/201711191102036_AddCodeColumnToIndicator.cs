namespace MapStatistics.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCodeColumnToIndicator : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Indicators", "Code", c => c.String(nullable: false));
            AlterColumn("dbo.Indicators", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Indicators", "Name", c => c.String());
            DropColumn("dbo.Indicators", "Code");
        }
    }
}
