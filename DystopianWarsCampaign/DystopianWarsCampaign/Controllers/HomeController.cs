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
        public ActionResult Index()
        {
            //Comment added.
            return View();
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