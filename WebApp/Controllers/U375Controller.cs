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
        private WS db = new WS();
        // GET: U375
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BOM()
        {            
            return View(db.U375_show_bom().ToList());
        }

        public ActionResult Find(string id)
        {
            return View("BOM",db.U375_find_bom(id).ToList());
        }

        
    }
}