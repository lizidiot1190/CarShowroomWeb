namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAllTable3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        userName = c.String(maxLength: 50),
                        passWord = c.String(maxLength: 32),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
