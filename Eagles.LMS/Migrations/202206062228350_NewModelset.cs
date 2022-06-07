namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewModelset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        color = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ModelYear = c.Int(nullable: false),
                        Power = c.Decimal(nullable: false, precision: 18, scale: 2),
                        fuel = c.Int(nullable: false),
                        DriveTrain = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        TypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.TypeID, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.TypeID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Types", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Cars", "TypeID", "dbo.Types");
            DropForeignKey("dbo.Cars", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Types", new[] { "CategoryID" });
            DropIndex("dbo.Cars", new[] { "TypeID" });
            DropIndex("dbo.Cars", new[] { "CategoryId" });
            DropTable("dbo.Types");
            DropTable("dbo.Categories");
            DropTable("dbo.Cars");
        }
    }
}
