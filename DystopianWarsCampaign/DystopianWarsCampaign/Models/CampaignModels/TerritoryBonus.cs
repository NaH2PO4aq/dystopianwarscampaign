using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DystopianWarsCampaign.Models.CampaignModels
{
    public class TerritoryBonus
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RPBonus { get; set; }

        public TerritoryBonus()
        {

        }
    }
}