namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ne : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Parts", "RepairID", "dbo.Repairs");
            DropIndex("dbo.Parts", new[] { "RepairID" });
            RenameColumn(table: "dbo.Parts", name: "RepairID", newName: "Repairs_RepairID");
            DropPrimaryKey("dbo.Repairs");
            AddColumn("dbo.Repairs", "PartCost", c => c.Double(nullable: false));
            AlterColumn("dbo.Parts", "PartNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Parts", "Qty", c => c.Short(nullable: false));
            AlterColumn("dbo.Parts", "Repairs_RepairID", c => c.Int());
            AlterColumn("dbo.Repairs", "RepairID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Repairs", "Name", c => c.String(nullable: false, maxLength: 40));
            AddPrimaryKey("dbo.Repairs", "RepairID");
            CreateIndex("dbo.Parts", "Repairs_RepairID");
            AddForeignKey("dbo.Parts", "Repairs_RepairID", "dbo.Repairs", "RepairID");
            DropColumn("dbo.Repairs", "CarId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Repairs", "CarId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Parts", "Repairs_RepairID", "dbo.Repairs");
            DropIndex("dbo.Parts", new[] { "Repairs_RepairID" });
            DropPrimaryKey("dbo.Repairs");
            AlterColumn("dbo.Repairs", "Name", c => c.String(maxLength: 40));
            AlterColumn("dbo.Repairs", "RepairID", c => c.Int(nullable: false));
            AlterColumn("dbo.Parts", "Repairs_RepairID", c => c.Int(nullable: false));
            AlterColumn("dbo.Parts", "Qty", c => c.Int(nullable: false));
            AlterColumn("dbo.Parts", "PartNumber", c => c.String());
            DropColumn("dbo.Repairs", "PartCost");
            AddPrimaryKey("dbo.Repairs", "RepairID");
            RenameColumn(table: "dbo.Parts", name: "Repairs_RepairID", newName: "RepairID");
            CreateIndex("dbo.Parts", "RepairID");
            AddForeignKey("dbo.Parts", "RepairID", "dbo.Repairs", "RepairID", cascadeDelete: true);
        }
    }
}
