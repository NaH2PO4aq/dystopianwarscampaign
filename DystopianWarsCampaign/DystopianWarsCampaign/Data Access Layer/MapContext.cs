using DystopianWarsCampaign.Models.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DystopianWarsCampaign.Data_Access_Layer
{
    public class MapContext : DbContext
    {
        public MapContext()
            : base("MapContext")
        {
            Database.SetInitializer<MapContext>(new MapInitializer());
        }

        public DbSet<Territory> Territories { get; set; }
        public DbSet<TerritoryBonus> TerritoryBonuses { get; set; }
        public DbSet<TerritoryUpgrade> TerritoryUpgrades { get; set; }
    }
}