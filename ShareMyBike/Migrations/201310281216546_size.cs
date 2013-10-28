namespace ShareMyBike.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class size : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bike", "Size", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bike", "Size");
        }
    }
}
