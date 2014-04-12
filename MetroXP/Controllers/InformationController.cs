using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroXP.Controllers
{
    public class InformationController : Controller
    {
        //
        // GET: /Information/

        public ActionResult Window()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Dialog()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Notify()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public PartialViewResult DialogExample()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return PartialView();
        }
    }
}
