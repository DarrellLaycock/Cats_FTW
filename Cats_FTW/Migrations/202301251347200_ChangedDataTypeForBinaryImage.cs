namespace Cats_FTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDataTypeForBinaryImage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CatImages", "BinaryData", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CatImages", "BinaryData", c => c.Binary());
        }
    }
}
