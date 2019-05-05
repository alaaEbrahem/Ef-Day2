namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationemplBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeBooks",
                c => new
                    {
                        Employee_id = c.Int(nullable: false),
                        Book_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Employee_id, t.Book_id })
                .ForeignKey("dbo.Employee", t => t.Employee_id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_id, cascadeDelete: true)
                .Index(t => t.Employee_id)
                .Index(t => t.Book_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeBooks", "Book_id", "dbo.Books");
            DropForeignKey("dbo.EmployeeBooks", "Employee_id", "dbo.Employee");
            DropIndex("dbo.EmployeeBooks", new[] { "Book_id" });
            DropIndex("dbo.EmployeeBooks", new[] { "Employee_id" });
            DropTable("dbo.EmployeeBooks");
        }
    }
}
