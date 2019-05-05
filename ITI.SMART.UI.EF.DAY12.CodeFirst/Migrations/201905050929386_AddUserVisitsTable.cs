namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserVisitsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserVisit",
                c => new
                    {
                        FK_UserId = c.Int(nullable: false),
                        FK_CityId = c.Int(nullable: false),
                        when = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.FK_UserId, t.FK_CityId })
                .ForeignKey("dbo.City", t => t.FK_CityId, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.FK_UserId, cascadeDelete: true)
                .Index(t => t.FK_UserId)
                .Index(t => t.FK_CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserVisit", "FK_UserId", "dbo.User");
            DropForeignKey("dbo.UserVisit", "FK_CityId", "dbo.City");
            DropIndex("dbo.UserVisit", new[] { "FK_CityId" });
            DropIndex("dbo.UserVisit", new[] { "FK_UserId" });
            DropTable("dbo.UserVisit");
        }
    }
}
