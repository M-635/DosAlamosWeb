using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DosAlamosWEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre la aplicación.";

            return View();
        }

        public ActionResult Contacto()
        {
            ViewBag.Message = "Contacto";

            return View();
        }
    }
}