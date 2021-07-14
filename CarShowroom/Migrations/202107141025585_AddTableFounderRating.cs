namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableFounderRating : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Founders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 255),
                        image = c.String(maxLength: 255),
                        slogan = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 255),
                        image = c.String(maxLength: 255),
                        comment = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Info", "name", c => c.String(maxLength: 250));
            AddColumn("dbo.Info", "image", c => c.String(maxLength: 250));
            AddColumn("dbo.Product", "productInfo", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "productInfo");
            DropColumn("dbo.Info", "image");
            DropColumn("dbo.Info", "name");
            DropTable("dbo.Ratings");
            DropTable("dbo.Founders");
        }
    }
}
