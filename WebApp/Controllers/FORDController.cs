using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.WebReference;

namespace WebApp.Controllers
{
    public class FORDController : Controller
    {
        private WS db = new WS();
        // GET: FORD
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ORDER(string _date)
        {
            db = new WS();
            if (_date == null)
            {
                return View(db.FORD_show_order(DateTime.Now.ToString("yyyy-MM-dd")).ToList());
            }
            else
            {
                return View(db.FORD_show_order(_date).ToList());
            }
        }
    }
}