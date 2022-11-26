namespace DataAccsesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_WriterBool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Writers", "WriterStatus", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Writers", "WriterStatus", c => c.Boolean(nullable: false));
        }
    }
}
