namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Umbalaxibua1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Info", "link", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Info", "link", c => c.Boolean(nullable: false));
        }
    }
}
