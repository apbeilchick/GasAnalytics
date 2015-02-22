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
    public class FillUpController : Controller
    {
        private FillUpContext db = new FillUpContext();

        // GET: FillUps
        public ActionResult Index()
        {
            return View(db.FillUps.ToList());
        }

        // GET: FillUps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FillUp fillUp = db.FillUps.Find(id);
            if (fillUp == null)
            {
                return HttpNotFound();
            }
            return View(fillUp);
        }

        // GET: FillUps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FillUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FillUpId,StationId,CarId,Gallons,PricePerGallon,TripMileage,EnteredMPG,FillUpDate")] FillUp fillUp)
        {
            if (ModelState.IsValid)
            {
                db.FillUps.Add(fillUp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fillUp);
        }

        // GET: FillUps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FillUp fillUp = db.FillUps.Find(id);
            if (fillUp == null)
            {
                return HttpNotFound();
            }
            return View(fillUp);
        }

        // POST: FillUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FillUpId,StationId,CarId,Gallons,PricePerGallon,TripMileage,EnteredMPG,FillUpDate")] FillUp fillUp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fillUp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fillUp);
        }

        // GET: FillUps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FillUp fillUp = db.FillUps.Find(id);
            if (fillUp == null)
            {
                return HttpNotFound();
            }
            return View(fillUp);
        }

        // POST: FillUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FillUp fillUp = db.FillUps.Find(id);
            db.FillUps.Remove(fillUp);
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
