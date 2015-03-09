using DystopianWarsCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DystopianWarsCampaign.Controllers
{
    public class FactionsController : Controller
    {
        private DystopianCampaignContext db = new DystopianCampaignContext();

        // GET: Factions
        public ActionResult Index()
        {
            var Factions = db.Factions.ToList();
            return View(Factions);
        }
    }
}