namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        SoldItemsCount = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Manufacturers", "Membership_Id", c => c.Int());
            CreateIndex("dbo.Manufacturers", "Membership_Id");
            AddForeignKey("dbo.Manufacturers", "Membership_Id", "dbo.MemberShipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Manufacturers", "Membership_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Manufacturers", new[] { "Membership_Id" });
            DropColumn("dbo.Manufacturers", "Membership_Id");
            DropTable("dbo.MemberShipTypes");
        }
    }
}
