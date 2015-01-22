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
    public class TerritoryBonusController : Controller
    {
        private CampaignContext db = new CampaignContext();

        // GET: TerritoryBonus
        public ActionResult Index()
        {
            return View(db.TerritoryBonuses.ToList());
        }

        // GET: TerritoryBonus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TerritoryBonus territoryBonus = db.TerritoryBonuses.Find(id);
            if (territoryBonus == null)
            {
                return HttpNotFound();
            }
            return View(territoryBonus);
        }

        // GET: TerritoryBonus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TerritoryBonus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description")] TerritoryBonus territoryBonus)
        {
            if (ModelState.IsValid)
            {
                db.TerritoryBonuses.Add(territoryBonus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(territoryBonus);
        }

        // GET: TerritoryBonus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TerritoryBonus territoryBonus = db.TerritoryBonuses.Find(id);
            if (territoryBonus == null)
            {
                return HttpNotFound();
            }
            return View(territoryBonus);
        }

        // POST: TerritoryBonus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] TerritoryBonus territoryBonus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(territoryBonus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(territoryBonus);
        }

        // GET: TerritoryBonus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TerritoryBonus territoryBonus = db.TerritoryBonuses.Find(id);
            if (territoryBonus == null)
            {
                return HttpNotFound();
            }
            return View(territoryBonus);
        }

        // POST: TerritoryBonus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TerritoryBonus territoryBonus = db.TerritoryBonuses.Find(id);
            db.TerritoryBonuses.Remove(territoryBonus);
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
