namespace Supermarked.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TilføjetTestVaretilSeedmethod : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vare", "Lokation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vare", "Lokation", c => c.String());
        }
    }
}
