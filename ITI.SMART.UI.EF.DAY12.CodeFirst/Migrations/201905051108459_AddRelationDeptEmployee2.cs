namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationDeptEmployee2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employee", "FK_DepartmentId", "dbo.Department");
            AddForeignKey("dbo.Employee", "FK_DepartmentId", "dbo.Department", "DeptId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "FK_DepartmentId", "dbo.Department");
            AddForeignKey("dbo.Employee", "FK_DepartmentId", "dbo.Department", "DeptId");
        }
    }
}
