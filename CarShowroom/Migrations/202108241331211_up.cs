namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class up : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Info", "content", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Info", "content", c => c.String(storeType: "ntext"));
        }
    }
}
