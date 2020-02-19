using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCRavenSaga.Models;
using System.Data.Entity.Validation;

namespace MVCRavenSaga.Controllers
{
    public class ArbolClasesController : Controller
    {
        private GameDBEntities db = new GameDBEntities();

        // GET: ArbolClases
        public ActionResult Index()
        {
            return View(db.ArbolClases.ToList());
        }

        // GET: ArbolClases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArbolClases arbolClases = db.ArbolClases.Find(id);
            if (arbolClases == null)
            {
                return HttpNotFound();
            }
            return View(arbolClases);
        }

        // GET: ArbolClases/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArbolClases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection CrearUnidad)
        {
            try
            {
                ArbolClases NewClass = new ArbolClases();
                NewClass.Clase = CrearUnidad["Clase"].ToString();
                Boolean tempVal = CrearUnidad["Promocion"] != null ? true : false;
                TempData["Promocion"] = tempVal;
                NewClass.Promocion = tempVal;
                NewClass.HPMax = int.Parse(CrearUnidad["HPMax"].ToString());
                NewClass.FuerzaMax = int.Parse(CrearUnidad["FuerzaMax"].ToString());
                NewClass.MagiaMax = int.Parse(CrearUnidad["MagiaMax"].ToString());
                NewClass.HabMax = int.Parse(CrearUnidad["HabMax"].ToString());
                NewClass.VelMax = int.Parse(CrearUnidad["VelMax"].ToString());
                NewClass.SuerMax = int.Parse(CrearUnidad["SuerMax"].ToString());
                NewClass.DefMax = int.Parse(CrearUnidad["DefMax"].ToString());
                NewClass.ResMax = int.Parse(CrearUnidad["ResMax"].ToString());
                db.ArbolClases.Add(NewClass);
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    ViewBag.MiMensaje = "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:" + "-" + "-" + eve.Entry.Entity.GetType().Name + "-" + eve.Entry.State;
                    var msj = eve.Entry.Entity.GetType().Name + " " + eve.Entry.State;

                    ViewBag.MiMensaje0 = msj.ToString();

                    foreach (var ve in eve.ValidationErrors)
                    {
                        ViewBag.MiMensaje1 = "- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"" + "-" + ve.PropertyName + " " + eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName) + " " + ve.ErrorMessage;
                    }
                }
                throw;
            }
            return RedirectToAction("Index");
        }

        // GET: ArbolClases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArbolClases arbolClases = db.ArbolClases.Find(id);
            if (arbolClases == null)
            {
                return HttpNotFound();
            }
            return View(arbolClases);
        }

        // POST: ArbolClases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDClase,Clase,HPMax,FuerzaMax,MagiaMax,HabMax,VelMax,SuerMax,DefMax,ResMax")] ArbolClases arbolClases)
        {
            if (ModelState.IsValid)
            {
                db.Entry(arbolClases).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(arbolClases);
        }

        // GET: ArbolClases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArbolClases arbolClases = db.ArbolClases.Find(id);
            if (arbolClases == null)
            {
                return HttpNotFound();
            }
            return View(arbolClases);
        }

        // POST: ArbolClases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArbolClases arbolClases = db.ArbolClases.Find(id);
            db.ArbolClases.Remove(arbolClases);
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
