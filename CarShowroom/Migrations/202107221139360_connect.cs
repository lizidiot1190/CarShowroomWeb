namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class connect : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.MoreProductImages");
            AddColumn("dbo.MoreProductImages", "Product_id", c => c.Long());
            AddPrimaryKey("dbo.MoreProductImages", "productId");
            CreateIndex("dbo.MoreProductImages", "Product_id");
            AddForeignKey("dbo.MoreProductImages", "Product_id", "dbo.Product", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MoreProductImages", "Product_id", "dbo.Product");
            DropIndex("dbo.MoreProductImages", new[] { "Product_id" });
            DropPrimaryKey("dbo.MoreProductImages");
            DropColumn("dbo.MoreProductImages", "Product_id");
            AddPrimaryKey("dbo.MoreProductImages", "id");
        }
    }
}
