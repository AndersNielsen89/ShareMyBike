namespace ShareMyBike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bike : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bike",
                c => new
                    {
                        BikeId = c.Int(nullable: false, identity: true),
                        BikeModel = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.BikeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bike");
        }
    }
}
