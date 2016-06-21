using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YB.CMS.IRepositories;
using YB.CMS.Models.Model;
using YB.CMS.Models.Query;
using YB.CMS.Models.View;
namespace YB.CMS.Ui.Areas.Manager.Controllers
{
    public class SystemController : Controller
    {
        private readonly IDistributorRepository IDistributorRepository;

        public SystemController(IDistributorRepository _IDistributorRepository)
        {
            this.IDistributorRepository = _IDistributorRepository;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult getDistributor()
        {
            var list = IDistributorRepository.DropDistributor();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}