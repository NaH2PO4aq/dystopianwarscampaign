using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DystopianWarsCampaign.Data_Access_Layer;
using DystopianWarsCampaign.Models.Map;

namespace DystopianWarsCampaign.Controllers
{
    public class TerritoryController : Controller
    {
        private MapContext db = new MapContext();

        // GET: Territory
        public ActionResult Index()
        {
            return View(db.Territories.ToList());
        }

        // GET: Territory/Details/5
        public ActionResult Details(int? id)
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
            return View(territory);
        }

        // GET: Territory/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Territory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description")] Territory territory)
        {
            if (ModelState.IsValid)
            {
                db.Territories.Add(territory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(territory);
        }

        // GET: Territory/Edit/5
        public ActionResult Edit(int? id)
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
            return View(territory);
        }

        // POST: Territory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description")] Territory territory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(territory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(territory);
        }

        // GET: Territory/Delete/5
        public ActionResult Delete(int? id)
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
            return View(territory);
        }

        // POST: Territory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Territory territory = db.Territories.Find(id);
            db.Territories.Remove(territory);
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
