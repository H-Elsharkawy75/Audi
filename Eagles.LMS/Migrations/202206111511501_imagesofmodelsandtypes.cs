namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imagesofmodelsandtypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "MainImageOne", c => c.String());
            AddColumn("dbo.Categories", "MainImageTwo", c => c.String());
            AddColumn("dbo.Types", "MainImageOne", c => c.String());
            AddColumn("dbo.Types", "MainImageTwo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Types", "MainImageTwo");
            DropColumn("dbo.Types", "MainImageOne");
            DropColumn("dbo.Categories", "MainImageTwo");
            DropColumn("dbo.Categories", "MainImageOne");
        }
    }
}
