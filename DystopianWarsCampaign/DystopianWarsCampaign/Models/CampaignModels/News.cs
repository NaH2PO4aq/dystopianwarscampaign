using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DystopianWarsCampaign.Models
{
    public class News
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
