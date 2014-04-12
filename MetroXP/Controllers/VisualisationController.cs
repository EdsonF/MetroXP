using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroXP.Controllers
{
    public class VisualisationController : Controller
    {
        //
        // GET: /Visualisation/
      
        public ActionResult Rating()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult ProgressBar()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Scroll()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Slider()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Carousel()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult TreeView()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Lists()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Hint()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Balloon()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Notices()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Panel()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Streamer()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

    }
}
