using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRavenSaga.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int Promedios = 40;
            WCFPromedios.ServiceClient wcfPromedios = new WCFPromedios.ServiceClient();
            List<WCFPromedios.Promedios> ListPromedios = wcfPromedios.getPromediosEF(Promedios).ToList();
            ViewBag.PromediosL = ListPromedios;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Esta es una interfase para una base datos para un juego en desarrollo.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Para cualquier inconveniente, envíe un mensaje a correo@example.com";

            return View();
        }
    }
}