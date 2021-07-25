namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Founders", "link1", c => c.String(maxLength: 255));
            AddColumn("dbo.Founders", "link2", c => c.String(maxLength: 255));
            AddColumn("dbo.Founders", "position", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Founders", "position");
            DropColumn("dbo.Founders", "link2");
            DropColumn("dbo.Founders", "link1");
        }
    }
}
