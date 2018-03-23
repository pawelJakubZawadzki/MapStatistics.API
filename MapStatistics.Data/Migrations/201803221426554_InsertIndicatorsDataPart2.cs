namespace MapStatistics.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertIndicatorsDataPart2 : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Arable land (% of land area)', 'AG.LND.ARBL.ZS')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Life expectancy at birth, male (years)', 'SP.DYN.LE00.MA.IN')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Life expectancy at birth, total (years)', 'SP.DYN.LE00.IN')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Life expectancy at birth, female (years)', 'SP.DYN.LE00.FE.IN')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Pregnant women receiving prenatal care (%)', 'SH.STA.ANVC.ZS')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Access to electricity (% of population)', 'EG.ELC.ACCS.ZS')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Forest area (% of land area)', 'AG.LND.FRST.ZS')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Electric power consumption (kWh per capita)', 'EG.USE.ELEC.KH.PC')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Urban population (% of total)', 'SP.URB.TOTL.IN.ZS')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Total reserves (includes gold, current US$)', 'FI.RES.TOTL.CD')");


            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Government expenditure per tertiary student as % of GDP per capita (%)', 'SE.XPD.TERT.PC.ZS')");

            Sql(@"INSERT INTO [Indicators] ([Name], [Code])
                VALUES ('Military expenditure (% of GDP)', 'MS.MIL.XPND.GD.ZS')");
        }
        
        public override void Down()
        {
            Sql(@"DELETE FROM [Indicators]
                 WHERE [Code] IN ('AG.LND.ARBL.ZS', 'SP.DYN.LE00.MA.IN', 'SP.DYN.LE00.IN', 'SP.DYN.LE00.FE.IN', 'SH.STA.ANVC.ZS', 'EG.ELC.ACCS.ZS',
                                  'AG.LND.FRST.ZS', 'EG.USE.ELEC.KH.PC', 'SP.URB.TOTL.IN.ZS', 'FI.RES.TOTL.CD', 'SE.XPD.TERT.PC.ZS', 'MS.MIL.XPND.GD.ZS')");
        }
    }
}
