using DystopianWarsCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DystopianWarsCampaign.Controllers
{
    public class MapController : Controller
    {
        private DystopianCampaignContext db = new DystopianCampaignContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectTerritory(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Territory territory = db.Territories.Find(id);
            if (territory == null)
            {
                return HttpNotFound();
            }
            return PartialView(territory);
        }
    }
}