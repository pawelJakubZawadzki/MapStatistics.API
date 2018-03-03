namespace MapStatistics.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertIndicatorsData : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('GDP,current US$,millions,seas. adj.', 'NYGDPMKTPSACD')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Human Development Index', 'IDX.HDI')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Annual percentage growth rate of GDP at market prices based on constant 2010 US Dollars.', 'NYGDPMKTPKDZ')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('GDP growth (annual %)', '6.0.GDP_growth')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('GDP per capita, PPP (constant 2011 international $)', '6.0.GDPpc_constant')");
        }
        
        public override void Down()
        {
            Sql(@"DELETE FROM [Indicators]
                 WHERE [Code] IN ('NYGDPMKTPSACD', 'SP.DYN.CDRT.IN', 'NYGDPMKTPKDZ', '6.0.GDP_growth', '6.0.GDPpc_constant')");
        }
    }
}
