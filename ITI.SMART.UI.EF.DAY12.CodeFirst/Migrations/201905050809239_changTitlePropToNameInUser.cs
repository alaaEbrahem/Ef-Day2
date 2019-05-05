namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changTitlePropToNameInUser : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Users", "Title", "name");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Users", "name", "Title");
        }
    }
}
