using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YB.CMS.Models.Model;
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
        // GET: Manager/Order
        public ActionResult List()
        {
            var order = IOrderRepository.FindAll(s => s.OrderStatus == 1);
            return View(order);
        }
    }
}