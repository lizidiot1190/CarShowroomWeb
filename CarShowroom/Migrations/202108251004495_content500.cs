namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class content500 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Content", "description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Content", "description", c => c.String(maxLength: 500));
        }
    }
}
