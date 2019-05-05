namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo._Users",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   name = c.String(),
               })
               .PrimaryKey(t => t.Id);
            Sql("Insert into dbo._Users (name) select name from dbo.Users");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("Insert into dbo.Users (name) select name from dbo._Users");
            DropTable("dbo._Users");

        }
    }
}
