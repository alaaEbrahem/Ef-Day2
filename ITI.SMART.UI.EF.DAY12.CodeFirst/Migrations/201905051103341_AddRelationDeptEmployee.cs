namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRelationDeptEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "FK_DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employee", "FK_DepartmentId");
            AddForeignKey("dbo.Employee", "FK_DepartmentId", "dbo.Department", "DeptId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "FK_DepartmentId", "dbo.Department");
            DropIndex("dbo.Employee", new[] { "FK_DepartmentId" });
            DropColumn("dbo.Employee", "FK_DepartmentId");
        }
    }
}
