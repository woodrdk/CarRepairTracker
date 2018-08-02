namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            CreateTable(
                "dbo.Engines",
                c => new
                    {
                        EngineID = c.Int(nullable: false, identity: true),
                        EngineName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.EngineID);
            
            CreateTable(
                "dbo.Trims",
                c => new
                    {
                        TrimID = c.Int(nullable: false, identity: true),
                        TrimName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.TrimID);
            
            CreateTable(
                "dbo.ModelEngines",
                c => new
                    {
                        Model_ModelID = c.Int(nullable: false),
                        Engine_EngineID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Model_ModelID, t.Engine_EngineID })
                .ForeignKey("dbo.Models", t => t.Model_ModelID, cascadeDelete: true)
                .ForeignKey("dbo.Engines", t => t.Engine_EngineID, cascadeDelete: true)
                .Index(t => t.Model_ModelID)
                .Index(t => t.Engine_EngineID);
            
            CreateTable(
                "dbo.TrimModels",
                c => new
                    {
                        Trim_TrimID = c.Int(nullable: false),
                        Model_ModelID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Trim_TrimID, t.Model_ModelID })
                .ForeignKey("dbo.Trims", t => t.Trim_TrimID, cascadeDelete: true)
                .ForeignKey("dbo.Models", t => t.Model_ModelID, cascadeDelete: true)
                .Index(t => t.Trim_TrimID)
                .Index(t => t.Model_ModelID);
            
            AddColumn("dbo.Parts", "PartNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Parts", "PartName", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Parts", "PartBrand", c => c.String());
            AddColumn("dbo.Parts", "Qty", c => c.Short(nullable: false));
            AddColumn("dbo.Parts", "Repairs_RepairID", c => c.Int());
            AddColumn("dbo.Repairs", "TotalCost", c => c.Double(nullable: false));
            AddColumn("dbo.Repairs", "ShopName", c => c.String());
            AddColumn("dbo.Repairs", "Mileage", c => c.Int(nullable: false));
            AddColumn("dbo.Repairs", "Misc", c => c.String());
            AddColumn("dbo.UserCars", "UserId_UserID", c => c.Int());
            AlterColumn("dbo.Users", "UserId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Users", "UserID");
            CreateIndex("dbo.Parts", "Repairs_RepairID");
            CreateIndex("dbo.UserCars", "UserId_UserID");
            AddForeignKey("dbo.Parts", "Repairs_RepairID", "dbo.Repairs", "RepairID");
            AddForeignKey("dbo.UserCars", "UserId_UserID", "dbo.Users", "UserID");
            DropColumn("dbo.Parts", "Name");
            DropColumn("dbo.UserCars", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserCars", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Parts", "Name", c => c.String(nullable: false, maxLength: 40));
            DropForeignKey("dbo.UserCars", "UserId_UserID", "dbo.Users");
            DropForeignKey("dbo.Parts", "Repairs_RepairID", "dbo.Repairs");
            DropForeignKey("dbo.TrimModels", "Model_ModelID", "dbo.Models");
            DropForeignKey("dbo.TrimModels", "Trim_TrimID", "dbo.Trims");
            DropForeignKey("dbo.ModelEngines", "Engine_EngineID", "dbo.Engines");
            DropForeignKey("dbo.ModelEngines", "Model_ModelID", "dbo.Models");
            DropIndex("dbo.TrimModels", new[] { "Model_ModelID" });
            DropIndex("dbo.TrimModels", new[] { "Trim_TrimID" });
            DropIndex("dbo.ModelEngines", new[] { "Engine_EngineID" });
            DropIndex("dbo.ModelEngines", new[] { "Model_ModelID" });
            DropIndex("dbo.UserCars", new[] { "UserId_UserID" });
            DropIndex("dbo.Parts", new[] { "Repairs_RepairID" });
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "UserId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.UserCars", "UserId_UserID");
            DropColumn("dbo.Repairs", "Misc");
            DropColumn("dbo.Repairs", "Mileage");
            DropColumn("dbo.Repairs", "ShopName");
            DropColumn("dbo.Repairs", "TotalCost");
            DropColumn("dbo.Parts", "Repairs_RepairID");
            DropColumn("dbo.Parts", "Qty");
            DropColumn("dbo.Parts", "PartBrand");
            DropColumn("dbo.Parts", "PartName");
            DropColumn("dbo.Parts", "PartNumber");
            DropTable("dbo.TrimModels");
            DropTable("dbo.ModelEngines");
            DropTable("dbo.Trims");
            DropTable("dbo.Engines");
            AddPrimaryKey("dbo.Users", "UserID");
        }
    }
}
