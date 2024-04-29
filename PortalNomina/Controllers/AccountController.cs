using PortalNomina.Models;
using System;
using System.Web.Mvc;
using System.Web.Security;
using System.Linq;

namespace PortalNomina.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
            {
                using (PortalNominaEntities db = new PortalNominaEntities())
                {
                    Users us = db.Users.AsNoTracking().SingleOrDefault(u => u.Username == user && u.Password == pass);

                    if (us == null)
                    {
                        return RedirectToAction("Index", "Home", new { message = "Usuario o clave incorrectos" });
                    }
                    else
                    {
                        if (!us.Active)
                            return RedirectToAction("Index", "Home", new { message = "Usuario inactivo" });

                        FormsAuthentication.SetAuthCookie(user, false);
                        Session["USER"] = us;

                        return RedirectToAction("Dashboard", "Home");
                    }
                }
            }
            else
            {
                return RedirectToAction("Index", "Home", new { message = "Debes ingresar usuario y clave" });
            }
        }

        public ActionResult Logout(string msg = "")
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();

            if (Request.Cookies["ASP.NET_SessionId"] != null)
            {
                Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
            }

            if (msg != "")
                return RedirectToAction("Index", "Home", new { message = msg });

            return RedirectToAction("Index", "Home");
        }
    }
}