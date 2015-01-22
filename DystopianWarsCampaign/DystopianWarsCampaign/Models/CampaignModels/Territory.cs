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
        public int Id { get; set; }
        
        //Meta
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Faction Faction { get; set; }
        
        //Markup
        public int FlagXCoord { get; set; }
        public int FlagYCoord { get; set; }

        public Territory()
        {

        }
    }
}