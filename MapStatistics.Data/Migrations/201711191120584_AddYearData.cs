namespace MapStatistics.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddYearData : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2016)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2015)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2014)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2013)");
        }
        
        public override void Down()
        {
            Sql(@"DELETE FROM [Years]
                 WHERE [Value] IN (2016, 2015, 2014, 2013)");
        }
    }
}
