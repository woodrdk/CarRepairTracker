namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigraionConflict : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserCars", "UserId", c => c.Int(nullable: false));
            AlterColumn("dbo.UserCars", "PurchaseDate", c => c.DateTime());
            AlterColumn("dbo.UserCars", "ExpirationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserCars", "ExpirationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserCars", "PurchaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.UserCars", "UserId");
        }
    }
}
