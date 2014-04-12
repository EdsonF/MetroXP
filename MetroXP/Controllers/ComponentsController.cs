using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroXP.Controllers
{
    public class ComponentsController : Controller
    {
        //
        // GET: /Components/

        public ActionResult Tiles()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult NavigationBar()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }   
        
        public ActionResult Menus()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        } 
  
        public ActionResult FluentMenu()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        } 

        public ActionResult Sidebar()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        } 

        public ActionResult TabControl()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        } 

        public ActionResult Accordion()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }
 
        public ActionResult Buttons()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Breadcrumbs()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

        public ActionResult Wizard()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

    }
}
