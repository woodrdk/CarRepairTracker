namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carlist : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserCars", "CurrUser_UserID", "dbo.Users");
            DropIndex("dbo.UserCars", new[] { "CurrUser_UserID" });
            RenameColumn(table: "dbo.UserCars", name: "CurrUser_UserID", newName: "UserId");
            AlterColumn("dbo.UserCars", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserCars", "UserId");
            AddForeignKey("dbo.UserCars", "UserId", "dbo.Users", "UserID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCars", "UserId", "dbo.Users");
            DropIndex("dbo.UserCars", new[] { "UserId" });
            AlterColumn("dbo.UserCars", "UserId", c => c.Int());
            RenameColumn(table: "dbo.UserCars", name: "UserId", newName: "CurrUser_UserID");
            CreateIndex("dbo.UserCars", "CurrUser_UserID");
            AddForeignKey("dbo.UserCars", "CurrUser_UserID", "dbo.Users", "UserID");
        }
    }
}
