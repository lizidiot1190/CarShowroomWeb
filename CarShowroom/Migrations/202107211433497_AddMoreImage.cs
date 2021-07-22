namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreImage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MoreProductImages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        productId = c.Int(nullable: false),
                        img1 = c.String(maxLength: 255),
                        img2 = c.String(maxLength: 255),
                        img3 = c.String(maxLength: 255),
                        img4 = c.String(maxLength: 255),
                        img5 = c.String(maxLength: 255),
                        img6 = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Slide", "imgContent", c => c.String(maxLength: 250));
            DropColumn("dbo.Product", "inImages");
            DropColumn("dbo.Product", "outImages");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "outImages", c => c.String(storeType: "xml"));
            AddColumn("dbo.Product", "inImages", c => c.String(storeType: "xml"));
            DropColumn("dbo.Slide", "imgContent");
            DropTable("dbo.MoreProductImages");
        }
    }
}
