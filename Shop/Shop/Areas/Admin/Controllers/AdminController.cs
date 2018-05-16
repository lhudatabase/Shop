using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Areas.Admin.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Messages()
        {
            return View();
        }

        public ActionResult Forms()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult UsersAccount()
        {
            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult FileManager()
        {
            return View();
        }

        public ActionResult Icon()
        {
            return View();
        }
    }
}