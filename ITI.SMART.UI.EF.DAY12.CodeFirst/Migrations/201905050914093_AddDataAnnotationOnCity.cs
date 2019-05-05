namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationOnCity : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cities", newName: "City");
            RenameColumn(table: "dbo.City", name: "CountryId", newName: "FK_CountryId");
            RenameIndex(table: "dbo.City", name: "IX_CountryId", newName: "IX_FK_CountryId");
            AlterColumn("dbo.City", "name", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.City", "name", c => c.String());
            RenameIndex(table: "dbo.City", name: "IX_FK_CountryId", newName: "IX_CountryId");
            RenameColumn(table: "dbo.City", name: "FK_CountryId", newName: "CountryId");
            RenameTable(name: "dbo.City", newName: "Cities");
        }
    }
}
