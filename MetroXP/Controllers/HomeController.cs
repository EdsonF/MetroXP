using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroXP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Template()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }
    }
}
