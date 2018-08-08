namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class repairParts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Repairs", "CarId", c => c.Int(nullable: false));
            AlterColumn("dbo.Parts", "PartNumber", c => c.String());
            AlterColumn("dbo.Parts", "Qty", c => c.Int(nullable: false));
            DropColumn("dbo.Repairs", "PartCost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Repairs", "PartCost", c => c.Double(nullable: false));
            AlterColumn("dbo.Parts", "Qty", c => c.Short(nullable: false));
            AlterColumn("dbo.Parts", "PartNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Repairs", "CarId");
        }
    }
}
