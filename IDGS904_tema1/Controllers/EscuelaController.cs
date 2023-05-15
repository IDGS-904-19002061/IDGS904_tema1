using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public JsonResult Index()
        {
            var pulque = new Productos()
            {
                Nombre = "Pulque 1",
                Descripcion = "Frutos rojos",
                Cantidad = 10,
                Produccion = new DateTime(2023, 5, 11)
            };

            return Json(pulque, JsonRequestBehavior.AllowGet);
            //return View();
        }

        public RedirectResult Vista()
        {
            return Redirect("https://google.com.mx");
        }
        
        public RedirectToRouteResult Vista2()
        {
            TempData["Nombre"] = "Edgar";

            return RedirectToAction("Index2", "Escuela");
        }

        public ActionResult Index2()
        {
            ViewBag.Grupo = "IDGS904";
            ViewData["Materia"] = "DWI";
            String nombre = "";
            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }

            ViewBag.Nombre = nombre;

            return View();
        }
    }
}