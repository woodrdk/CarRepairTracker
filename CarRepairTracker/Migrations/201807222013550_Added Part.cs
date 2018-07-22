namespace CarRepairTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parts",
                c => new
                    {
                        PartID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PartID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parts");
        }
    }
}
