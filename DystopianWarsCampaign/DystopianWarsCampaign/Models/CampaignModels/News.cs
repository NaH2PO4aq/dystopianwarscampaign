using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web;


namespace DystopianWarsCampaign.Models
{
    public class News
    {
        [Key]
        public int ID { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public News()
        {

        }
    }
}
