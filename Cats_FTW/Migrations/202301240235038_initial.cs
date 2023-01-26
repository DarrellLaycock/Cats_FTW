namespace Cats_FTW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CatFacts",
                c => new
                    {
                        UID = c.String(nullable: false, maxLength: 8),
                        Text = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        InsertUserId = c.Int(),
                        InsertedDateTime = c.DateTime(),
                        UpdatedDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.UID);
            
            CreateTable(
                "dbo.CatImages",
                c => new
                    {
                        UID = c.String(nullable: false, maxLength: 8),
                        Data = c.String(),
                        AltText = c.String(),
                        LikesCount = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        InsertUserId = c.Int(),
                        InsertedDateTime = c.DateTime(),
                        UpdatedDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.UID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CatImages");
            DropTable("dbo.CatFacts");
        }
    }
}
