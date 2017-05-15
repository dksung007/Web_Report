using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using web_Service.CL;
using web_Service.Model;
using web_Service.DATA;

namespace web_Service
{
    /// <summary>
    /// Summary description for WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {
        private U375 U375 = new U375();
        private P375 P375 = new P375();
        private FORD FORD = new FORD();
        private AAT AAT = new AAT();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<tb_bom_u375> U375_show_bom()
        {
            return U375.show_bom().ToList();
        }
        [WebMethod]
        public List<tb_bom_u375> U375_find_bom(string id)
        {
            return U375.find_bom(id).ToList();
        }
        [WebMethod]
        public List<tb_st_u375> U375_stock(string _date)
        {
            return U375.Stock(_date).ToList();
        }
        [WebMethod]
        public List<tb_st_u375> U375_stock_FG(string _date)
        {
            return U375.Stock_FG(_date).ToList();
        }

        [WebMethod]
        public int U375_Finish_good()
        {
            return U375.finish_good();
        }
        [WebMethod]
        public int P375_Finish_good()
        {
            return P375.finish_good();
        }

        [WebMethod]
        public int FORD_Finish_good()
        {
            return FORD.finish_good();
        }
        [WebMethod]
        public List<CL_FORD_Order> FORD_show_order(string _date)
        {
            return FORD.show_order(_date);
        }

        [WebMethod]
        public List<CL_AAT_Order> AAT_show_order(string _date)
        {
            return AAT.show_order(_date);
        }
    }
}
