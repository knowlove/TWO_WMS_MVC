using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class RedeployController : Controller
    {
        // GET: Redeploy
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Det(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Audit(int id)
        {
            ViewBag.id = id;
            return View();
        }
        /// <summary>
        /// 发配区
        /// </summary>
        /// <returns></returns>
        public ActionResult Area()
        {
            return View();
        }

        /// <summary>
        /// 入库
        /// </summary>
        /// <returns></returns>
        public ActionResult Stor()
        {
            return View();
        }

        /// <summary>
        /// 补货需求列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Rep()
        {
            return View();
        }

        /// <summary>
        /// 补货单列表详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Xq(int id)
        {
            ViewBag.id = id;
            return View();
        }

    }
}