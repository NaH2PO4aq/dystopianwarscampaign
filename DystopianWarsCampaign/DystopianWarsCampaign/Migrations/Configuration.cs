namespace DystopianWarsCampaign.Migrations
{
    using DystopianWarsCampaign.Models;
    using DystopianWarsCampaign.Models.CampaignModels;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DystopianWarsCampaign.Models.DystopianCampaignContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DystopianWarsCampaign.Models.DystopianCampaignContext context)
        {
            var territoryBonuses = new TerritoryBonus[]
            {
                new TerritoryBonus{Name="Town", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Town", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Oil Rigs", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Oil Rigs", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Industrial Complex", Description="+10 additional requisition per turn."},
                new TerritoryBonus{Name="Inhospitable", Description="Upgrades on this territory cost an additional 50%."},
                new TerritoryBonus{Name="Inhospitable", Description="Upgrades on this territory cost an additional 50%."},
                new TerritoryBonus{Name="Monument", Description="Uses standard tower stats without weapons. Provides Die Hard Attitude (Owner's Faction, 16'')."},
                new TerritoryBonus{Name="Lighthouse", Description="Uses standard tower stats without weapons. May function as an Expert Spotter."}
            };
            context.TerritoryBonuses.AddOrUpdate(tb => tb.Name, territoryBonuses);
            context.SaveChanges();

            var territoryUpgrades = new TerritoryUpgrade[]
            {
                new TerritoryUpgrade{Name="Upgrade 1", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 2", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 3", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 4", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 5", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 6", Description="Upgrade description goes here."}
            };
            context.TerritoryUpgrades.AddOrUpdate(tu => tu.Name, territoryUpgrades);
            context.SaveChanges();

            var factions = new Faction[]
            {
                new Faction{Name="Federated States of America", Acronym="FSA", FlagURL="~/Content/Images/FSA.jpg"},
                new Faction{Name="Prussian Empire", Acronym="PE", FlagURL="~/Content/Images/PE.jpg"},
                new Faction{Name="Covenant of Sidrial", Acronym="SID", FlagURL="~/Content/Images/SID.jpg"},
                new Faction{Name="Covenant of Antarctica 11th War Fleet 'Novalis's Mercy'", Acronym="COA", FlagURL="~/Content/Images/COA.jpg"},
                new Faction{
                    Name="Republique of France", 
                    Acronym="RoF", 
                    FlagURL="~/Content/Images/ROF.jpg",
                    AwayFleet="",
                    HomeFleet=""
                },
                new Faction{Name="Neutral", Acronym="-", FlagURL="", AwayFleet="", HomeFleet=""}
            };
            context.Factions.AddOrUpdate(fac => fac.Name, factions);
            context.SaveChanges();

            var territories = new Territory[]
            {
                new Territory{Name="Territory 01", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 02", Faction=factions[0], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 03", Faction=factions[0], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 04", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 05", Faction=factions[2], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 06", Faction=factions[2], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 07", Faction=factions[4], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 08", Faction=factions[0], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 09", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 10", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 11", Faction=factions[2], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 12", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 13", Faction=factions[4], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 14", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 15", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 16", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 17", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 18", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 19", Faction=factions[4], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 20", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 21", Faction=factions[3], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 22", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 23", Faction=factions[1], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 24", Faction=factions[1], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 25", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 26", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 27", Faction=factions[3], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 28", Faction=factions[3], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 29", Faction=factions[5], Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 30", Faction=factions[1], Description="Description goes here", FlagXCoord=0, FlagYCoord=0}
            };
            //Towns
            territories[14].Bonuses.Add(territoryBonuses[0]);
            territories[21].Bonuses.Add(territoryBonuses[1]);
            //Rigs
            territories[9].Bonuses.Add(territoryBonuses[2]);
            territories[15].Bonuses.Add(territoryBonuses[3]);
            //Industrial Complex
            territories[8].Bonuses.Add(territoryBonuses[4]);
            //Inhospitable
            territories[11].Bonuses.Add(territoryBonuses[5]);
            territories[24].Bonuses.Add(territoryBonuses[6]);
            //Monuments
            territories[28].Bonuses.Add(territoryBonuses[7]);

            context.Territories.AddOrUpdate(t => t.Name, territories);
            context.SaveChanges();
        }
    }
}
