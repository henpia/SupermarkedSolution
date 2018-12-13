namespace Supermarked.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lokation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vare", "Lokation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vare", "Lokation");
        }
    }
}
