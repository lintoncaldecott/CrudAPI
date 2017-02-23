namespace CrudAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removefullname : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.User", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "FullName", c => c.String());
        }
    }
}
