using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;
using Capa_Entidad;
using Capa_Negocio;

namespace Billetera_Smart.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            return View();
        }

        [HttpGet]

        public JsonResult ListarUsuarios()
        {
            List<Tbl_Usuarios> oLista = new List<Tbl_Usuarios>();

            oLista = new CN_Tbl_Usuarios().Listar();

            return Json(oLista,JsonRequestBehavior.AllowGet);
        }

    }
}