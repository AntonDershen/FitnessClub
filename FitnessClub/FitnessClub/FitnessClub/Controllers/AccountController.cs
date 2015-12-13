using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FitnessClub.Models;

namespace FitnessClub.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new EntityModel())
                {
                    var users =
                        db.Users.Where(x => x.UserName == model.Name)
                            .Where(x => x.Password == model.Password)
                            .ToList();
                    if (users.Count > 0)
                    {
                        FormsAuthentication.SetAuthCookie(model.Name, false);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            ModelState.AddModelError("", "Неверное имя пользователя или пароль.");
            return View(model);
        }
        [Authorize]
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}