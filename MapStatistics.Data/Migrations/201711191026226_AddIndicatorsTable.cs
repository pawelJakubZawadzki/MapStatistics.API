namespace MapStatistics.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIndicatorsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Indicators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Indicators");
        }
    }
}
