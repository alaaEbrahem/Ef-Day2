namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changNamePropToTitleInUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Title", c => c.String());
            Sql("update users set Title=name");
            DropColumn("dbo.Users", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "name", c => c.String());
            Sql("update users set name=Title");
            DropColumn("dbo.Users", "Title");
        }
    }
}
