using MVC.Dh_Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class DhController : Controller
    {
        DhDal dd = new DhDal();
        // GET: Dh
        public ActionResult DhDj()
        {
            return View(dd.GetDhTables());
        }
        // GET: Dh
        public ActionResult FbpDh()
        {
            return View();
        }
        // GET: Dh
        public ActionResult KjDh()
        {
            return View();
        }
        // GET: Dh
        public ActionResult DhJl()
        {
            return View();
        }
        // GET: Dh
        public ActionResult Cgzj()
        {
            return View();
        }
    }
}