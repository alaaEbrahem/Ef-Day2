namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changDataTypeOfNameInUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "name", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "name", c => c.String());
        }
    }
}
