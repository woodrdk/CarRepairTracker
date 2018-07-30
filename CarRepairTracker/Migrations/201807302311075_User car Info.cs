namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsercarInfo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserCars", "PurchaseDate", c => c.DateTime());
            AlterColumn("dbo.UserCars", "ExpirationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserCars", "ExpirationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserCars", "PurchaseDate", c => c.DateTime(nullable: false));
        }
    }
}
