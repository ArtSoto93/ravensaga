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
    public class ElementosController : Controller
    {
        private GameDBEntities db = new GameDBEntities();

        // GET: Elementos
        public ActionResult Index()
        {
            return View(db.Elementos.ToList());
        }

        // GET: Elementos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elementos elementos = db.Elementos.Find(id);
            if (elementos == null)
            {
                return HttpNotFound();
            }
            return View(elementos);
        }

        // GET: Elementos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Elementos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDElemento,Elemento,Bonificaciones")] Elementos elementos)
        {
            if (ModelState.IsValid)
            {
                db.Elementos.Add(elementos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elementos);
        }

        // GET: Elementos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elementos elementos = db.Elementos.Find(id);
            if (elementos == null)
            {
                return HttpNotFound();
            }
            return View(elementos);
        }

        // POST: Elementos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDElemento,Elemento,Bonificaciones")] Elementos elementos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elementos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(elementos);
        }

        // GET: Elementos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elementos elementos = db.Elementos.Find(id);
            if (elementos == null)
            {
                return HttpNotFound();
            }
            return View(elementos);
        }

        // POST: Elementos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Elementos elementos = db.Elementos.Find(id);
            db.Elementos.Remove(elementos);
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
