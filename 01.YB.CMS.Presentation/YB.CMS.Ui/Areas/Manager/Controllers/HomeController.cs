using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YB.CMS.Models.Model;
using YB.CMS.Models.Query;
using YB.CMS.IRepositories;
namespace YB.CMS.Ui.Areas.Manager.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeRepository IHomeRepository;
        public HomeController(IHomeRepository _IHomeRepository)
        {
            this.IHomeRepository = _IHomeRepository;
        }
        // GET: Manager/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Main()
        {
            return View();
        }

        [HttpGet]
        public JsonResult PlatHome()
        {
            return Json(IHomeRepository.PlatHomeModel(), JsonRequestBehavior.AllowGet);
        }
    }
}