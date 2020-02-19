using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCRavenSaga.Models;

namespace MVCRavenSaga.Controllers
{
    public class ApoyosController : Controller
    {
        private GameDBEntities db = new GameDBEntities();

        // GET: Apoyos
        public ActionResult Index()
        {
            var apoyos = db.Apoyos.Include(a => a.Elementos).Include(a => a.Elementos1).Include(a => a.Unidades).Include(a => a.Unidades1);
            return View(apoyos.ToList());
        }

        // GET: Apoyos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apoyos apoyos = db.Apoyos.Find(id);
            if (apoyos == null)
            {
                return HttpNotFound();
            }
            return View(apoyos);
        }

        // GET: Apoyos/Create
        public ActionResult Create()
        {
            ViewBag.IDElemA = new SelectList(db.Elementos, "IDElemento", "Elemento");
            ViewBag.IDElemB = new SelectList(db.Elementos, "IDElemento", "Elemento");
            ViewBag.IDUnitA = new SelectList(db.Unidades, "IDUnit", "Nombre");
            ViewBag.IDUnitB = new SelectList(db.Unidades, "IDUnit", "Nombre");
            return View();
        }

        // POST: Apoyos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDApoyo,IDUnitA,IDUnitB,IDElemA,IDElemB,Romance")] Apoyos apoyos)
        {
            if (ModelState.IsValid)
            {
                db.Apoyos.Add(apoyos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDElemA = new SelectList(db.Elementos, "IDElemento", "Elemento", apoyos.IDElemA);
            ViewBag.IDElemB = new SelectList(db.Elementos, "IDElemento", "Elemento", apoyos.IDElemB);
            ViewBag.IDUnitA = new SelectList(db.Unidades, "IDUnit", "Nombre", apoyos.IDUnitA);
            ViewBag.IDUnitB = new SelectList(db.Unidades, "IDUnit", "Nombre", apoyos.IDUnitB);
            return View(apoyos);
        }

        // GET: Apoyos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apoyos apoyos = db.Apoyos.Find(id);
            if (apoyos == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDElemA = new SelectList(db.Elementos, "IDElemento", "Elemento", apoyos.IDElemA);
            ViewBag.IDElemB = new SelectList(db.Elementos, "IDElemento", "Elemento", apoyos.IDElemB);
            ViewBag.IDUnitA = new SelectList(db.Unidades, "IDUnit", "Nombre", apoyos.IDUnitA);
            ViewBag.IDUnitB = new SelectList(db.Unidades, "IDUnit", "Nombre", apoyos.IDUnitB);
            return View(apoyos);
        }

        // POST: Apoyos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDApoyo,IDUnitA,IDUnitB,IDElemA,IDElemB,Romance")] Apoyos apoyos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apoyos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDElemA = new SelectList(db.Elementos, "IDElemento", "Elemento", apoyos.IDElemA);
            ViewBag.IDElemB = new SelectList(db.Elementos, "IDElemento", "Elemento", apoyos.IDElemB);
            ViewBag.IDUnitA = new SelectList(db.Unidades, "IDUnit", "Nombre", apoyos.IDUnitA);
            ViewBag.IDUnitB = new SelectList(db.Unidades, "IDUnit", "Nombre", apoyos.IDUnitB);
            return View(apoyos);
        }

        // GET: Apoyos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apoyos apoyos = db.Apoyos.Find(id);
            if (apoyos == null)
            {
                return HttpNotFound();
            }
            return View(apoyos);
        }

        // POST: Apoyos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Apoyos apoyos = db.Apoyos.Find(id);
            db.Apoyos.Remove(apoyos);
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
