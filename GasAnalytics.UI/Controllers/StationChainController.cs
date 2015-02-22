using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GasAnalytics.DataAccess;
using GasAnalytics.Models;

namespace GasAnalytics.UI.Controllers
{
    public class StationChainController : Controller
    {
        private FillUpContext db = new FillUpContext();

        // GET: StationChain
        public ActionResult Index()
        {
            return View(db.StationChains.ToList());
        }

        // GET: StationChain/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StationChain stationChain = db.StationChains.Find(id);
            if (stationChain == null)
            {
                return HttpNotFound();
            }
            return View(stationChain);
        }

        // GET: StationChain/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StationChain/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StationChainId,Name")] StationChain stationChain)
        {
            if (ModelState.IsValid)
            {
                db.StationChains.Add(stationChain);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stationChain);
        }

        // GET: StationChain/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StationChain stationChain = db.StationChains.Find(id);
            if (stationChain == null)
            {
                return HttpNotFound();
            }
            return View(stationChain);
        }

        // POST: StationChain/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StationChainId,Name")] StationChain stationChain)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stationChain).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stationChain);
        }

        // GET: StationChain/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StationChain stationChain = db.StationChains.Find(id);
            if (stationChain == null)
            {
                return HttpNotFound();
            }
            return View(stationChain);
        }

        // POST: StationChain/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StationChain stationChain = db.StationChains.Find(id);
            db.StationChains.Remove(stationChain);
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
