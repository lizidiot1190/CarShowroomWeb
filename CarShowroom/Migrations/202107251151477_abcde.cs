namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abcde : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Slide", "description", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Slide", "description", c => c.String(maxLength: 50));
        }
    }
}
