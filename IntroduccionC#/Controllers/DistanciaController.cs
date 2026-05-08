using IntroduccionC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionC_.Controllers
{
    public class DistanciaController : Controller
    {
        public ActionResult Index(Distancia d)
        {
            d.CalcularDistancia();
            return View(d);
        }
    }
}
