namespace DystopianWarsCampaign.Migrations
{
    using DystopianWarsCampaign.Models;
    using DystopianWarsCampaign.Models.CampaignModels;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DystopianWarsCampaign.Models.CampaignContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DystopianWarsCampaign.Models.CampaignContext context)
        {
            //  This method will be called after migrating to the latest version.
            var factions = new List<Faction>
            {
                new Faction{Name="Federated States of America", Acronym="FSA", FlagURL="~/Content/Images/FSA.jpg"},
                new Faction{Name="Prussian Empire", Acronym="PE", FlagURL="~/Content/Images/PE.jpg"},
                new Faction{Name="Covenant of Sidrial", Acronym="SID", FlagURL="~/Content/Images/SID.jpg"},
                new Faction{Name="Covenant of Antarctica 11th War Fleet 'Novalis's Mercy'", Acronym="COA", FlagURL="~/Content/Images/COA.jpg"},
                new Faction{Name="Republique of France", Acronym="RoF", FlagURL="~/Content/Images/ROF.jpg"}
            };
            factions.ForEach(f => context.Factions.AddOrUpdate(f));
            context.SaveChanges();

            var territories = new List<Territory>
            {
                new Territory{Name="Territory 01", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 02", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 03", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 04", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 05", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 06", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 07", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 08", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 09", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 10", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 11", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 12", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 13", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 14", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 15", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 16", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 17", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 18", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 19", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 20", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 21", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 22", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 23", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 24", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 25", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 26", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 27", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 28", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 29", Description="Description goes here", FlagXCoord=0, FlagYCoord=0},
                new Territory{Name="Territory 30", Description="Description goes here", FlagXCoord=0, FlagYCoord=0}
            };
            territories.ForEach(t => context.Territories.AddOrUpdate(t));
            context.SaveChanges();

            var territoryUpgrades = new List<TerritoryUpgrade>
            {
                new TerritoryUpgrade{Name="Upgrade 1", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 2", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 3", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 4", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 5", Description="Upgrade description goes here."},
                new TerritoryUpgrade{Name="Upgrade 6", Description="Upgrade description goes here."}
            };
            territoryUpgrades.ForEach(tu => context.TerritoryUpgrades.AddOrUpdate(tu));
            context.SaveChanges();

            var territoryBonuses = new List<TerritoryBonus>
            {
                new TerritoryBonus{Name="Bonus 1", Description="Upgrade description goes here."},
                new TerritoryBonus{Name="Bonus 2", Description="Upgrade description goes here."},
                new TerritoryBonus{Name="Bonus 3", Description="Upgrade description goes here."},
                new TerritoryBonus{Name="Bonus 4", Description="Upgrade description goes here."},
                new TerritoryBonus{Name="Bonus 5", Description="Upgrade description goes here."},
                new TerritoryBonus{Name="Bonus 6", Description="Upgrade description goes here."}
            };
            territoryBonuses.ForEach(tb => context.TerritoryBonuses.AddOrUpdate(tb));
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
