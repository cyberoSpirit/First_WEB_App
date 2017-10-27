namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdayDatesForPersons : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Manufacturers", "IsCompany", c => c.Boolean(nullable: false));
            AddColumn("dbo.Manufacturers", "BirtdayDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Manufacturers", "BirtdayDate");
            DropColumn("dbo.Manufacturers", "IsCompany");
        }
    }
}
