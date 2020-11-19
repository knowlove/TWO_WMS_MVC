using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class Home_pageController : Controller
    {
        // GET: Home_page
        public ActionResult Groupbooking()    //位移中查询
        {
            return View();
        }
        public ActionResult Stocks()    //总库存查询
        {
            return View();
        }
        public ActionResult StocksXiang(int id)    //总库存查询详情
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult Stocks1()    //总库存查询
        {
            return View();
        }
        public ActionResult Security()    //安全库存预警（产品）
        {
            return View();
        }
        public ActionResult Security1()    //安全库存预警（商品）
        {
            return View();
        }
        public ActionResult Spectaculars()    //库存报警看板
        {
            return View();
        }
        public ActionResult Management()    //临期报警管理（产品）
        {
            return View();
        }
        public ActionResult Management2()    //临期报警管理（商品）
        {
            return View();
        }
        public ActionResult Precondition()    //前置仓库存查询
        {
            return View();
        }
        public ActionResult Distribution()    //库存分布表
        {
            return View();
        }
        public ActionResult Drop()    //吊牌查询
        {
            return View();
        }
        public ActionResult DropXiang(int id)    //吊牌详情
        {
            ViewBag.id = id;
            return View();
        }
    }
}
