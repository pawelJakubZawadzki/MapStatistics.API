namespace MapStatistics.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIndicatorBaseData : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Birth rate, crude (per 1,000 people)', 'SP.DYN.CBRT.IN')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Death rate, crude (per 1,000 people)', 'SP.DYN.CDRT.IN')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Population, total', 'SP.POP.TOTL')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Population, female (% of total)', 'SP.POP.TOTL.FE.ZS')");
        }
        
        public override void Down()
        {
            Sql(@"DELETE FROM [Indicators]
                 WHERE [Code] IN ('SP.DYN.CBRT.IN', 'SP.DYN.CDRT.IN', 'SP.POP.TOTL', 'SP.POP.TOTL.FE.ZS')");
        }
    }
}
