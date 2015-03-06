using System.ComponentModel.DataAnnotations;

namespace DystopianWarsCampaign.Models.CampaignModels
{
    public class FleetEntry
    {
        [Key]
        public int ID { get; set; }

        public string UnitName {get;set;}
        public string HullPoints { get; set;}
        public string MaximumHullPoints{get;set;}
        public string Description { get; set; }
    }
}