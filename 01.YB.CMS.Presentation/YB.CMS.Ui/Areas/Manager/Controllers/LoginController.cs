using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YB.CMS.Ui.Areas.Manager.Controllers
{
    public class LoginController : Controller
    {
        // GET: Manager/Login
        public ActionResult Out()
        {
            return RedirectToAction("Index", "Login");
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}