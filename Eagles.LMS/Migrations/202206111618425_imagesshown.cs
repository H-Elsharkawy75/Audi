namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imagesshown : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShownImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShownImages", "CarId", "dbo.Cars");
            DropIndex("dbo.ShownImages", new[] { "CarId" });
            DropTable("dbo.ShownImages");
        }
    }
}
