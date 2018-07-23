namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRepairClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        RepairID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        LaborCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RepairID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Repairs");
        }
    }
}
