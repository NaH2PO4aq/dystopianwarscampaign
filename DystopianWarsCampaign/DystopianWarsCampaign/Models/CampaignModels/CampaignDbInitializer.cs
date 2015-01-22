using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DystopianWarsCampaign.Models.CampaignModels
{
    public class CampaignDbInitializer:DropCreateDatabaseIfModelChanges<CampaignContext>
    {
        protected override void Seed(CampaignContext context)
        {
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
            territories.ForEach(t => context.Territories.Add(t));
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
            territoryUpgrades.ForEach(tu => context.TerritoryUpgrades.Add(tu));
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
            territoryBonuses.ForEach(tb => context.TerritoryBonuses.Add(tb));
            context.SaveChanges();
        }
    }
}