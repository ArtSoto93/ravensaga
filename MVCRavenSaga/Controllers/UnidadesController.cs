using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCRavenSaga.Models;
using System.IO;

namespace MVCRavenSaga.Controllers
{
    public class UnidadesController : Controller
    {
        private GameDBEntities db = new GameDBEntities();

        // GET: Unidades
        public ActionResult Index()
        {
            var unidades = db.Unidades.Include(u => u.Elementos);
            return View(unidades.ToList());
        }

        // GET: Unidades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unidades unidades = db.Unidades.Find(id);
            if (unidades == null)
            {
                return HttpNotFound();
            }
            return View(unidades);
        }

        // GET: Unidades/Create
        public ActionResult Create()
        {
            ViewBag.Promo = new SelectList(db.ArbolClases.Where(x => x.Promocion), "IDClase", "Clase");
            ViewBag.Clase = new SelectList(db.ArbolClases, "IDClase", "Clase").Take(16);
            ViewBag.IDElemento = new SelectList(db.Elementos, "IDElemento", "Elemento");
            return View();
        }

        // POST: Unidades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection CrearUnidad, HttpPostedFileBase Pic)
        {
                try
                {
                Unidades NewUnit = new Unidades();
                //Definiciones básicas. Nombre, Clase Inicial, Nivel, 8 estadísticas.
                NewUnit.Nombre = CrearUnidad["Nombre"].ToString();
                NewUnit.IDClase = int.Parse(CrearUnidad["Clase"].ToString());
                NewUnit.Nivel = int.Parse(CrearUnidad["Nivel"].ToString());
                NewUnit.HP = int.Parse(CrearUnidad["HP"].ToString());
                NewUnit.Fuerza = int.Parse(CrearUnidad["Fuerza"].ToString());
                NewUnit.Magia = int.Parse(CrearUnidad["Magia"].ToString());
                NewUnit.Habilidad = int.Parse(CrearUnidad["Habilidad"].ToString());
                NewUnit.Velocidad = int.Parse(CrearUnidad["Velocidad"].ToString());
                NewUnit.Suerte = int.Parse(CrearUnidad["Suerte"].ToString());
                NewUnit.Defensa = int.Parse(CrearUnidad["Defensa"].ToString());
                NewUnit.Resistencia = int.Parse(CrearUnidad["Resistencia"].ToString());

                //Crecimientos
                NewUnit.IDPromocion = int.Parse(CrearUnidad["Promo"].ToString());
                Boolean tempVal = CrearUnidad["Promovido"] != null ? true : false;
                TempData["Promovido"] = tempVal;
                NewUnit.Promovido = tempVal;
                NewUnit.HPGr = int.Parse(CrearUnidad["HPGr"].ToString());
                NewUnit.FueGr = int.Parse(CrearUnidad["FueGr"].ToString());
                NewUnit.MagGr = int.Parse(CrearUnidad["MagGr"].ToString());
                NewUnit.HabGr = int.Parse(CrearUnidad["HabGr"].ToString());
                NewUnit.VelGr = int.Parse(CrearUnidad["VelGr"].ToString());
                NewUnit.SuerGr = int.Parse(CrearUnidad["SuerGr"].ToString());
                NewUnit.DefGr = int.Parse(CrearUnidad["DefGr"].ToString());
                NewUnit.ResGr = int.Parse(CrearUnidad["ResGr"].ToString());

                //Afinidad Elemental
                NewUnit.IDElemento = int.Parse(CrearUnidad["IDElemento"].ToString());

                //Foto, Fecha - Placeholders
                NewUnit.FechaNacimiento = DateTime.Parse(CrearUnidad["FechaNacimiento"].ToString());
                if (Pic != null)
                {
                    if (Path.GetExtension(Pic.FileName).ToLower() == ".jpg" || Path.GetExtension(Pic.FileName).ToLower() == ".jpeg" || Path.GetExtension(Pic.FileName).ToLower() == ".png")
                    {
                        NewUnit.Imagen = SalvarImagen(Pic);
                    }
                }
                    //NewUnit.Imagen = CrearUnidad["Imagen"].ToString();

                db.Unidades.Add(NewUnit);
                db.SaveChanges();

                }
                catch (Exception)
                {
                    throw;
                }
                return RedirectToAction("Index");
            }

