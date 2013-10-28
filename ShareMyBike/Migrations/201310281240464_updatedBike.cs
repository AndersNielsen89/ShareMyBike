namespace ShareMyBike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedBike : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bike", "UserId", c => c.Int());
            AddForeignKey("dbo.Bike", "UserId", "dbo.UserProfile", "UserId");
            CreateIndex("dbo.Bike", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Bike", new[] { "UserId" });
            DropForeignKey("dbo.Bike", "UserId", "dbo.UserProfile");
            DropColumn("dbo.Bike", "UserId");
        }
    }
}
