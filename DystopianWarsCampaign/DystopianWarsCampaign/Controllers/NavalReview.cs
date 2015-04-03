using DystopianWarsCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DystopianWarsCampaign.Controllers
{
    public class NavalReviewController : Controller
    {
        private DystopianCampaignContext db = new DystopianCampaignContext();

        // GET: NavalReview
        public ActionResult Index()
        {
            var NavalReview = db.NavalReview.ToList();
            return View(NavalReview);
        }
    }
}