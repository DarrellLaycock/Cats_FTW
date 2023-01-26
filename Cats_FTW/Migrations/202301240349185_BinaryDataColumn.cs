namespace Cats_FTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BinaryDataColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CatImages", "BinaryData", c => c.Binary());
            AddColumn("dbo.CatImages", "Url", c => c.String());
            DropColumn("dbo.CatImages", "Data");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CatImages", "Data", c => c.String());
            DropColumn("dbo.CatImages", "Url");
            DropColumn("dbo.CatImages", "BinaryData");
        }
    }
}
