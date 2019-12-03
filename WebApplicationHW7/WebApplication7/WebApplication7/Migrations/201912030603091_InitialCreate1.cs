namespace WebApplication7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserAdmins", "Age");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserAdmins", "Age", c => c.Int());
        }
    }
}
