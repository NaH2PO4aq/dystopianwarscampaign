namespace DystopianWarsCampaign.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTerritoryBonuswithRPBonus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TerritoryBonus", "RPBonus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TerritoryBonus", "RPBonus");
        }
    }
}
