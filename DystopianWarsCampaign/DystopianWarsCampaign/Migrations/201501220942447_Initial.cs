namespace DystopianWarsCampaign.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FlagURL = c.String(),
                        HomeFleet = c.String(),
                        AwayFleet = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Territories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        FlagXCoord = c.Int(nullable: false),
                        FlagYCoord = c.Int(nullable: false),
                        Faction_ID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Factions", t => t.Faction_ID)
                .Index(t => t.Faction_ID);
            
            CreateTable(
                "dbo.TerritoryBonus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TerritoryUpgrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Territories", "Faction_ID", "dbo.Factions");
            DropIndex("dbo.Territories", new[] { "Faction_ID" });
            DropTable("dbo.TerritoryUpgrades");
            DropTable("dbo.TerritoryBonus");
            DropTable("dbo.Territories");
            DropTable("dbo.Factions");
        }
    }
}
