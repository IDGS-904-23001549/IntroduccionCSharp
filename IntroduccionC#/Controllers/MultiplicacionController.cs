using IntroduccionC_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionC_.Controllers
{
    public class MultiplicacionController : Controller
    {
        // GET y POST en el mismo método, como le gusta al profe
        public ActionResult Index(Multiplicacion m)
        {
            // Solo calculamos si enviaron algo (para que no salga "0=0" al abrir la página la primera vez)
            if (m.A != 0 || m.B != 0)
            {
                m.CalcularMultiplicacion();
            }

            return View(m);
        }
    }
}