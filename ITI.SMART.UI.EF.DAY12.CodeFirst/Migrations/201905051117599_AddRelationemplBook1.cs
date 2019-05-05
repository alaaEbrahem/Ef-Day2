namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationemplBook1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmployeeBooks", newName: "EmpBooks");
            RenameColumn(table: "dbo.EmpBooks", name: "Employee_id", newName: "FK_EmpId");
            RenameColumn(table: "dbo.EmpBooks", name: "Book_id", newName: "FK_BookId");
            RenameIndex(table: "dbo.EmpBooks", name: "IX_Employee_id", newName: "IX_FK_EmpId");
            RenameIndex(table: "dbo.EmpBooks", name: "IX_Book_id", newName: "IX_FK_BookId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.EmpBooks", name: "IX_FK_BookId", newName: "IX_Book_id");
            RenameIndex(table: "dbo.EmpBooks", name: "IX_FK_EmpId", newName: "IX_Employee_id");
            RenameColumn(table: "dbo.EmpBooks", name: "FK_BookId", newName: "Book_id");
            RenameColumn(table: "dbo.EmpBooks", name: "FK_EmpId", newName: "Employee_id");
            RenameTable(name: "dbo.EmpBooks", newName: "EmployeeBooks");
        }
    }
}
