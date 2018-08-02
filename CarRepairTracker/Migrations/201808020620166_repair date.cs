namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class repairdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserCars", "UserId_UserID", "dbo.Users");
            DropPrimaryKey("dbo.Users");
            AddColumn("dbo.Repairs", "RepairDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "UserID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "UserID");
            AddForeignKey("dbo.UserCars", "UserId_UserID", "dbo.Users", "UserID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCars", "UserId_UserID", "dbo.Users");
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "UserId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Repairs", "RepairDate");
            AddPrimaryKey("dbo.Users", "UserID");
            AddForeignKey("dbo.UserCars", "UserId_UserID", "dbo.Users", "UserID");
        }
    }
}
