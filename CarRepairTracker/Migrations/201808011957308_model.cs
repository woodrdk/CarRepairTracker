namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Models", "Makes_MakeID", c => c.Int());
            CreateIndex("dbo.Models", "Makes_MakeID");
            AddForeignKey("dbo.Models", "Makes_MakeID", "dbo.Makes", "MakeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "Makes_MakeID", "dbo.Makes");
            DropIndex("dbo.Models", new[] { "Makes_MakeID" });
            DropColumn("dbo.Models", "Makes_MakeID");
        }
    }
}
