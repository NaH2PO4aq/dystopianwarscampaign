using DystopianWarsCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DystopianWarsCampaign.Controllers
{
    public class SummaryController : Controller
    {
        private CampaignContext db = new CampaignContext();
        // GET: Summary
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Faction(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Faction faction = db.Factions.Find(id);
            if (faction == null)
            {
                return HttpNotFound();
            }
            return View(faction);
        }
    }
}