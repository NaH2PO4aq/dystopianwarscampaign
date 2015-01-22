using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DystopianWarsCampaign.Models;
using DystopianWarsCampaign.Models.CampaignModels;

namespace DystopianWarsCampaign.Controllers.Admin
{
    public class TerritoryUpgradesController : Controller
    {
        private CampaignContext db = new CampaignContext();

        // GET: TerritoryUpgrades
        public ActionResult Index()
        {
            return View(db.TerritoryUpgrades.ToList());
        }

        // GET: TerritoryUpgrades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TerritoryUpgrade territoryUpgrade = db.TerritoryUpgrades.Find(id);
            if (territoryUpgrade == null)
            {
                return HttpNotFound();
            }
            return View(territoryUpgrade);
        }

        // GET: TerritoryUpgrades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TerritoryUpgrades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] TerritoryUpgrade territoryUpgrade)
        {
            if (ModelState.IsValid)
            {
                db.TerritoryUpgrades.Add(territoryUpgrade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(territoryUpgrade);
        }

        // GET: TerritoryUpgrades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TerritoryUpgrade territoryUpgrade = db.TerritoryUpgrades.Find(id);
            if (territoryUpgrade == null)
            {
                return HttpNotFound();
            }
            return View(territoryUpgrade);
        }

        // POST: TerritoryUpgrades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] TerritoryUpgrade territoryUpgrade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(territoryUpgrade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(territoryUpgrade);
        }

        // GET: TerritoryUpgrades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TerritoryUpgrade territoryUpgrade = db.TerritoryUpgrades.Find(id);
            if (territoryUpgrade == null)
            {
                return HttpNotFound();
            }
            return View(territoryUpgrade);
        }

        // POST: TerritoryUpgrades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TerritoryUpgrade territoryUpgrade = db.TerritoryUpgrades.Find(id);
            db.TerritoryUpgrades.Remove(territoryUpgrade);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
