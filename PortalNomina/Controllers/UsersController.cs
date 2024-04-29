using System;
using System.Linq;
using System.Web.Mvc;
using PortalNomina.Models;

namespace PortalNomina.Controllers
{
    public class UsersController : Controller
    {
        private readonly PortalNominaEntities db = new PortalNominaEntities();

        public ActionResult Index(string message = "", bool error = false)
        {
            ViewBag.User = Session["USER"] as Users;
            ViewBag.Message = message;
            ViewBag.Style = error ? "alert alert-danger" : "alert alert-success";

            return View();
        }

        [ValidateInput(false)]
        public ActionResult UsersGridViewPartial()
        {
            var model = db.Users;
            return PartialView("_UsersGridViewPartial", model.ToList());
        }

        public ActionResult Agregar()
        {
            ViewBag.User = Session["USER"] as Users;

            return View();
        }

        public ActionResult ProcessAgregar(string name, string user, string pass, string active, string admin)
        {
            string message, created = (Session["USER"] as Users).Nombre;
            bool error = false;

            try
            {
                Users us = new Users()
                {
                    Nombre = name,
                    Username = user,
                    Password = pass,
                    DateReg = DateTime.Now,
                    Active = active == "on",
                    IsAdmin = admin == "on",
                    CreatedBy = created
                };

                db.Users.Add(us);
                db.SaveChanges();
                message = "Usuario agregado con exito";
            }
            catch (Exception ex)
            {
                message = "Ha ocurrido un error: " + ex.Message;
                error = true;
            }

            return RedirectToAction("Index", new { message, error });
        }

        public ActionResult Editar(int id)
        {
            ViewBag.User = Session["USER"] as Users;
            ViewBag.userEdit = db.Users.AsNoTracking().SingleOrDefault(u => u.ID == id);

            return View();
        }

        public ActionResult ProcessEditar(int id, string name, string user, string pass, string active, string admin)
        {
            string message;
            bool error = false;

            try
            {
                Users us = db.Users.AsNoTracking().Single(u => u.ID == id);
                us.Nombre = name;
                us.Username = user;
                us.Password = pass;
                us.Active = active == "on";
                us.IsAdmin = admin == "on";

                db.Entry(us).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                message = "Usuario modificado con exito";
            }
            catch (Exception ex)
            {
                message = "Ha ocurrido un error: " + ex.Message;
                error = true;
            }

            return RedirectToAction("Index", new { message, error });
        }

        public ActionResult Eliminar(int id)
        {
            string message;
            bool error = false;

            try
            {
                Users us = db.Users.AsNoTracking().Single(u => u.ID == id);
                db.Users.Attach(us);
                db.Users.Remove(us);
                db.SaveChanges();

                message = "Usuario eliminado con exito";
            }
            catch (Exception ex)
            {
                message = "Ha ocurrido un error: " + ex.Message;
                error = true;
            }

            return RedirectToAction("Index", new { message, error });
        }
    }
}