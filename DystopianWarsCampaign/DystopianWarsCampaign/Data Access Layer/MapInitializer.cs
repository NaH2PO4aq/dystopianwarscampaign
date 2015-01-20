using DystopianWarsCampaign.Models.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DystopianWarsCampaign.Data_Access_Layer
{
    public class MapInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MapContext>
    {
        protected override void Seed(MapContext context)
        {
            var territories = new List<Territory>
            {
                new Territory{Name="Territory 1", Description="Placeholder"},
                new Territory{Name="Territory 2", Description="Placeholder"},
                new Territory{Name="Territory 3", Description="Placeholder"},
                new Territory{Name="Territory 4", Description="Placeholder"},
                new Territory{Name="Territory 5", Description="Placeholder"},
                new Territory{Name="Territory 6", Description="Placeholder"},
                new Territory{Name="Territory 7", Description="Placeholder"},
                new Territory{Name="Territory 8", Description="Placeholder"},
                new Territory{Name="Territory 9", Description="Placeholder"},
                new Territory{Name="Territory 10", Description="Placeholder"},
                new Territory{Name="Territory 11", Description="Placeholder"},
                new Territory{Name="Territory 12", Description="Placeholder"},
                new Territory{Name="Territory 13", Description="Placeholder"},
                new Territory{Name="Territory 14", Description="Placeholder"},
                new Territory{Name="Territory 15", Description="Placeholder"},
                new Territory{Name="Territory 16", Description="Placeholder"},
                new Territory{Name="Territory 17", Description="Placeholder"},
                new Territory{Name="Territory 18", Description="Placeholder"},
                new Territory{Name="Territory 19", Description="Placeholder"},
                new Territory{Name="Territory 20", Description="Placeholder"},
                new Territory{Name="Territory 21", Description="Placeholder"},
                new Territory{Name="Territory 22", Description="Placeholder"},
                new Territory{Name="Territory 23", Description="Placeholder"},
                new Territory{Name="Territory 24", Description="Placeholder"},
                new Territory{Name="Territory 25", Description="Placeholder"},
                new Territory{Name="Territory 26", Description="Placeholder"},
                new Territory{Name="Territory 27", Description="Placeholder"},
                new Territory{Name="Territory 28", Description="Placeholder"},
                new Territory{Name="Territory 29", Description="Placeholder"},
                new Territory{Name="Territory 30", Description="Placeholder"}
            };
            territories.ForEach(t => context.Territories.Add(t));
            context.SaveChanges();

            var territoryUpgrades = new List<TerritoryUpgrade>
            {
                new TerritoryUpgrade{Name="Minefields", Description="Placeholder"},
                new TerritoryUpgrade{Name="Radar Array", Description="Placeholder"},
                new TerritoryUpgrade{Name="Airfield", Description="Placeholder"},
                new TerritoryUpgrade{Name="Harbour", Description="Placeholder"},
                new TerritoryUpgrade{Name="Defensive Tower Line", Description="Placeholder"},
                new TerritoryUpgrade{Name="Bunker Complex", Description="Placeholder"}
            };
            territoryUpgrades.ForEach(t => context.TerritoryUpgrades.Add(t));
            context.SaveChanges();

            var territoryBonuses = new List<TerritoryBonus>
            {
                new TerritoryBonus{Name="Town", Description="Placeholder"},
                new TerritoryBonus{Name="Oil Rigs", Description="Placeholder"},
                new TerritoryBonus{Name="Industrial Complex", Description="Placeholder"},
                new TerritoryBonus{Name="Inhospitable", Description="Placeholder"},
                new TerritoryBonus{Name="Lighthouse", Description="Placeholder"},
                new TerritoryBonus{Name="Monument", Description="Placeholder"}
            };
            territoryBonuses.ForEach(t => context.TerritoryBonuses.Add(t));
            context.SaveChanges();
        }
    }
}