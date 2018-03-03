namespace MapStatistics.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertYears : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2012)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2011)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2010)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2009)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2008)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2007)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2006)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2005)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2004)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2003)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2002)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2001)");

            Sql(@"INSERT INTO [Years] ([Value])
                VALUES (2000)");
        }
        
        public override void Down()
        {
            Sql(@"DELETE FROM [Years]
                 WHERE [Value] IN (2012, 2011, 2010, 2009, 2008, 2007, 2006, 2005, 2004, 2003, 2002, 2001, 2000)");
        }
    }
}
