namespace FirstWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVineSugarAndAlcoholProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vines", "Raw", c => c.String());
            AddColumn("dbo.Vines", "ContainSugar", c => c.Boolean(nullable: false));
            AddColumn("dbo.Vines", "ContainAlcohol", c => c.Int(nullable: false));
            AlterColumn("dbo.Vines", "Name", c => c.String(nullable: false, maxLength: 300));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vines", "Name", c => c.String());
            DropColumn("dbo.Vines", "ContainAlcohol");
            DropColumn("dbo.Vines", "ContainSugar");
            DropColumn("dbo.Vines", "Raw");
        }
    }
}
