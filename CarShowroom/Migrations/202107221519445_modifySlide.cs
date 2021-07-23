namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifySlide : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Slide", "imgContent");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Slide", "imgContent", c => c.String(maxLength: 250));
        }
    }
}
