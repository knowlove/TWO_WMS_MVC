﻿using System;
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
    }
}