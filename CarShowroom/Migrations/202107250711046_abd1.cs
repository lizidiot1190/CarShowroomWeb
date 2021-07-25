namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abd1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "passWord", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "passWord", c => c.String(maxLength: 32));
        }
    }
}
