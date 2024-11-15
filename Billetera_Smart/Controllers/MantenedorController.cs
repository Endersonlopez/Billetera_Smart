using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Billetera_Smart.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Ingresos()
        {
            return View();
        }

        public ActionResult Gastos()
        {
            return View();
        }
    }
}