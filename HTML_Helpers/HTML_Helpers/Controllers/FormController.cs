using HTML_Helpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_Helpers.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(Datos datos)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Resultado", datos);
            }
            else
            {
                return View("Formulario");
            }
        }

        public ActionResult Resultado(Datos datos)
        {
            return View(datos);

        }
    }
}