namespace DystopianWarsCampaign.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTerritoriesWithReferencesToBonussesAndUpgrades : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TerritoryBonus", "Territory_ID", c => c.Int());
            AddColumn("dbo.TerritoryUpgrades", "Territory_ID", c => c.Int());
            CreateIndex("dbo.TerritoryBonus", "Territory_ID");
            CreateIndex("dbo.TerritoryUpgrades", "Territory_ID");
            AddForeignKey("dbo.TerritoryBonus", "Territory_ID", "dbo.Territories", "ID");
            AddForeignKey("dbo.TerritoryUpgrades", "Territory_ID", "dbo.Territories", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TerritoryUpgrades", "Territory_ID", "dbo.Territories");
            DropForeignKey("dbo.TerritoryBonus", "Territory_ID", "dbo.Territories");
            DropIndex("dbo.TerritoryUpgrades", new[] { "Territory_ID" });
            DropIndex("dbo.TerritoryBonus", new[] { "Territory_ID" });
            DropColumn("dbo.TerritoryUpgrades", "Territory_ID");
            DropColumn("dbo.TerritoryBonus", "Territory_ID");
        }
    }
}
