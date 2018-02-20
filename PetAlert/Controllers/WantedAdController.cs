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
        //private WantedAd wantedAd;

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
        public ActionResult Create([Bind(Include = "WantedAdID,Title,AnimalID,AnimalTypeID,Author,Town,Date,Finished")] WantedAd wantedAd)
        {
            AnimalModel animalModel = null;
            try
            {
                animalModel = new AnimalModel()
                {
                    WantedAd = wantedAd,
                    Animals     = db.Animal.ToList(),
                    AnimalTypes = db.AnimalType.ToList()
                };
                if (ModelState.IsValid)
                {
                    db.WantedAd.Add(wantedAd);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Erreur");
            }
            catch(Exception ex)
            {

            }
            return View(animalModel);
        }
        
        // GET: WantedAd/Edit/5
        public ActionResult Edit(int? id)
        {

            AnimalModel animalModel = null;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WantedAd wantedAd = db.WantedAd.Find(id);
            if (wantedAd == null)
            {
                return HttpNotFound();
            }
            else
            {
                animalModel = new AnimalModel()
                {
                    WantedAd = wantedAd,
                    AnimalTypes = db.AnimalType.ToList(),
                    Animals = db.Animal.ToList()
                    
            };
            }
            return View(animalModel);
        }

        // POST: AnimalType/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WantedAdID,Title,AnimalID,AnimalTypeID,Author,Town,Date,Finished")] WantedAd wantedAd)
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
