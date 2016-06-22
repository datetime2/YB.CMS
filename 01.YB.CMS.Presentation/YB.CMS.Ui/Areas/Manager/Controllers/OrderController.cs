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
    public class OrderController : Controller
    {
        private readonly IOrderRepository IOrderRepository;
        public OrderController(IOrderRepository _IOrderRepository)
        {
            this.IOrderRepository = _IOrderRepository;
        }
        #region View
        public ActionResult List()
        {
            return View();
        }
        #endregion
        #region Ajax Method
        [HttpGet]
        public JsonResult OrderList(long? orderid, DateTime? stime, DateTime? etime,string sortcolumn,string sortorder,int? page,int? pagesize,int? distributor)
        {
            var OrderQuery = new OrderQuery
            {
                OrderId = orderid,
                OrderDateS = stime,
                OrderDateE = etime,
                SortColumn = sortcolumn,
                IsDesc = sortorder == "desc",
                Page = page,
                PageSize = pagesize,
                DistributorId = distributor
            };
            var list = IOrderRepository.GetOrderList(OrderQuery);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}