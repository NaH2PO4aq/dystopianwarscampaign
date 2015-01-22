using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DystopianWarsCampaign.Models
{
    public class Faction
    {
        //Database
        [Key]
        public int ID { get; set; }
        
        //Meta
        public string Name { get; set; }
        public string Acronym { get; set; }

        public string FlagURL { get; set; }

        public string HomeFleet { get; set; }
        public string AwayFleet { get; set; }

        public Faction()
        {

        }
    }
}