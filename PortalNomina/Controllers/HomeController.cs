using PortalNomina.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PortalNomina.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string message = "")
        {
            ViewBag.User = new Users { Nombre = "", IsAdmin = false };
            ViewBag.Error = message;

            return View();
        }

        [Authorize]
        public ActionResult Dashboard()
        {
            ViewBag.User = Session["USER"] as Users;

            return View();
        }

        [Authorize]
        public ActionResult ReciboPago()
        {
            ViewBag.User = Session["USER"] as Users;
            ViewBag.empleados = new NominaEntities().snemple.AsNoTracking().ToList();

            return View();
        }
    }
}