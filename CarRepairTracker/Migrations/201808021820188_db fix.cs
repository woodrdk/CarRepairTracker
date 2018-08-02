namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbfix : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserCars", name: "UserId_UserID", newName: "CurrUser_UserID");
            RenameIndex(table: "dbo.UserCars", name: "IX_UserId_UserID", newName: "IX_CurrUser_UserID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserCars", name: "IX_CurrUser_UserID", newName: "IX_UserId_UserID");
            RenameColumn(table: "dbo.UserCars", name: "CurrUser_UserID", newName: "UserId_UserID");
        }
    }
}
