using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroXP.Controllers
{
    public class DateTimeController : Controller
    {
        //
        // GET: /DateTime/

        public ActionResult Calendar()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult DatePicker()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Times()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

    }
}
