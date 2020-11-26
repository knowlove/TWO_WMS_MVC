using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ChukuController : Controller
    {
        // GET: Chuku
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult renwudan()
        {
            return View();
        }
        public ActionResult jiagong()
        {
            return View();
        }
        public ActionResult zhijie()
        {
            return View();
        }
        public ActionResult Indexxq(int Q_Id)
        {
            ViewBag.Q_Id=Q_Id;
            return View();
        }
    }
}