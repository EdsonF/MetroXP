using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroXP.Controllers
{
    public class BaseCssController : Controller
    {
        //
        // GET: /BaseCss/

        public ActionResult Requirements()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Global()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Grid()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Typography() 
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Tables() 
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Forms() 
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }


        public ActionResult Buttons() 
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Images() 
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Responsive()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Icons() 
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

    }
}