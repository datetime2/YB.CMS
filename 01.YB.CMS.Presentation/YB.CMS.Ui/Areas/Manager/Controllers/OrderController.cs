using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YB.CMS.Models.Model;
using YB.CMS.IRepositories;
using DapperExtensions;

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
            var pg = new PredicateGroup { Operator = GroupOperator.And, Predicates = new List<IPredicate>() };
            pg.Predicates.Add(Predicates.Field<Himall_Orders>(f => f.OrderStatus, Operator.Eq, 2));
            var order = IOrderRepository.FindAll(pg);
            return View(order);
        }
    }
}