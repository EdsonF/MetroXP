using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetroXP.Controllers
{
    public class ThirdPartyController : Controller
    {
        //
        // GET: /ThirdParty/

        public ActionResult DataTables()
        {
            ViewBag.IsAjaxRequest = Request.IsAjaxRequest();
            return View();
        }

    }
}
