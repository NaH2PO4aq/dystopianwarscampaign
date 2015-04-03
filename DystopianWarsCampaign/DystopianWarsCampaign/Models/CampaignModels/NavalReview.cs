using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DystopianWarsCampaign.Models
{
    public class NavalReview
    {
        //Database
        [Key]
        public int ID { get; set; }
        
        //Meta
        public string Name { get; set; }

        public NavalReview()
        {

        }
    }
}