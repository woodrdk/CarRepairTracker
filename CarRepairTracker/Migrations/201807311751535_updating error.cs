namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatingerror : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserCars", "PurchaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserCars", "ExpirationDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.UserCars", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserCars", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.UserCars", "ExpirationDate", c => c.DateTime());
            AlterColumn("dbo.UserCars", "PurchaseDate", c => c.DateTime());
        }
    }
}
