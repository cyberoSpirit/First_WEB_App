namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes (Type, SoldItemsCount, Discount) VALUES ('Junior', 10, 0)");
            Sql("INSERT INTO MemberShipTypes (Type, SoldItemsCount, Discount) VALUES ('Qualified', 1000, 5)");
            Sql("INSERT INTO MemberShipTypes (Type, SoldItemsCount, Discount) VALUES ('Professional', 10000, 10)");
        }

        public override void Down()
        {
        }
    }
}
