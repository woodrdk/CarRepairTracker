namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YearendedoptionalforMakeandModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Makes", "YearEnded", c => c.Int());
            AlterColumn("dbo.Models", "YearEnded", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Models", "YearEnded", c => c.Int(nullable: false));
            AlterColumn("dbo.Makes", "YearEnded", c => c.Int(nullable: false));
        }
    }
}
