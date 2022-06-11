namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class equipment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        assistance_Systems = c.Int(nullable: false),
                        infotainments = c.Int(nullable: false),
                        Headlights = c.Int(nullable: false),
                        Seats = c.Int(nullable: false),
                        interior = c.Boolean(),
                        exterior = c.Boolean(),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
            DropColumn("dbo.Cars", "assistance_Systems");
            DropColumn("dbo.Cars", "infotainments");
            DropColumn("dbo.Cars", "Headlights");
            DropColumn("dbo.Cars", "Seats");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Seats", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Headlights", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "infotainments", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "assistance_Systems", c => c.Int(nullable: false));
            DropForeignKey("dbo.Equipments", "CarId", "dbo.Cars");
            DropIndex("dbo.Equipments", new[] { "CarId" });
            DropTable("dbo.Equipments");
        }
    }
}
