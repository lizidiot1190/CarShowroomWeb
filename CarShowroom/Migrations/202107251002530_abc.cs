namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class abc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Info", "image", c => c.String());
            AlterColumn("dbo.User", "passWord", c => c.String(maxLength: 32));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "passWord", c => c.String(maxLength: 500));
            AlterColumn("dbo.Info", "image", c => c.String(maxLength: 250));
        }
    }
}
