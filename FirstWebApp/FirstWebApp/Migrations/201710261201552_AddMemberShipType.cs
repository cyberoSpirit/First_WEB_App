namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        SoldItemsCount = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Manufacturers", "MembershipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Manufacturers", "MembershipTypeId");
            AddForeignKey("dbo.Manufacturers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Manufacturers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Manufacturers", new[] { "MembershipTypeId" });
            DropColumn("dbo.Manufacturers", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
