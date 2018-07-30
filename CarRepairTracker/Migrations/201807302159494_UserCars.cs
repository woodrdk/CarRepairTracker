namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserCars : DbMigration
    {
        public override void Up()
        {
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
                        PurchaseDate = c.DateTime(nullable: false),
                        PurchasePrice = c.Double(nullable: false),
                        PurchaseMileage = c.Int(nullable: false),
                        Warranty = c.Boolean(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        ExpirationMileage = c.Int(nullable: false),
                        Comments = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.UserCarId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserCars");
        }
    }
}
