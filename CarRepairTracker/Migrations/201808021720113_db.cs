namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Engines",
                c => new
                    {
                        EngineID = c.Int(nullable: false, identity: true),
                        EngineName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.EngineID);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ModelID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        YearStarted = c.Int(nullable: false),
                        YearEnded = c.Int(),
                        Makes_MakeID = c.Int(),
                    })
                .PrimaryKey(t => t.ModelID)
                .ForeignKey("dbo.Makes", t => t.Makes_MakeID)
                .Index(t => t.Makes_MakeID);
            
            CreateTable(
                "dbo.Makes",
                c => new
                    {
                        MakeID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        YearStarted = c.Int(nullable: false),
                        YearEnded = c.Int(),
                    })
                .PrimaryKey(t => t.MakeID);
            
            CreateTable(
                "dbo.Trims",
                c => new
                    {
                        TrimID = c.Int(nullable: false, identity: true),
                        TrimName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.TrimID);
            
            CreateTable(
                "dbo.Parts",
                c => new
                    {
                        PartID = c.Int(nullable: false, identity: true),
                        PartNumber = c.Int(nullable: false),
                        PartName = c.String(nullable: false, maxLength: 40),
                        Price = c.Double(nullable: false),
                        PartBrand = c.String(),
                        Qty = c.Short(nullable: false),
                        Repairs_RepairID = c.Int(),
                    })
                .PrimaryKey(t => t.PartID)
                .ForeignKey("dbo.Repairs", t => t.Repairs_RepairID)
                .Index(t => t.Repairs_RepairID);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        RepairID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        LaborCost = c.Double(nullable: false),
                        PartCost = c.Double(nullable: false),
                        TotalCost = c.Double(nullable: false),
                        ShopName = c.String(),
                        Mileage = c.Int(nullable: false),
                        Misc = c.String(),
                        RepairDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RepairID);
            
            CreateTable(
                "dbo.UserCars",
                c => new
                    {
                        UserCarId = c.Int(nullable: false, identity: true),
                        CarNameDescription = c.String(maxLength: 40),
                        Year = c.Int(nullable: false),
                        Make = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Trim = c.String(nullable: false),
                        Engine = c.String(),
                        Vin = c.String(maxLength: 17),
                        Plate = c.String(maxLength: 8),
                        State = c.String(),
                        Color = c.String(),
                        UniqueIdentifiers = c.String(maxLength: 100),
                        OilGrade = c.String(),
                        OilFilter = c.String(),
                        AirFilter = c.String(),
                        SparkPlugs = c.String(),
                        HeadlightBulb = c.String(),
                        TireSize = c.String(),
                        PurchaseDate = c.DateTime(),
                        PurchasePrice = c.Double(nullable: false),
                        PurchaseMileage = c.Int(nullable: false),
                        Warranty = c.Boolean(nullable: false),
                        ExpirationDate = c.DateTime(),
                        ExpirationMileage = c.Int(nullable: false),
                        Comments = c.String(maxLength: 500),
                        UserId_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.UserCarId)
                .ForeignKey("dbo.Users", t => t.UserId_UserID)
                .Index(t => t.UserId_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        LastName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.UserID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserCars", "UserId_UserID", "dbo.Users");
            DropForeignKey("dbo.Parts", "Repairs_RepairID", "dbo.Repairs");
            DropForeignKey("dbo.TrimModels", "Model_ModelID", "dbo.Models");
            DropForeignKey("dbo.TrimModels", "Trim_TrimID", "dbo.Trims");
            DropForeignKey("dbo.Models", "Makes_MakeID", "dbo.Makes");
            DropForeignKey("dbo.ModelEngines", "Engine_EngineID", "dbo.Engines");
            DropForeignKey("dbo.ModelEngines", "Model_ModelID", "dbo.Models");
            DropIndex("dbo.TrimModels", new[] { "Model_ModelID" });
            DropIndex("dbo.TrimModels", new[] { "Trim_TrimID" });
            DropIndex("dbo.ModelEngines", new[] { "Engine_EngineID" });
            DropIndex("dbo.ModelEngines", new[] { "Model_ModelID" });
            DropIndex("dbo.UserCars", new[] { "UserId_UserID" });
            DropIndex("dbo.Parts", new[] { "Repairs_RepairID" });
            DropIndex("dbo.Models", new[] { "Makes_MakeID" });
            DropTable("dbo.TrimModels");
            DropTable("dbo.ModelEngines");
            DropTable("dbo.Users");
            DropTable("dbo.UserCars");
            DropTable("dbo.Repairs");
            DropTable("dbo.Parts");
            DropTable("dbo.Trims");
            DropTable("dbo.Makes");
            DropTable("dbo.Models");
            DropTable("dbo.Engines");
        }
    }
}
