namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asndsand : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Slide");
            AlterColumn("dbo.Slide", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Slide", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Slide");
            AlterColumn("dbo.Slide", "id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Slide", "id");
        }
    }
}
