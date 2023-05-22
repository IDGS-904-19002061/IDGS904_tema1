using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904_tema1.Controllers
{
    public class EjerciciosController : Controller
    {
        // GET: Ejercicios
        public ActionResult Traductor()
        {
            var tmp = new Traductor();
            Array data = tmp.read();
            ViewBag.Data = data;
            return View();
        }

        [HttpPost]
        public ActionResult Traductor(Traductor obj)
        {
            var tmp = new Traductor();
            tmp.save(obj);
            Array data = tmp.read();
            ViewBag.Data = data;
            return View();
        } 
        
        public ActionResult Translate()
        {
     
            return View();
        }

        [HttpPost]
        public ActionResult Translate(Translation obj)
        {
            var tmp = new Translation();
            string data = tmp.read(obj);
            ViewBag.Data = data;
            return View();
        }

        public ActionResult Triangulo()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Triangulo(Triangulo obj)
        {
            var tmp = new Triangulo();
            tmp = tmp.validations(obj);

            ViewBag.Data = tmp;

            return View();
        }




    }
}