namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(maxLength: 250),
                        metaTitle = c.String(maxLength: 250),
                        parentID = c.Long(),
                        displayOrder = c.Int(),
                        seoTitle = c.String(maxLength: 250),
                        cratedDate = c.DateTime(),
                        metaKeywords = c.String(maxLength: 250),
                        metaDiscription = c.String(maxLength: 250),
                        status = c.Boolean(),
                        showOnHome = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 50),
                        phoneNumber = c.String(maxLength: 50),
                        email = c.String(maxLength: 50),
                        address = c.String(maxLength: 50),
                        content = c.String(maxLength: 250),
                        createdDate = c.DateTime(),
                        status = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Content",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(maxLength: 250),
                        metaTitle = c.String(maxLength: 250),
                        description = c.String(maxLength: 500),
                        image = c.String(maxLength: 250),
                        categoryID = c.Long(),
                        metaKeywords = c.String(maxLength: 250),
                        metaDescription = c.String(maxLength: 250),
                        status = c.Boolean(),
                        topHot = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Info",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        content = c.String(storeType: "ntext"),
                        status = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProductCategory",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        name = c.String(maxLength: 250),
                        metaTitle = c.String(maxLength: 250),
                        parentID = c.Long(),
                        displayOrder = c.Int(),
                        seoTitle = c.String(maxLength: 250),
                        createdDate = c.DateTime(),
                        metaKeywords = c.String(maxLength: 250),
                        metaDiscription = c.String(maxLength: 250),
                        status = c.Boolean(),
                        showOnHome = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        metaTitle = c.String(maxLength: 250),
                        name = c.String(maxLength: 250),
                        description = c.String(maxLength: 500),
                        image = c.String(maxLength: 250),
                        inImages = c.String(storeType: "xml"),
                        outImages = c.String(storeType: "xml"),
                        price = c.Decimal(precision: 18, scale: 2),
                        promotionPrice = c.Decimal(precision: 18, scale: 2),
                        categoryID = c.Long(),
                        metaKeywords = c.String(maxLength: 250),
                        metaDescription = c.String(maxLength: 250),
                        status = c.Boolean(),
                        topHot = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Slide",
                c => new
                    {
                        id = c.Int(nullable: false),
                        image = c.String(maxLength: 250),
                        displayOrder = c.Int(),
                        link = c.String(maxLength: 250),
                        description = c.String(maxLength: 50),
                        createdDate = c.DateTime(),
                        status = c.Boolean(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        userName = c.String(maxLength: 50),
                        passWord = c.String(maxLength: 32),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.Slide");
            DropTable("dbo.Product");
            DropTable("dbo.ProductCategory");
            DropTable("dbo.Info");
            DropTable("dbo.Content");
            DropTable("dbo.Contact");
            DropTable("dbo.Category");
        }
    }
}
