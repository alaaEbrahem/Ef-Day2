namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookCity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpBooks", "FK_BookId", "dbo.Books");
            DropPrimaryKey("dbo.Books");
            CreateTable(
                "dbo.cover",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        code = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Books", "id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Books", "id");
            CreateIndex("dbo.Books", "id");
            AddForeignKey("dbo.Books", "id", "dbo.City", "id");
            AddForeignKey("dbo.EmpBooks", "FK_BookId", "dbo.Books", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpBooks", "FK_BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "id", "dbo.City");
            DropIndex("dbo.Books", new[] { "id" });
            DropPrimaryKey("dbo.Books");
            AlterColumn("dbo.Books", "id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.cover");
            AddPrimaryKey("dbo.Books", "id");
            AddForeignKey("dbo.EmpBooks", "FK_BookId", "dbo.Books", "id", cascadeDelete: true);
        }
    }
}
