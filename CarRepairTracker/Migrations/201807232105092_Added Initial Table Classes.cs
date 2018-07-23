namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInitialTableClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Makes",
                c => new
                    {
                        MakeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        YearStarted = c.Int(nullable: false),
                        YearEnded = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MakeID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        YearStarted = c.Int(nullable: false),
                        YearEnded = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModelID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        LastName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Models");
            DropTable("dbo.Makes");
        }
    }
}
