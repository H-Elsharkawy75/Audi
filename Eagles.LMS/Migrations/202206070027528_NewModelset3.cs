namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewModelset3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "MainImageOne", c => c.String());
            AddColumn("dbo.Cars", "MainImageTwo", c => c.String());
            DropColumn("dbo.Cars", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Image", c => c.String());
            DropColumn("dbo.Cars", "MainImageTwo");
            DropColumn("dbo.Cars", "MainImageOne");
        }
    }
}
