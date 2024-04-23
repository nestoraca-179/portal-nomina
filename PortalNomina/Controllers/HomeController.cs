using PortalNomina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalNomina.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Dashboard()
        {
            return View();
        }

        [Authorize]
        public ActionResult ReciboPago()
        {
            List<snemple> empleados = new NominaEntities().snemple.AsNoTracking().ToList();
            ViewBag.empleados = empleados;

            return View();
        }
    }
}