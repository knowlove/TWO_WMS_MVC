using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult TaskAdd()
        {
            return View();
        }
        public ActionResult Task123()
        {
            return View();
        }
        public ActionResult caigou()
        {
            return View();
        }
        public ActionResult shangpin()
        {
            return View();
        }
        public ActionResult chuku()
        {
            return View();
        }
        public ActionResult xq(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult chukuxq(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public ActionResult shangpinxq(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}