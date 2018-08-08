namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class repairid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Parts", "Repairs_RepairID", "dbo.Repairs");
            DropIndex("dbo.Parts", new[] { "Repairs_RepairID" });
            RenameColumn(table: "dbo.Parts", name: "Repairs_RepairID", newName: "RepairID");
            AlterColumn("dbo.Parts", "RepairID", c => c.Int(nullable: false));
            CreateIndex("dbo.Parts", "RepairID");
            AddForeignKey("dbo.Parts", "RepairID", "dbo.Repairs", "RepairID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parts", "RepairID", "dbo.Repairs");
            DropIndex("dbo.Parts", new[] { "RepairID" });
            AlterColumn("dbo.Parts", "RepairID", c => c.Int());
            RenameColumn(table: "dbo.Parts", name: "RepairID", newName: "Repairs_RepairID");
            CreateIndex("dbo.Parts", "Repairs_RepairID");
            AddForeignKey("dbo.Parts", "Repairs_RepairID", "dbo.Repairs", "RepairID");
        }
    }
}
