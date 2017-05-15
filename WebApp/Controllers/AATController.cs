using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.WebReference;
using WebApp.helper;

namespace WebApp.Controllers
{
    public class AATController : Controller
    {
        private WS db = new WS();
        private List<CL_AAT_Order> _data;
        // GET: AAT
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [HttpGet]
        public ActionResult ORDER(string _date)
        {
            db = new WS();
            if (_date == null)
            {
                _data = db.AAT_show_order(DateTime.Now.ToString("yyyyMMdd")).ToList();
                return View(db.AAT_show_order(DateTime.Now.ToString("yyyyMMdd")).ToList());
            }
            else
            {
                _data = db.AAT_show_order(_date).ToList();
                return View(db.AAT_show_order(_date).ToList());
            }
        }

        [HttpGet]
        public FileContentResult ExportToExcel()
        {
            List<CL_AAT_Order> technologies = _data;
            string[] columns = { "PLANT", "SUPPL", "LINE", "TRIM-ON", "PART_NUMBER", "VIN_NUMBER" };
            byte[] filecontent = Export.ExportExcel(technologies, "Technology", true, columns);
            return File(filecontent, Export.ExcelContentType, "AAT" + DateTime.Now.ToString("yyyyMMdd").ToString() + ".xlsx");
        }
    }
}