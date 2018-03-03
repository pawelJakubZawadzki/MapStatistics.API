namespace MapStatistics.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertCountryCodesValuesToAreas : DbMigration
    {
        public override void Up()
        {
            Sql(@"UPDATE [dbo].[Areas]
                SET [CountryCode] = 'PL'
                WHERE [Name] = 'Poland'
            ");

            Sql(@"UPDATE [dbo].[Areas]
                SET [CountryCode] = 'DE'
                WHERE [Name] = 'Germany'
            ");

            Sql(@"UPDATE [dbo].[Areas]
                SET [CountryCode] = 'Czech Republic'
                WHERE [Name] = 'CZ'
            ");

            Sql(@"UPDATE [dbo].[Areas]
                SET [CountryCode] = 'SK'
                WHERE [Name] = 'Slovakia'
            ");

            Sql(@"UPDATE [dbo].[Areas]
                SET [CountryCode] = 'UA'
                WHERE [Name] = 'Ukraine'
            ");

            Sql(@"UPDATE [dbo].[Areas]
                SET [CountryCode] = 'BY'
                WHERE [Name] = 'Belarus'
            ");

            Sql(@"UPDATE [dbo].[Areas]
                SET [CountryCode] = 'LT'
                WHERE [Name] = 'Lithuania'
            ");

            Sql(@"UPDATE [dbo].[Areas]
                SET [CountryCode] = 'RU'
                WHERE [Name] = 'Russia'
            ");
        }
        
        public override void Down()
        {
            Sql(@"UPDATE [dbo].[Areas]
                SET [CountryCode] = ''
            ");
        }
    }
}
