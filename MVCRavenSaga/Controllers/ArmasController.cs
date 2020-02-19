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
    public class ArmasController : Controller
    {
        private GameDBEntities db = new GameDBEntities();

        // GET: Armas
        public ActionResult Index()
        {
            return View(db.Armas.ToList());
        }

        // GET: Armas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Armas armas = db.Armas.Find(id);
            if (armas == null)
            {
                return HttpNotFound();
            }
            return View(armas);
        }

        // GET: Armas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Armas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDObjeto,IDArma,Nombre,Mt,Hit,Crit,Wt,ArmaPersonal,IDClase,Imagen")] Armas armas)
        {
            if (ModelState.IsValid)
            {
                db.Armas.Add(armas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(armas);
        }

        // GET: Armas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Armas armas = db.Armas.Find(id);
            if (armas == null)
            {
                return HttpNotFound();
            }
            return View(armas);
        }

        // POST: Armas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDObjeto,IDArma,Nombre,Mt,Hit,Crit,Wt,ArmaPersonal,IDClase,Imagen")] Armas armas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(armas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(armas);
        }

        // GET: Armas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Armas armas = db.Armas.Find(id);
            if (armas == null)
            {
                return HttpNotFound();
            }
            return View(armas);
        }

        // POST: Armas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Armas armas = db.Armas.Find(id);
            db.Armas.Remove(armas);
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
