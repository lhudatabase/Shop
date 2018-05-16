using Models;
using Shop.Areas.Admin.Code;
using Shop.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Shop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login

        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            //var result = new AccountModel().Login(model.UserName, model.Password);
            if (Membership.ValidateUser(model.UserName, model.Password) && ModelState.IsValid)
            {
                //SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                return RedirectToAction("Admin","Admin", new { area="Admin" });
            }
            else
            {
                ModelState.AddModelError("", "Username or password is incorrect. Please try again.");
            }
            return View(model);
        }
    }
}