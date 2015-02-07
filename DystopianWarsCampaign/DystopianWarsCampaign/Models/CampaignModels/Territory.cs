using DystopianWarsCampaign.Models.CampaignModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DystopianWarsCampaign.Models
{
    public class Territory
    {
        //Database
        [Key]
        public int ID { get; set; }
        
        //Meta
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Faction Faction { get; set; }

        public virtual ICollection<TerritoryBonus> Bonuses { get; set; }
        public virtual ICollection<TerritoryUpgrade> Upgrades { get; set; }

        //Markup
        public int FlagXCoord { get; set; }
        public int FlagYCoord { get; set; }

        public Territory()
        {
            Bonuses = new List<TerritoryBonus>();
            Upgrades = new List<TerritoryUpgrade>();
        }
    }
}