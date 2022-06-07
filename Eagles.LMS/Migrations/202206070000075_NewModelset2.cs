namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewModelset2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Image", c => c.String());
            AddColumn("dbo.Cars", "assistance_Systems", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "infotainments", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Headlights", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Seats", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Seats");
            DropColumn("dbo.Cars", "Headlights");
            DropColumn("dbo.Cars", "infotainments");
            DropColumn("dbo.Cars", "assistance_Systems");
            DropColumn("dbo.Cars", "Image");
        }
    }
}
