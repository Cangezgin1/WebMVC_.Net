namespace DataAccsesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_updateAdminStatü : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "AdminStatü", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "AdminStatü", c => c.String(maxLength: 1));
        }
    }
}
