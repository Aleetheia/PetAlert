using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PetAlert.DAL;
using PetAlert.Models;

namespace PetAlert.Controllers
{
    public class WantedAdController : Controller
    {
        private PetAlertContext db = new PetAlertContext();

        // GET: WantedAd
        public ActionResult Index()
        {
            return View(db.WantedAd.ToList());
        }

        // GET: WantedAd/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WantedAd wantedAd = db.WantedAd.Find(id);
            if (wantedAd == null)
            {
                return HttpNotFound();
            }
            return View(wantedAd);
        }

        // GET: WantedAd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WantedAd/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WantedAdID,Title,AnimalID,AnimalTypeID,AuthorID,TownID,Date,Finished")] WantedAd wantedAd)
        {
            if (ModelState.IsValid)
            {
                db.WantedAd.Add(wantedAd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wantedAd);
        }

        // GET: WantedAd/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WantedAd wantedAd = db.WantedAd.Find(id);
            if (wantedAd == null)
            {
                return HttpNotFound();
            }
            return View(wantedAd);
        }

        // POST: WantedAd/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WantedAdID,Title,AnimalID,AnimalTypeID,AuthorID,TownID,Date,Finished")] WantedAd wantedAd)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wantedAd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wantedAd);
        }

        // GET: WantedAd/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WantedAd wantedAd = db.WantedAd.Find(id);
            if (wantedAd == null)
            {
                return HttpNotFound();
            }
            return View(wantedAd);
        }

        // POST: WantedAd/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WantedAd wantedAd = db.WantedAd.Find(id);
            db.WantedAd.Remove(wantedAd);
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
