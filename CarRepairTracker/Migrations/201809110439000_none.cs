namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class none : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserCars", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserCars", "Notes");
        }
    }
}
