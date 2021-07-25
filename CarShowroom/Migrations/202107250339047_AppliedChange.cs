namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppliedChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Info", "image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Info", "image", c => c.String(maxLength: 250));
        }
    }
}
