namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
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
                "dbo.Parts",
                c => new
                    {
                        PartID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PartID);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        RepairID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        LaborCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.RepairID);
            
            CreateTable(
                "dbo.UserCars",
                c => new
                    {
                        UserCarId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
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
                    })
                .PrimaryKey(t => t.UserCarId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        LastName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Models", "Makes_MakeID", "dbo.Makes");
            DropIndex("dbo.Models", new[] { "Makes_MakeID" });
            DropTable("dbo.Users");
            DropTable("dbo.UserCars");
            DropTable("dbo.Repairs");
            DropTable("dbo.Parts");
            DropTable("dbo.Models");
            DropTable("dbo.Makes");
        }
    }
}
