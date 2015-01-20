using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DystopianWarsCampaign.Models.Map
{
    public class Territory
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public virtual ICollection<TerritoryBonus> Bonuses { get; set; }
        public virtual ICollection<TerritoryUpgrade> Upgrades { get; set; }
    }
}