        private string SalvarImagen(HttpPostedFileBase pic)
        {
            string baseurl = Server.MapPath("~/Imagenes/Unidades");
            string path = Path.Combine(baseurl, Path.GetFileName(pic.FileName));

            if (!Directory.Exists(baseurl))
            {
                Directory.CreateDirectory(baseurl);
            }
            pic.SaveAs(path);
            return "/Imagenes/Unidades/" + pic.FileName;
        }


        // GET: Unidades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unidades unidades = db.Unidades.Find(id);
            if (unidades == null)
            {
                return HttpNotFound();
            }

            ViewBag.Promo = new SelectList(db.ArbolClases.Where(x => x.Promocion), "IDClase", "Clase", unidades.IDPromocion);
            ViewBag.Clase = new SelectList(db.ArbolClases, "IDClase", "Clase", unidades.IDUnit).Take(16);
            ViewBag.IDElemento = new SelectList(db.Elementos, "IDElemento", "Elemento", unidades.IDElemento);
            return View(unidades);
        }

        // POST: Unidades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormCollection EditUnidad, HttpPostedFileBase Pic)
        {
            try
            {
                Unidades EditUnit = new Unidades();
                //Definiciones básicas. Nombre, Clase Inicial, Nivel, 8 estadísticas.
                EditUnit.Nombre = EditUnidad["Nombre"].ToString();
                EditUnit.IDClase = int.Parse(EditUnidad["Clase"].ToString());
                EditUnit.Nivel = int.Parse(EditUnidad["Nivel"].ToString());
                EditUnit.HP = int.Parse(EditUnidad["HP"].ToString());
                EditUnit.Fuerza = int.Parse(EditUnidad["Fuerza"].ToString());
                EditUnit.Magia = int.Parse(EditUnidad["Magia"].ToString());
                EditUnit.Habilidad = int.Parse(EditUnidad["Habilidad"].ToString());
                EditUnit.Velocidad = int.Parse(EditUnidad["Velocidad"].ToString());
                EditUnit.Suerte = int.Parse(EditUnidad["Suerte"].ToString());
                EditUnit.Defensa = int.Parse(EditUnidad["Defensa"].ToString());
                EditUnit.Resistencia = int.Parse(EditUnidad["Resistencia"].ToString());

                //Crecimientos
                EditUnit.IDPromocion = int.Parse(EditUnidad["Promo"].ToString());
                Boolean tempVal = EditUnidad["Promovido"] != null ? true : false;
                TempData["Promovido"] = tempVal;
                EditUnit.Promovido = tempVal;
                EditUnit.HPGr = int.Parse(EditUnidad["HPGr"].ToString());
                EditUnit.FueGr = int.Parse(EditUnidad["FueGr"].ToString());
                EditUnit.MagGr = int.Parse(EditUnidad["MagGr"].ToString());
                EditUnit.HabGr = int.Parse(EditUnidad["HabGr"].ToString());
                EditUnit.VelGr = int.Parse(EditUnidad["VelGr"].ToString());
                EditUnit.SuerGr = int.Parse(EditUnidad["SuerGr"].ToString());
                EditUnit.DefGr = int.Parse(EditUnidad["DefGr"].ToString());
                EditUnit.ResGr = int.Parse(EditUnidad["ResGr"].ToString());

                //Afinidad Elemental
                EditUnit.IDElemento = int.Parse(EditUnidad["IDElemento"].ToString());

                //Foto, Fecha - Placeholders
                EditUnit.FechaNacimiento = DateTime.Parse(EditUnidad["FechaNacimiento"].ToString());
                if (Pic != null)
                {
                    if (Path.GetExtension(Pic.FileName).ToLower() == ".jpg" || Path.GetExtension(Pic.FileName).ToLower() == ".jpeg" || Path.GetExtension(Pic.FileName).ToLower() == ".png")
                    {
                        EditUnit.Imagen = SalvarImagen(Pic);
                    }
                }
                else
                {
                    EditUnit.Imagen = EditUnidad["Imagen"].ToString();
                }
                db.Entry(EditUnit).State = EntityState.Modified;
                db.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }

        // GET: Unidades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Unidades unidades = db.Unidades.Find(id);
            if (unidades == null)
            {
                return HttpNotFound();
            }
            return View(unidades);
        }

        // POST: Unidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Unidades unidades = db.Unidades.Find(id);
            db.Unidades.Remove(unidades);
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
