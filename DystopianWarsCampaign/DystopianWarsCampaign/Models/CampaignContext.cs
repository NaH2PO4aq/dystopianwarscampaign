using DystopianWarsCampaign.Models.CampaignModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DystopianWarsCampaign.Models
{
    public class DystopianCampaignContext : DbContext
    {
        public DystopianCampaignContext()
            : base()
        {

        }

        public DbSet<Faction> Factions { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<TerritoryBonus> TerritoryBonuses { get; set; }
        public DbSet<TerritoryUpgrade> TerritoryUpgrades { get; set; }
    }
}