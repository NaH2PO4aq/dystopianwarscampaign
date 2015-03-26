using DystopianWarsCampaign.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace DystopianWarsCampaign.Controllers
{
    public class HomeController : Controller
    {
        private DystopianCampaignContext db = new DystopianCampaignContext();

        public ActionResult Index()
        {
            var News = db.News.ToList();
            return View(News);
        }

        public ActionResult About()
        {
            ViewBag.Message = "About the Dystopian Wars Campaign website";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Campaign Battleground Locations";

            return View();
        }
    }
}