namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        AuthorId = c.Int(nullable: false),
                        DesignerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.User", t => t.AuthorId)
                .ForeignKey("dbo.User", t => t.DesignerId)
                .Index(t => t.AuthorId)
                .Index(t => t.DesignerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "DesignerId", "dbo.User");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.User");
            DropIndex("dbo.Books", new[] { "DesignerId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.Books");
        }
    }
}
