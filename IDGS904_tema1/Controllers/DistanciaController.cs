using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ViewResult Index()
        {
            var model = new Distancia();

            if (TempData.ContainsKey("Model"))
            {
                model = TempData["Model"] as Distancia;
            }

            return View(model);
        }

        public RedirectToRouteResult Result(Distancia d)
        {
            var model = new Distancia();
            model.distancia = d.Calcular();

            TempData["Model"] = model;

            return RedirectToAction("Index");
        }
    }
}