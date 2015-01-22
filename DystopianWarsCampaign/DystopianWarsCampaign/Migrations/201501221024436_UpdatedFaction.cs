namespace DystopianWarsCampaign.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedFaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Factions", "Acronym", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Factions", "Acronym");
        }
    }
}
