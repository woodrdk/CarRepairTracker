namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserIdToVehiclesownedDatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserCars", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserCars", "UserId");
        }
    }
}
