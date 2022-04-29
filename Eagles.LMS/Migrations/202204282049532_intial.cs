namespace Eagles.LMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupPriviages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrivilageId = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .ForeignKey("dbo.Privilages", t => t.PrivilageId, cascadeDelete: true)
                .Index(t => t.PrivilageId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mobile = c.String(nullable: false),
                        EmailAddress = c.String(),
                        PasswordHash = c.Binary(nullable: false),
                        PasswordSalt = c.Binary(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        UserTybe = c.Int(nullable: false),
                        AccountState = c.Int(nullable: false),
                        FireBaseToken = c.String(),
                        FullName = c.String(nullable: false),
                        latitude = c.String(),
                        altitude = c.String(),
                        Image = c.String(),
                        GroupId = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        OTP = c.String(),
                        OTP_Provider = c.String(),
                        OTPTIME = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Privilages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenueName = c.String(),
                        ParentId = c.Int(),
                        IsRoute = c.Boolean(nullable: false),
                        OrderId = c.Int(nullable: false),
                        ShowInMenue = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrivilageRoutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Area = c.String(),
                        Controller = c.String(),
                        Action = c.String(),
                        Url = c.String(),
                        PrivilageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Privilages", t => t.PrivilageId, cascadeDelete: true)
                .Index(t => t.PrivilageId);
            
            CreateTable(
                "dbo.UserForLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        FireBaseToken = c.String(),
                        Rememberme = c.Boolean(nullable: false),
                        CurrentTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrivilageRoutes", "PrivilageId", "dbo.Privilages");
            DropForeignKey("dbo.GroupPriviages", "PrivilageId", "dbo.Privilages");
            DropForeignKey("dbo.Users", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.GroupPriviages", "GroupId", "dbo.Groups");
            DropIndex("dbo.PrivilageRoutes", new[] { "PrivilageId" });
            DropIndex("dbo.Users", new[] { "GroupId" });
            DropIndex("dbo.GroupPriviages", new[] { "GroupId" });
            DropIndex("dbo.GroupPriviages", new[] { "PrivilageId" });
            DropTable("dbo.UserForLogins");
            DropTable("dbo.PrivilageRoutes");
            DropTable("dbo.Privilages");
            DropTable("dbo.Users");
            DropTable("dbo.Groups");
            DropTable("dbo.GroupPriviages");
        }
    }
}
