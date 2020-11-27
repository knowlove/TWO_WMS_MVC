using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Show()
        {
            return View();
        }
        public ActionResult Xqy(int id)    //总库存查询详情
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult UpOrder(int id)    //总库存查询详情
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult DhDj()    //总库存查询详情
        {
            return View();
        }
        public ActionResult Kjdh1()    //总库存查询详情
        {
            return View();
        }
        public ActionResult Kjdh2(int id)    //总库存查询详情
        {
            ViewBag.id = id;
            return View();
        }
    }
}