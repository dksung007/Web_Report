using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.WebReference;

namespace WebApp.Controllers
{
    public class U375Controller : Controller
    {
        private WS db;
        // GET: U375
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BOM()
        {
            db = new WS();
            return View(db.U375_show_bom().ToList());
        }
    }
}