namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Umbalaxibua : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Info", "link", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Info", "link");
        }
    }
}
