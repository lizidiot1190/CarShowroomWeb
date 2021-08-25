namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _500char : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "description", c => c.String(maxLength: 500));
        }
    }
}
