namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "metaTitle", c => c.String(maxLength: 250));
            DropColumn("dbo.Category", "metaTite");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "metaTite", c => c.String(maxLength: 250));
            DropColumn("dbo.Category", "metaTitle");
        }
    }
}
