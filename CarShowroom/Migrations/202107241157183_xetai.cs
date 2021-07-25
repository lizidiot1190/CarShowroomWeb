namespace CarShowroom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xetai : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "loaiXe", c => c.String(maxLength: 255));
            AddColumn("dbo.Product", "loaiThung", c => c.String(maxLength: 255));
            AddColumn("dbo.Product", "taiTrong", c => c.String(maxLength: 255));
            AddColumn("dbo.Product", "namSX", c => c.String(maxLength: 255));
            AddColumn("dbo.Product", "nhapKhau", c => c.String(maxLength: 255));
            AddColumn("dbo.Product", "nhienLieu", c => c.String(maxLength: 255));
            AddColumn("dbo.Product", "hopSo", c => c.String(maxLength: 255));
            DropColumn("dbo.Product", "productInfo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "productInfo", c => c.String(maxLength: 500));
            DropColumn("dbo.Product", "hopSo");
            DropColumn("dbo.Product", "nhienLieu");
            DropColumn("dbo.Product", "nhapKhau");
            DropColumn("dbo.Product", "namSX");
            DropColumn("dbo.Product", "taiTrong");
            DropColumn("dbo.Product", "loaiThung");
            DropColumn("dbo.Product", "loaiXe");
        }
    }
}
