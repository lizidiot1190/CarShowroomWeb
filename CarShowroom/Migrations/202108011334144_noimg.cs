namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class noimg : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ratings", "image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ratings", "image", c => c.String(maxLength: 255));
        }
    }
}
