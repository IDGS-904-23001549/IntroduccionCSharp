using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionC_.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Suma(string x, string y, string r1)
        {
            int res = Convert.ToInt16(x) + Convert.ToInt16(y);
            ViewBag.Res = Convert.ToString(res);

            return View();
        }
    }
}