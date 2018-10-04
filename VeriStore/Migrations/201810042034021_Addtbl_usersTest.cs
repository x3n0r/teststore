namespace VeriStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addtbl_usersTest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_users", "Test", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_users", "Test");
        }
    }
}
