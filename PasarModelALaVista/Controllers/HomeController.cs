using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PasarModelALaVista.Models;
namespace PasarModelALaVista.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           
            DateTime factual = DateTime.Now;
            String mensaje;

            if (factual.Hour < 12)
                mensaje = "Buenos dias";
            else if (factual.Hour < 19)
                mensaje = "Buenas tardes";
            else
                mensaje = "Buenas noches";
            clsPersona persona = new clsPersona();
            persona.nombre = "Alejandro";
            ViewData["Saludo"] = mensaje;
            ViewBag.fecha = factual.ToLongDateString();
            return View(persona);
        }

        public ActionResult VistaListado() {
            var listado = new clsListadoPersona();
         return View(listado);
        }
    }
}