using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DhEmpController : Controller
    {
        // GET: DhEmp
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAll()
        {
             return View();
        }
        public ActionResult Show()
        {
            return View();
        }
        public ActionResult GetXqy(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult UpEmp(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
