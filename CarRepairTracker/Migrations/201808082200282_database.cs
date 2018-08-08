namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Parts", "RepairID", "dbo.Repairs");
            DropPrimaryKey("dbo.Repairs");
            AlterColumn("dbo.Repairs", "RepairID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Repairs", "RepairID");
            AddForeignKey("dbo.Parts", "RepairID", "dbo.Repairs", "RepairID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parts", "RepairID", "dbo.Repairs");
            DropPrimaryKey("dbo.Repairs");
            AlterColumn("dbo.Repairs", "RepairID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Repairs", "RepairID");
            AddForeignKey("dbo.Parts", "RepairID", "dbo.Repairs", "RepairID", cascadeDelete: true);
        }
    }
}
