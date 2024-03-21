using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PortalNomina.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            if (user == "admin" && pass == "12345")
            {
                FormsAuthentication.SetAuthCookie(user, false);
                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                return Content("Usuario y clave invalidos");
            }
        }
    }
}