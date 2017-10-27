namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillManufacturersTableWithSomeData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Manufacturers (Name, IsSubscribedToNewsLetter, MembershipTypeId, IsCompany, BirtdayDate) VALUES ('Karl Shosh', False, 1, False, '25.01.1988 0:00:00')");
            Sql("INSERT INTO Manufacturers (Name, IsSubscribedToNewsLetter, MembershipTypeId, IsCompany, BirtdayDate) VALUES ('Shabo', True, 2, True, null)");
            Sql("INSERT INTO Manufacturers (Name, IsSubscribedToNewsLetter, MembershipTypeId, IsCompany, BirtdayDate) VALUES ('Kartuli Vazi', True, 2, True, null)");
        }
        
        public override void Down()
        {
        }
    }
}
