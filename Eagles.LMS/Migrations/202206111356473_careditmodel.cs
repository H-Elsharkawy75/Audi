namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class careditmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Description", c => c.String());
            AddColumn("dbo.Cars", "NearestLocation", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "NearestLocation");
            DropColumn("dbo.Cars", "Description");
        }
    }
}
