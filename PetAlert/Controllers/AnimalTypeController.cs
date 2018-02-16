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
    public class AnimalTypeController : Controller
    {
        private PetAlertContext db = new PetAlertContext();

        // GET: AnimalType
        public ActionResult Index()
        {
            return View(db.AnimalType.ToList());
        }

        // GET: AnimalType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalType animalType = db.AnimalType.Find(id);
            if (animalType == null)
            {
                return HttpNotFound();
            }
            return View(animalType);
        }

        // GET: AnimalType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalType/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnimalTypeID,Name")] AnimalType animalType)
        {
            if (ModelState.IsValid)
            {
                db.AnimalType.Add(animalType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(animalType);
        }

        // GET: AnimalType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalType animalType = db.AnimalType.Find(id);
            if (animalType == null)
            {
                return HttpNotFound();
            }
            return View(animalType);
        }

        // POST: AnimalType/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnimalTypeID,Name")] AnimalType animalType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(animalType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(animalType);
        }

        // GET: AnimalType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AnimalType animalType = db.AnimalType.Find(id);
            if (animalType == null)
            {
                return HttpNotFound();
            }
            return View(animalType);
        }

        // POST: AnimalType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AnimalType animalType = db.AnimalType.Find(id);
            db.AnimalType.Remove(animalType);
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
