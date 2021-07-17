namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changename1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Category", newName: "ContentCategory");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ContentCategory", newName: "Category");
        }
    }
}
